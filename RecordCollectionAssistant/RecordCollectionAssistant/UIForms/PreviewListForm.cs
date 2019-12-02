using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.SystemControllers;
using RecordCollectionAssistant.UIForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordCollectionAssistant
{
    public partial class PreviewListForm : Form
    {
        RecordController mainController;
        RecordController controller;
        String filePath;


        public PreviewListForm(String fp, RecordController mc)
        {
            InitializeComponent();
            this.mainController = mc;
            this.filePath = fp;
            this.controller = new RecordController();
            populateRecordController();
            populateList(controller.getRecordList().getList());
            updateLabels();
            
        }

        private void updateLabels()
        {
            lbl_collectionSizeDisplay.Text = controller.getRecordList().getList().Count.ToString() + " Records";

        }

        private void populateRecordController()
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
                Record newRec = new Record(newInfo);
                controller.addRecord(newRec);
            }
            controller.updateIDGenerator();
            sr.Close();
            sr.Dispose();
        }

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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
