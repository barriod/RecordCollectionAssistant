using System.Collections.Generic;
using System.Linq;

namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// This class manages the record list, includes all methods to manipulate records on the list.
    /// </summary>
    public class RecordList
    {
        #region Variable Declarations
        private List<Record> recordList;
        #endregion


        #region constructors


        /// <summary>
        /// Constructor for RecordList
        /// </summary>
        public RecordList()
        {
            this.recordList = new List<Record>();
        }
   
        /// <summary>
        /// Copy constructor for a RecordList object
        /// </summary>
        /// <param name="cloneList"></param>
        public RecordList(List<Record> cloneList)
        {
            this.recordList = cloneList;
        }

        #endregion


        #region list manipulation


        /// <summary>
        /// This method is used for testing purposes only (we need to get rid of it).
        /// </summary>
        /// <param name="newRecord"></param>
        public void addRecord(Record newRecord)
        {
            if (newRecord != null)
            {
                //Console.WriteLine("This record has been added.");
                recordList.Add(newRecord);
            }
            else
                return;
        }

        /// <summary>
        /// This method filters the list, through names with the given string given to it.
        /// </summary>
        /// <param name="str"></param>
        public List<Record> filterList(string str)
        {
            List<Record> filteredList = this.recordList.Where(x => x.containsCharacter(str)).ToList();
            return filteredList;
        }


        /// <summary>
        /// This method EDITS a record. How it works:
        ///     1. Parameters contain all the informatin about the record that is going to change ( the Id is always the same in each record and is not changeable ).
        ///     2. We loop through all the records until we match the one that matches the ID passed.
        ///     3. Then we call "editRecord" method in the record and will edit it.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="newIdToEdit"></param>
        /// <param name="newArtist"></param>
        /// <param name="newYear"></param>
        /// <param name="newRecCond"></param>
        /// <param name="newSleeveCond"></param>
        /// <param name="newPrice"></param>
        public void editRecordWithID(string newName, int newIdToEdit, string newArtist, int newYear,
            RecordCondition newRecCond, RecordCondition newSleeveCond, double newPrice, string albumArt, string newNote)
        {
            int len = this.recordList.Count;
            for (int i = 0; i < len; i++)
                if (this.recordList[i].getInfo().ID == newIdToEdit)
                    this.recordList[i].editRecord(newName, newArtist, newYear, newRecCond, newSleeveCond, newPrice, albumArt, newNote);
        }

        /// <summary>
        /// Removes any potential record within the list with the given id
        /// </summary>
        /// <param name="id"></param>
        public void removeRecord(int id)
        {
            for (int i = 0; i < recordList.Count; i++)
            {
                if (recordList[i].getInfo().ID == id)
                    recordList.RemoveAt(i);
            }
        }

        #endregion


        #region getters

        /// <summary>
        /// Gets a record within the list through an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Record getRecord(int id)
        {
            for (int i = 0; i < recordList.Count; i++)
            {
                if (recordList[i].getInfo().ID == id)
                    return recordList[i];
            }
            return null;
        }
        /// <summary>
        /// REturns the record list
        /// </summary>
        /// <returns></returns>
        public List<Record> getList()
        {
            return this.recordList;
        }

        #endregion


    }
}
