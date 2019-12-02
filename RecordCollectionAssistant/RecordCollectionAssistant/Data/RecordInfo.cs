namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// This class holds all information about the record
    /// </summary>
    public class RecordInfo
    {
        /// <summary>
        /// Constructor for the RecordInfo object, holding all information about the record.
        /// </summary>
        /// <param name="recName"></param>
        /// <param name="id"></param>
        /// <param name="recCond"></param>
        /// <param name="sleeveCond"></param>
        /// <param name="year"></param>
        /// <param name="artist"></param>
        /// <param name="price"></param>
        /// <param name="albumArt"></param>
        /// <param name="note"></param>
        public RecordInfo(string recName, int id, RecordCondition recCond, RecordCondition sleeveCond, int year, string artist, double price, string albumArt, string note)
        {
            this.RecordName = recName;
            this.RecordCondition = recCond;
            this.SleeveCondition = sleeveCond;
            this.Year = year;
            this.Artist = artist;
            this.Price = price;
            this.ID = id;
            this.AlbumArt = albumArt;
            this.Note = note;
        }

        #region Variable declarations

        /// <summary>
        /// Getters and setters for all information about the classes
        /// </summary>
        public string RecordName { get; set; }
        public int ID { get; set; }
        public RecordCondition RecordCondition { get; set; }
        public RecordCondition SleeveCondition { get; set; }
        public int Year { get; set; }
        public string Artist { get; set; }
        public double Price { get; set; }
        public string AlbumArt { get; set; }
        public string Note { get; set; }

        #endregion
    }
}