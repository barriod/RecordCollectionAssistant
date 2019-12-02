using System;
using System.Collections.Generic;
using System.Linq;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.CommandPattern;
using System.Text;
using System.IO;

namespace RecordCollectionAssistant.SystemControllers
{
    /// <summary>
    /// This class handles all processing of records.
    /// </summary>
    public class RecordController
    {
        private RecordList recordList;
        private const int ID_GENERATOR_SEED = 95; //We want a constant seed for reproducable ID's for testing.
        private int currentID;
        private RecordInvoker recInvoker;
        private Account currentAccount;
       
        /// <summary>
        /// RecordController constructor, generates a unique ID for the list. (Good for accounts later).
        /// </summary>
        public RecordController()
        {
            if (recInvoker == null)
                recInvoker = new RecordInvoker();
            recordList = new RecordList();
            generateUniqueID();
        }

        /// <summary>
        /// Sets the invoker for the record controller.
        /// </summary>
        /// <param name="invoker"></param>
        public void addInvoker(RecordInvoker invoker)
        {
            this.recInvoker = invoker;
        }

        /// <summary>
        /// Gets the invoker the Record Controller is using.
        /// </summary>
        /// <returns></returns>
        public RecordInvoker getInvoker()
        {
            return recInvoker;
        }

        /// <summary>
        /// Calls for information from the UI and tells the recordList to create the new record.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="artist"></param>
        /// <param name="year"></param>
        /// <param name="recCond"></param>
        /// <param name="sleeveCond"></param>
        /// <param name="price"></param>
        /// <param name="albumArt"></param>
        /// <param name="note"></param>
        public void addNewRecord(string name, string artist, int year, RecordCondition recCond, RecordCondition sleeveCond, double price, string albumArt, string note)
        {
            this.generateNewID();
            Record newRecord = new Record(new RecordInfoBuilder()
                .withRecordName(name)
                .withArtist(artist)
                .withRecordCondition(recCond)
                .withSleeveCondition(sleeveCond)
                .withYear(year)
                .withPrice(price)
                .withID(currentID)
                .withAlbumArt(albumArt)
                .withNote(note)
                .build());
            //recordList.addRecord(newRecord);
            //CommandPattern
            recInvoker.doCommand(new AddRecord(newRecord, recordList));
        }

        /// <summary>
        /// Adds record to record list.
        /// </summary>
        /// <param name="rec"></param>
        public void addRecord(Record rec)
        {
            recordList.addRecord(rec);
        }

        /// <summary>
        /// Removes record from record list.
        /// </summary>
        /// <param name="id"></param>
        public void removeRecord(int id)
        {
            recInvoker.doCommand(new DeleteRecord(id, recordList));
        }

        /// <summary>
        /// Returns the RecordList object.
        /// </summary>
        /// <returns></returns>
        public RecordList getRecordList()
        {
            return this.recordList;
        }

        /// <summary>
        /// Used to set the current account that is logged into.
        /// </summary>
        /// <param name="a"></param>
        public void setAccount(Account a)
        {
            currentAccount = a;
        }

        /// <summary>
        /// Gets username of the current account logged in.
        /// </summary>
        /// <returns></returns>
        public string getUsername()
        {
            return currentAccount.username;
        }


        /// <summary>
        /// This method searches for all the records that contain the string (searchString) and returns them as a RecordList object .
        /// /*This could easily be changed to it returns a List<Record> but I think returning a RecordList object is much helpful right now.*/
        /// USE THIS METHOD TO PRINT THE NEW RECORD LIST AFTER SEARCHING!!!
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public RecordList searchRecord(string searchString)
        {
            List<Record> searchedList = recordList.filterList(searchString);
            RecordList cloneList = new RecordList(searchedList);
            return cloneList; //Needs some things updated in list and form first.
        }

        /// <summary>
        /// This will edit the record.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="newIdToEdit"></param>
        /// <param name="newArtist"></param>
        /// <param name="newYear"></param>
        /// <param name="newRecCond"></param>
        /// <param name="newSleeveCond"></param>
        /// <param name="newPrice"></param>
        public void editRecord(string newName, int newIdToEdit, string newArtist, int newYear, RecordCondition newRecCond, RecordCondition newSleeveCond, double newPrice, string albumArt, string newNote)
        {
            recordList.editRecordWithID(newName, newIdToEdit, newArtist, newYear, newRecCond, newSleeveCond, newPrice, albumArt, newNote);
            return;
        }

        /// <summary>
        /// Returns the record with the given ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Record getRecord(int id)
        {
            return recordList.getRecord(id);
        }

        /// <summary>
        /// Allows to edit the image for a specific record given an image filepath.
        /// </summary>
        /// <param name="record"></param>
        /// <param name="filePath"></param>
        public void editImage(Record record, string filePath)
        {
            record.getInfo().AlbumArt = filePath;
        }

        /// <summary>
        /// Sorts list by record name.
        /// </summary>
        public void sortByRecordName()
        {
            recordList.getList().Sort((x, y) => string.Compare(x.getInfo().RecordName, y.getInfo().RecordName));
        }

        /// <summary>
        /// Sorts list by artist name.
        /// </summary>
        public void sortByArtistName()
        {
            recordList.getList().Sort((x, y) => string.Compare(x.getInfo().Artist, y.getInfo().Artist));
        }

        /// <summary>
        /// Sorts list by price, lowest to highest.
        /// </summary>
        public void sortByLowestToHighestPrice()
        {
            recordList.getList().Sort((x,y) => x.getInfo().Price.CompareTo(y.getInfo().Price));
        }

        /// <summary>
        /// Sorts list by price, highest to lowest.
        /// </summary>
        public void sortByHighestToLowestPrice()
        {
            recordList.getList().Sort((x, y) => x.getInfo().Price.CompareTo(y.getInfo().Price));
            recordList.getList().Reverse();
        }

        /// <summary>
        /// Sorts list by year released, oldest to newest.
        /// </summary>
        public void sortOldestToNewest()
        {
            recordList.getList().Sort((x,y) => x.getInfo().Year.CompareTo(y.getInfo().Year));
        }

        /// <summary>
        /// Sorts list by year released, newest to oldest.
        /// </summary>
        public void sortNewestToOldest()
        {
            recordList.getList().Sort((x, y) => x.getInfo().Year.CompareTo(y.getInfo().Year));
            recordList.getList().Reverse();
        }

        /// <summary>
        /// Sorts the list by record condition.
        /// </summary>
        public void sortByRecCondition()
        {
            recordList.getList().OrderBy(x => x.getInfo().RecordCondition);
        }

        /// <summary>
        /// Sorts the list by sleeve condition.
        /// </summary>
        public void sortBySleeveCondition()
        {
            recordList.getList().OrderBy(x => x.getInfo().SleeveCondition);
        }

        /// <summary>
        /// Generates a unique ID for a new record.
        /// </summary>
        private void generateUniqueID()
        {
            Random random = new Random(ID_GENERATOR_SEED);
            const int idLength = 9;
            string idString = "";
            for (int i = 0; i < idLength; i++)
                idString += random.Next(0, 9).ToString();
            currentID = Int32.Parse(idString);
        }

        /// <summary>
        /// Updates the ID generator with the most recent ID added
        /// for this account. If this is a new account, will increment
        /// from the beggining ID.
        /// </summary>
        public void updateIDGenerator()
        {
            List<Record> recList = recordList.getList();
            int maxID = currentID;
            foreach (Record rec in recList)
            {
                if (rec.getInfo().ID > maxID)
                    maxID = rec.getInfo().ID;
            }
            currentID = maxID;
        }

        /// <summary>
        /// Reads the current list of records for this account into the 
        /// .txt file of records for this account.
        /// </summary>
        public void readRecordListToFile()
        {
            FileStream fsOverwrite = new FileStream(currentAccount.getRecordPath(), FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            List<Record> recList = recordList.getList();
            currentAccount.setRecList(recordList);
            if (recList.Count > 0)
            {
                foreach (Record record in recList)
                {
                    RecordInfo info = record.getInfo();
                    sw.WriteLine(info.RecordName + "♥" + info.ID + "♥" + info.RecordCondition + "♥"
                        + info.SleeveCondition + "♥" + info.Year + "♥" + info.Artist + "♥"
                        + info.Price + "♥" + info.AlbumArt + "♥" + info.Note);
                }
            }
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// Increments the unique ID.
        /// </summary>
        /// <returns></returns>
        private int generateNewID()
        {
            return ++currentID;
        }
    }


}
