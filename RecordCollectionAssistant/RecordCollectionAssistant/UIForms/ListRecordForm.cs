﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordCollectionAssistant.SystemControllers;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.API;
using RecordCollectionAssistant.CommandPattern;
using System.Net;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace RecordCollectionAssistant.UIForms
{
    /// <summary>
    /// Main form for displaying record list for the current account,
    /// has all buttons for main fucntionality with records. Shows previews
    /// of records when checked.
    /// </summary>
    public partial class ListRecordForm : Form
    {
        #region variable delcarations

        //Record controller instance that holds most of the programs logic
        private RecordController controller;

        //Allows the form to make requests to the API
        private DiscogsRequestHandler reqHandler;

        //Invoker for the command pattern
        private RecordInvoker invoker;

        //Keeps track of the last selected record to display the preview
        private int lastSelectedIndex;

        #endregion


        #region constructors
        /// <summary>
        /// Constructor that takes a RecordController object from the LoginForm
        /// </summary>
        /// <param name="newController"></param>
        public ListRecordForm(RecordController newController)
        {
            controller = newController;
            invoker = controller.getInvoker();
            reqHandler = new DiscogsRequestHandler();

            InitializeComponent();

            if (invoker.checkUndoStack() == false)
                undoBtn.Enabled = false;
            else
                undoBtn.Enabled = true;
            if (invoker.checkRedoStack() == false)
                redoBtn.Enabled = false;
            else
                redoBtn.Enabled = true;
            controller.readRecordListToFile();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            this.IsMdiContainer = true;
            recordListView.View = View.Details;
            this.populateList(controller.getRecordList().getList());
            SetCollectionInfo();
        }
        #endregion


        #region helper functions
        /// <summary>
        /// Sets the Collection size display in the main menu of the GUi
        /// (Displayed along the top of the screen)
        /// </summary>
        private void SetCollectionInfo()
        {
            collectionOwner_lbl.Text = controller.getUsername() + "'s Collection";

            if (recordListView.Items.Count == 1)
                collectionSizeDisplay_lbl.Text = "1 Record";
            else
                collectionSizeDisplay_lbl.Text = recordListView.Items.Count.ToString() + " Records";
        }

        /// <summary>
        /// Displays all of the records from the list in the display
        /// </summary>
        /// <param name="listOfRecords"></param>
        public void populateList(List<Record> listOfRecords)  // listOfRecords passes a list of records that will be displayed
        {

            int len = listOfRecords.Count;

            for (int i = 0; i < len; i++)
            {
                string recordCon = listOfRecords[i].getInfo().RecordCondition.ToFriendlyString();
                string sleeveCon = listOfRecords[i].getInfo().SleeveCondition.ToFriendlyString();
                string year = listOfRecords[i].getInfo().Year.ToString();
                string priceV = listOfRecords[i].getInfo().Price.ToString("C2");
                string newID = listOfRecords[i].getInfo().ID.ToString();

                string[] row = { listOfRecords[i].getInfo().RecordName,
                                 listOfRecords[i].getInfo().Artist,
                    year,
                    recordCon + " / " + sleeveCon,
                    priceV,
                    newID
                };
                ListViewItem listViewItem = new ListViewItem(row);
                recordListView.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Displays the cover image for the selected record in the Preview section
        /// </summary>
        /// <param name="r"></param>
        private void DisplayRecordImage(Record r)
        {
            Image imageToResize = new Bitmap(r.getInfo().AlbumArt);

            pictureBox1.Image = ResizeImage(imageToResize, 220, 220);
        }

        /// <summary>
        /// Resizes the image so that it properly fits in the preview sec
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        #endregion


        #region event handlers

        /// <summary>
        /// Event handler for adding a record.
        /// Opens the add record form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            this.Hide();
            AddRecordForm arf = new AddRecordForm(false, controller);
            arf.ShowDialog();
            this.Close();
        }


        /// <summary>
        /// Event handler for logging out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logout_btn_Click(object sender, EventArgs e)
        {
            //Writes the record list to the file before leaving the form
            controller.readRecordListToFile();

            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }


        /// <summary>
        /// Event handler for when the delete button is clicked
        /// Deletes the checked record(s) from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            foreach (ListViewItem iterator in recordListView.SelectedItems)
            {

                int id = Convert.ToInt32(iterator.SubItems[5].Text);
                recordListView.Items.Remove(iterator);

                this.controller.removeRecord(id);
            }

            if (invoker.checkUndoStack() == false)
                undoBtn.Enabled = false;
            else
                undoBtn.Enabled = true;
            if (invoker.checkRedoStack() == false)
                redoBtn.Enabled = false;
            else
                redoBtn.Enabled = true;

            controller.readRecordListToFile();
            SetCollectionInfo();
        }


        /// <summary>
        /// Event handler for the edit button
        /// Opens the edit record form for the selected record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editRecord_btn_Click(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            var temp = recordListView.SelectedIndices;

            Record associatedRecord;
            int index = 0;

            if (temp.Count > 0)
            {
                index = temp[0];
                associatedRecord = controller.getRecordList().getList()[index];

                this.Hide();
                AddRecordForm arf = new AddRecordForm(true, controller, associatedRecord);
                arf.ShowDialog();
                this.Close();
            }
        }


        /// <summary>
        /// Begins searching when text is entered into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            string strToSearchBy = search_txtBox.Text;

            List<Record> filterListOfRecords = this.controller.getRecordList().filterList(strToSearchBy);
            recordListView.Items.Clear();
            this.populateList(filterListOfRecords);
        }


        /// <summary>
        /// Event handler when the add via barcode button is clicked
        /// Opens the add record form with populated information from the API request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addViaBarcode_btn_Click(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            RecordInfo newInfo = reqHandler.requestRecord(barcodeTxtBox.Text);
            if (newInfo.RecordName == "BadRec")
                barcodeTxtBox.Text = "Invalid Barcode";
            else
            {
                this.Hide();
                AddRecordForm arf = new AddRecordForm(false, controller, newInfo);
                arf.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// Sorts the list based on the selected criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sort_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            string text = sort_comboBox.Text;
            if (text == "Lowest Price")
                controller.sortByLowestToHighestPrice();
            else if (text == "Highest Price")
                controller.sortByHighestToLowestPrice();
            else if (text == "Artist")
                controller.sortByArtistName();
            else if (text == "Oldest To Newest")
                controller.sortOldestToNewest();
            else if (text == "Newest To Oldest")
                controller.sortNewestToOldest();
            else
                controller.sortByRecordName();

            recordListView.Items.Clear();
            populateList(controller.getRecordList().getList());
        }


        /// <summary>
        /// Event handler for the undo button
        /// Will undo the last add or delete action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoBtn_Click(object sender, EventArgs e)
        {
            invoker.undo();
            recordListView.Items.Clear();
            populateList(controller.getRecordList().getList());
            controller.readRecordListToFile();
            if (invoker.checkUndoStack() == false)
                undoBtn.Enabled = false;
            else
                undoBtn.Enabled = true;
            if (invoker.checkRedoStack() == false)
                redoBtn.Enabled = false;
            else
                redoBtn.Enabled = true;

            SetCollectionInfo();
        }


        /// <summary>
        /// Event handler for the redo button click
        /// Performs the redo action for an add or delete command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redoBtn_Click(object sender, EventArgs e)
        {
            invoker.redo();
            recordListView.Items.Clear();
            populateList(controller.getRecordList().getList());
            controller.readRecordListToFile();
            if (invoker.checkUndoStack() == false)
                undoBtn.Enabled = false;
            else
                undoBtn.Enabled = true;
            if (invoker.checkRedoStack() == false)
                redoBtn.Enabled = false;
            else
                redoBtn.Enabled = true;

            SetCollectionInfo();
        }

        #endregion


        /// <summary>
        /// Changes what image is displayed in the Preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;

            var temp = recordListView.SelectedIndices;

            Record associatedRecord;
            int index = 0;

            if (temp.Count > 0)
            {
                index = temp[0];
                lastSelectedIndex = index;
            }

            else
                index = lastSelectedIndex;

            associatedRecord = controller.getRecordList().getList()[index];

            artistDisplayBox_txtbox.Text = associatedRecord.getInfo().Artist;
            albumDisplayBox_txtbox.Text = associatedRecord.getInfo().RecordName;
            notes_richTxtBox.Text = associatedRecord.getInfo().Note;
            string albumArt = associatedRecord.getInfo().AlbumArt;


            if (albumArt == "" || albumArt == "None" || albumArt == null)
                pictureBox1.Image = null;

            else if (albumArt.Substring(0, 4) == "http")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(associatedRecord.getInfo().AlbumArt);
                request.UserAgent = "Mozilla/5.0";

                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBox1.Image = ResizeImage(Bitmap.FromStream(str), 220, 220);
                    }
                }
            }

            else
                DisplayRecordImage(associatedRecord);
        }


        /// <summary>
        /// Event handler for the export button
        /// Exports the open collection to a text file so that 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void export_btn_Click(object sender, EventArgs e)
        {

            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;


            const int DEBUG_DIRECTORY_OFFSET = 10;
            string directoryPath = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            string regularDirectory = directoryPath.Substring(0, directoryPath.Length - DEBUG_DIRECTORY_OFFSET);
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files|*.txt|All Files|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] stringElements = collectionOwner_lbl.Text.Split('\'');
                    File.Copy(regularDirectory + "\\AccountsDatabase\\RecordDirectory\\" + stringElements[0] + ".txt", sfd.FileName);
                }

            }
        }

        /// <summary>
        /// Selects a random record to listen to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_randomRecord_Click_1(object sender, EventArgs e)
        {
            Random rando = new Random();
            int randomRecordIndex = rando.Next(controller.getRecordList().getList().Count);
            Record associatedRecord;

            if (lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;


            associatedRecord = controller.getRecordList().getList()[randomRecordIndex];

            artistDisplayBox_txtbox.Text = associatedRecord.getInfo().Artist;
            albumDisplayBox_txtbox.Text = associatedRecord.getInfo().RecordName;
            notes_richTxtBox.Text = associatedRecord.getInfo().Note;
            string albumArt = associatedRecord.getInfo().AlbumArt;


            if (albumArt == "" || albumArt == "None" || albumArt == null)
                pictureBox1.Image = null;

            else if (albumArt.Substring(0, 4) == "http")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(associatedRecord.getInfo().AlbumArt);
                request.UserAgent = "Mozilla/5.0";

                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBox1.Image = ResizeImage(Bitmap.FromStream(str), 220, 220);
                    }
                }
            }

            else
                DisplayRecordImage(associatedRecord);
        }


        /// <summary>
        /// takes a record list from a file and displays it in a different window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void import_btn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var file = string.Empty;

            if(lbl_invalidImportError.Visible)
                lbl_invalidImportError.Visible = false;


            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = "j:\\";
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;


                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = dialog.FileName;
                    bool checker = checkForValidFile(filePath);

                    if (checker)
                    {
                        PreviewListForm arf = new PreviewListForm(filePath, this.controller);
                        arf.ShowDialog();
                    }

                }
            }
        }

        /// <summary>
        /// Makes sure that an imported file is valid
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private bool checkForValidFile(string filePath)
        {
            try
            {
                string line;
                StreamReader sr = new StreamReader(filePath);
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "")
                        break;
                    string[] splitString = line.Split('♥');
                    RecordInfo newInfo = (new RecordInfoBuilder().build());
                    int i = 0;
                    if (splitString[i] != "")
                        newInfo.RecordName = splitString[i++];
                    if (splitString[i] != "")
                        newInfo.ID = Int32.Parse(splitString[i++]);
                    if (splitString[i] != "")
                        newInfo.RecordCondition = getConditionFromString(splitString[i++]);
                    if (splitString[i] != "")
                        newInfo.SleeveCondition = getConditionFromString(splitString[i++]);
                    if (splitString[i] != "")
                        newInfo.Year = Int32.Parse(splitString[i++]);
                    if (splitString[i] != "")
                        newInfo.Artist = splitString[i++];
                    if (splitString[i] != "")
                        newInfo.Price = Convert.ToDouble(splitString[i++]);
                    if (splitString[i] != "")
                        newInfo.AlbumArt = splitString[i++];
                    if (splitString[i] != "")
                        newInfo.Note = splitString[i++];
                }

                sr.Close();
                sr.Dispose();

            }

            catch(Exception e)
            {
                lbl_invalidImportError.Visible = true;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Returns the record collection in a string
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public RecordCondition getConditionFromString(string Str)
        {
            switch (Str)
            {
                case "Mint":
                    return RecordCondition.Mint;
                case "Near Mint":
                    return RecordCondition.NearMint;
                case "Very Good Plus":
                    return RecordCondition.VeryGoodPlus;
                case "Good Plus":
                    return RecordCondition.GoodPlus;
                case "Good":
                    return RecordCondition.Good;
                case "Fair":
                    return RecordCondition.Fair;
                case "Poor":
                    return RecordCondition.Poor;
                default:
                    return RecordCondition.Mint;
            }
        }
    }
}

