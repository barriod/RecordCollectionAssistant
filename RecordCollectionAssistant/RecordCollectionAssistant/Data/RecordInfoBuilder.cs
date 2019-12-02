namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// This class is uses a builder design pattern to help create records.
    /// </summary>
    public class RecordInfoBuilder
    {
        #region Variable Declarations

        private string recordName;
        private int id;
        private RecordCondition recordCondition;
        private RecordCondition sleeveCondition;
        private int year;
        private string artist;
        private double price;
        private string albumArt;
        private string note;

        #endregion

        /// <summary>
        /// Adds a record name to the record
        /// </summary>
        /// <param name="newRecName"></param>
        /// <returns></returns>
        public RecordInfoBuilder withRecordName(string newRecName)
        {
            this.recordName = newRecName;
            return this;
        }

        /// <summary>
        /// Adds an id to the record
        /// </summary>
        /// <param name="newId"></param>
        /// <returns></returns>
        public RecordInfoBuilder withID(int newId)
        {
            this.id = newId;
            return this;
        }

        /// <summary>
        /// Adds a record condition to the record
        /// </summary>
        /// <param name="newRecCond"></param>
        /// <returns></returns>
        public RecordInfoBuilder withRecordCondition(RecordCondition newRecCond)
        {
            this.recordCondition = newRecCond;
            return this;
        }

        /// <summary>
        /// Adds a sleeve condition to the record
        /// </summary>
        /// <param name="newSleeveCond"></param>
        /// <returns></returns>
        public RecordInfoBuilder withSleeveCondition(RecordCondition newSleeveCond)
        {
            this.sleeveCondition = newSleeveCond;
            return this;
        }

        /// <summary>
        /// Adds a year to the record
        /// </summary>
        /// <param name="newYear"></param>
        /// <returns></returns>
        public RecordInfoBuilder withYear(int newYear)
        {
            this.year = newYear;
            return this;
        }

        /// <summary>
        /// Adds an artist to the record
        /// </summary>
        /// <param name="newArtist"></param>
        /// <returns></returns>
        public RecordInfoBuilder withArtist(string newArtist)
        {
            this.artist = newArtist;
            return this;
        }

        /// <summary>
        /// Adds a price to the record
        /// </summary>
        /// <param name="newPrice"></param>
        /// <returns></returns>
        public RecordInfoBuilder withPrice(double newPrice)
        {
            this.price = newPrice;
            return this;
        }

        /// <summary>
        /// Adds album art (via a path) to the record
        /// </summary>
        /// <param name="albumArt"></param>
        /// <returns></returns>
        public RecordInfoBuilder withAlbumArt(string albumArt)
        {
            this.albumArt = albumArt;
            return this;
        }

        /// <summary>
        /// Adds a note to the record
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public RecordInfoBuilder withNote(string note)
        {
            this.note = note;
            return this;
        }

        /// <summary>
        /// Builds the RecordInfo object given the information from the builder
        /// </summary>
        /// <returns></returns>
        public RecordInfo build()
        {
            return new RecordInfo(this.recordName, this.id, this.recordCondition, this.sleeveCondition, this.year, this.artist, this.price, this.albumArt, this.note);
        }
    }
}
