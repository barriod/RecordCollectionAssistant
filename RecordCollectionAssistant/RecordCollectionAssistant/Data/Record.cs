using System;

namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// This class is a template for a record.
    /// </summary>
    public class Record
    {
        #region variable declarations
        RecordInfo info;
        #endregion

        /// <summary>
        /// Constructor for Record, holding a RecordInfo object
        /// </summary>
        /// <param name="info"></param>
        public Record(RecordInfo info)
        {
            this.info = info;
        }

        /// <summary>
        /// Retrieves an object holding the inner record information
        /// </summary>
        /// <returns></returns>
        public RecordInfo getInfo()
        {
            return info;
        }

        /// <summary>
        /// This method edits the record, and changes all the values of it, even if the value passed and the one already there are the same.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="artist"></param>
        /// <param name="year"></param>
        /// <param name="recCond"></param>
        /// <param name="sleeveCond"></param>
        /// <param name="price"></param>
        public void editRecord(string name, string artist, int year, RecordCondition recCond, RecordCondition sleeveCond, double price, string albumArt, string note)
        {
            info.RecordName = name;
            info.RecordCondition = recCond;
            info.SleeveCondition = sleeveCond;
            info.RecordCondition = recCond;
            info.Year = year;
            info.Artist = artist;
            info.Price = price;
            info.AlbumArt = albumArt;
            info.Note = note;
        }

        /// <summary>
        /// Danies method dont touch     (Edit by Ryan: This should not be in here since it is used for testing only.)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool containsCharacter(string str)
        {
            if (info.RecordName.Contains(str))
                return true;
            else
                return false;
        }
    }
}