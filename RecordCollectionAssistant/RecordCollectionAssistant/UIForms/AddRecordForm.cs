using System;
using RecordCollectionAssistant;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;
using System.IO;
using RecordCollectionAssistant.SystemControllers;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.CommandPattern;

namespace RecordCollectionAssistant.UIForms
{
    /// <summary>
    /// Form for adding a new record
    /// </summary>
    public partial class AddRecordForm : Form
    {
        private const string ALBUM_NAME_ERROR_MSG = "Please include a valid album name";
        private const string ARTIST_NAME_ERROR_MSG = "Please include a valid artist name";
        private const string VALUE_ERROR_MSG = "Please include a valid (positive) value";
        private const string YEAR_ERROR_MSG = "Please include a valid release year";
        private const string PICTURE_ERROR_MSG = "Provide a unique record picture";

        private bool titleCheck;    //True for editing a record; false for adding a record
        private RecordController controller;
        private Record editRecord;
        private string originalAlbumArtName;
        private string updatedAlbumArtPic;

        /// <summary>
        /// Constructor, edit is if this is being used to edit an existing record = true. False for
        /// adding a record. RecordController is the controller object the system uses for 
        /// record operations.
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="c"></param>
        public AddRecordForm(bool edit, RecordController c)
        {
            controller = c;
            InitializeComponent();
            titleCheck = edit;
            SetDefaultValues();
            this.updatedAlbumArtPic = "None";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            displayInitialImage();
        }

        /// <summary>
        /// Constructor, edit is if this is being used to edit an existing record = true. False for
        /// adding a record. RecordController is the controller object the system uses for 
        /// record operations. Used with adding via barcode which returns an Record Info object
        /// for barcode.
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="c"></param>
        /// <param name="newInfo"></param>
        public AddRecordForm(bool edit, RecordController c, RecordInfo newInfo)
        { 
            controller = c;
            InitializeComponent();
            titleCheck = edit;
            SetDefaultValues();
            this.updatedAlbumArtPic = "None";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            populateNewByBarcodeInfo(newInfo);
        }

        /// <summary>
        /// Constructor, edit is if this is being used to edit an existing record = true. False for
        /// adding a record. RecordController is the controller object the system uses for 
        /// record operations.
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="c"></param>
        public AddRecordForm(bool edit, RecordController c, Record r)
        {
            editRecord = r;
            controller = c;
            originalAlbumArtName = r.getInfo().AlbumArt;
            this.updatedAlbumArtPic = r.getInfo().AlbumArt;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeComponent();
            titleCheck = edit;
            SetDefaultValues();

            this.populateEditInfo();

            if (r.getInfo().AlbumArt == "None" || r.getInfo().AlbumArt == "" || r.getInfo().AlbumArt == null)
            {
                displayInitialImage();
            }

            else if (r.getInfo().AlbumArt.Substring(0, 4) == "http")
                displayRecordImageURL(updatedAlbumArtPic);

            else
                this.DisplayRecordImage();
        }

        /// <summary>
        /// This method displays a simple image by default.
        /// </summary>
        public void displayInitialImage()
        {
            WebRequest request = WebRequest.Create("https://cdn.pixabay.com/photo/2016/01/03/00/43/upload-1118929_960_720.png");
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox1.Image = ResizeImage(Bitmap.FromStream(str), 220, 220);
                }
            }
        }

        /// <summary>
        /// This method displays an image from an URL
        /// </summary>
        /// <param name="URLstr"></param>
        public void displayRecordImageURL(string URLstr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URLstr);
            request.UserAgent = "Mozilla/5.0";

            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox1.Image = ResizeImage(Bitmap.FromStream(str), 220, 220);
                }
            }

        }

        /// <summary>
        /// Used for populating form with barcode adding record.
        /// </summary>
        /// <param name="info"></param>
        private void populateNewByBarcodeInfo(RecordInfo info)
        {
            updatedAlbumArtPic = info.AlbumArt;
            albumName_txtBox.Text = info.RecordName;
            artistName_txtBox.Text = info.Artist;
            yearReleased_txtBox.Text = info.Year.ToString();
            displayRecordImageURL(info.AlbumArt);
        }

        /// <summary>
        /// Helper method for populating form with edit record previous info from
        /// record being edited.
        /// </summary>
        private void populateEditInfo()
        {
            albumName_txtBox.Text = editRecord.getInfo().RecordName;
            artistName_txtBox.Text = editRecord.getInfo().Artist;
            currentValue_txtBox.Text = editRecord.getInfo().Price.ToString();

            yearReleased_txtBox.Text = editRecord.getInfo().Year.ToString();

            string recCond = editRecord.getInfo().RecordCondition.ToFriendlyString();
            string sleeveCond = editRecord.getInfo().SleeveCondition.ToFriendlyString();

            setEditingRecCondition(recCond);
            setEditingSleeveCond(sleeveCond);
			
			if(editRecord.getInfo().Note != null)
				notes_txtBox.Text = editRecord.getInfo().Note.ToString();
        }
        
        /// <summary>
        /// Helper method for setting record condition on form for editing records.
        /// </summary>
        /// <param name="cond"></param>
        private void setEditingRecCondition(string cond)
        {
            switch (cond)
            {
                case "Mint":
                    mediaCondition_comboBox.SelectedIndex = 0;
                    break;
                case "Near Mint":
                    mediaCondition_comboBox.SelectedIndex = 1;
                    break;
                case "Very Good Plus":
                    mediaCondition_comboBox.SelectedIndex = 2;
                    break;
                case "Very Good":
                    mediaCondition_comboBox.SelectedIndex = 3;
                    break;
                case "Good Plus":
                    mediaCondition_comboBox.SelectedIndex = 4;
                    break;
                case "Fair":
                    mediaCondition_comboBox.SelectedIndex = 5;
                    break;
                case "Poor":
                    mediaCondition_comboBox.SelectedIndex = 6;
                    break;
                default:
                    mediaCondition_comboBox.SelectedIndex = 0;
                    break;
            }
        }

        /// <summary>
        /// Helper method for setting sleeve condition on form for editing records.
        /// </summary>
        /// <param name="cond"></param>
        private void setEditingSleeveCond(string cond)
        {
            switch (cond)
            {
                case "Mint":
                    sleeveCondition_comboBox.SelectedIndex = 0;
                    break;
                case "Near Mint":
                    sleeveCondition_comboBox.SelectedIndex = 1;
                    break;
                case "Very Good Plus":
                    sleeveCondition_comboBox.SelectedIndex = 2;
                    break;
                case "Very Good":
                    sleeveCondition_comboBox.SelectedIndex = 3;
                    break;
                case "Good Plus":
                    sleeveCondition_comboBox.SelectedIndex = 4;
                    break;
                case "Fair":
                    sleeveCondition_comboBox.SelectedIndex = 5;
                    break;
                case "Poor":
                    sleeveCondition_comboBox.SelectedIndex = 6;
                    break;
                default:
                    sleeveCondition_comboBox.SelectedIndex = 0;
                    break;
            }
        }

        /// <summary>
        /// This method displays the image of the record when it has already been declared.
        /// </summary>
        private void DisplayRecordImage()
        {
            Image imageToResize = new Bitmap(this.editRecord.getInfo().AlbumArt);

            pictureBox1.Image = ResizeImage(imageToResize, 220, 220);
        }

        /// <summary>
        /// Sets default values for form before use populates form components
        /// for adding a record.
        /// </summary>
        private void SetDefaultValues()
        {
            if (titleCheck == true)
            {
                title_lbl.Text = "Editing a Record";
                addRecord_btn.Text = "Update";
            }
            else if (titleCheck == false)
            {
                title_lbl.Text = "Add a New Record";
            }

            mediaCondition_comboBox.SelectedIndex = 0;
            sleeveCondition_comboBox.SelectedIndex = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListRecordForm lrf = new ListRecordForm(controller);
            lrf.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Similar to the back button, but will create the record and then add it to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRecord_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string albumName = albumName_txtBox.Text;
            string artistName = artistName_txtBox.Text;
            int convertedYear = ProcessYearInput(yearReleased_txtBox.Text, ref flag);
            double value = ProcessValueInput(currentValue_txtBox.Text, ref flag);
            RecordCondition mediaCondEnum = ConvertRecordCondition(mediaCondition_comboBox.Text);
            RecordCondition sleeveCondEnum = ConvertSleeveCondition(sleeveCondition_comboBox.Text);
            string recordNote = notes_txtBox.Text;
            string albumArt = updatedAlbumArtPic;

            if (this.originalAlbumArtName == this.updatedAlbumArtPic)
                albumArt = this.originalAlbumArtName;

            if (albumName == "" || albumName == " ")
            {
                badAlbumName_lbl.Visible = true;
                albumName_txtBox.Text = "";
                flag = true;
            }
     
            if (artistName == "" || artistName == " ")
            {
                badArtistName_lbl.Visible = true;
                artistName_txtBox.Text = "";
                flag = true;
            }

            if (flag == false)
                FinalizeRecord(titleCheck, albumName, artistName, convertedYear, mediaCondEnum, sleeveCondEnum, value, albumArt, recordNote);
        }

        /// <summary>
        /// Helper method that processes price and ensures its valid.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private double ProcessValueInput(string value, ref bool flag)
        {
            double retValue = 0.0;

            //if(currentValue_txtBox.Text == "")
            //{
            //    badValue_lbl.Visible = true;
            //    currentValue_txtBox.Text = "";
            //    flag = true;
            //}

            try
            {
                retValue = Convert.ToDouble(currentValue_txtBox.Text);  //taken as a double

                if (retValue <= 0)
                {
                    badValue_lbl.Visible = true;
                    currentValue_txtBox.Text = "";
                    flag = true;
                }
            }

            catch (Exception)
            {
                badValue_lbl.Visible = true;
                currentValue_txtBox.Text = "";
                flag = true;
            }

            return retValue;
        }

        /// <summary>
        /// Processes year input to ensure the year is valid for adding/editing records.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private int ProcessYearInput(string year, ref bool flag)
        {
            int convertedYear = 0;

            try
            {
                if (year.Length != 4)
                {
                    badYear_lbl.Visible = true;
                    yearReleased_txtBox.Text = "";
                    flag = true;
                }
                convertedYear = Convert.ToInt32(year);
            }

            catch (Exception)
            {
                badYear_lbl.Visible = true;
                yearReleased_txtBox.Text = "";
                flag = true;
            }

            return convertedYear;
        }

        /// <summary>
        /// Will add or edit the record with the given information
        /// </summary>
        /// <param name="titleCheck"></param>
        /// <param name="albumName"></param>
        /// <param name="artistName"></param>
        /// <param name="convertedYear"></param>
        /// <param name="mediaCondEnum"></param>
        /// <param name="sleeveCondEnum"></param>
        /// <param name="value"></param>
        private void FinalizeRecord(bool titleCheck, string albumName, string artistName, int convertedYear,
            RecordCondition mediaCondEnum, RecordCondition sleeveCondEnum, double value, string albumArt, string note)
        {
            if (titleCheck == true)
            {
                controller.getRecordList().editRecordWithID(albumName, editRecord.getInfo().ID, artistName,
                    convertedYear, mediaCondEnum, sleeveCondEnum, value, albumArt, note);
                NavigateBackToHome();
            }

            else if (titleCheck == false)
            {
                controller.addNewRecord(albumName, artistName, convertedYear, mediaCondEnum, sleeveCondEnum, value, albumArt, note);
                NavigateBackToHome();
            }

        }

        /// <summary>
        /// Naviagtes back to ListRecordForm after operations are done on this form.
        /// </summary>
        private void NavigateBackToHome()
        {
            this.Hide();
            ListRecordForm lrf = new ListRecordForm(controller);
            lrf.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Converts the record conditions/sleeve conditions from the dropdown
        /// menus into actual Enum values.
        /// </summary>
        /// <param name="mediaCond"></param>
        /// <returns></returns>
        private RecordCondition ConvertRecordCondition(string mediaCond)
        {
            switch (mediaCond)
            {
                case "Mint (M)":
                    return RecordCondition.Mint;
                case "Near Mint (NM or M-)":
                    return RecordCondition.NearMint;
                case "Very Good Plus (VG+)":
                    return RecordCondition.VeryGoodPlus;
                case "Very Good (VG)":
                    return RecordCondition.VeryGood;
                case "Good Plus (G+)":
                    return RecordCondition.GoodPlus;
                case "Fair (F)":
                    return RecordCondition.Fair;
                case "Poor (P)":
                    return RecordCondition.Poor;
                default:
                    return RecordCondition.Mint;
            }
        }

        /// <summary>
        /// Converts the record conditions/sleeve conditions from the dropdown
        /// menus into actual Enum values.
        /// </summary>
        /// <param name="mediaCond"></param>
        /// <returns></returns>
        private RecordCondition ConvertSleeveCondition(string sleeveCond)
        {
            switch (sleeveCond)
            {
                case "Mint (M)":
                    return RecordCondition.Mint;
                case "Near Mint (NM or M-)":
                    return RecordCondition.NearMint;
                case "Very Good Plus (VG+)":
                    return RecordCondition.VeryGoodPlus;
                case "Very Good (VG)":
                    return RecordCondition.VeryGood;
                case "Good Plus (G+)":
                    return RecordCondition.GoodPlus;
                case "Fair (F)":
                    return RecordCondition.Fair;
                case "Poor (P)":
                    return RecordCondition.Poor;
                default:
                    return RecordCondition.Mint;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Image imageToResize = new Bitmap(open.FileName);

                pictureBox1.Image = ResizeImage(imageToResize, 220, 220);
                this.updatedAlbumArtPic = open.FileName; // This returns the path to the image!!
            }
        }

        /// <summary>
        /// To resize the image
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

        private void albumName_txtBox_TextChanged(object sender, EventArgs e)
        {
            badAlbumName_lbl.Visible = false;
        }

        private void artistName_txtBox_TextChanged(object sender, EventArgs e)
        {
            badArtistName_lbl.Visible = false;
        }

        private void currentValue_txtBox_TextChanged(object sender, EventArgs e)
        {
            badValue_lbl.Visible = false;
        }

        private void yearReleased_txtBox_TextChanged(object sender, EventArgs e)
        {
            badYear_lbl.Visible = false;
        }
    }
}

