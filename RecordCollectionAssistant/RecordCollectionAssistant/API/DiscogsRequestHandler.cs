using System.Net;
using RecordCollectionAssistant.Data;

namespace RecordCollectionAssistant.API
{
    /// <summary>
    /// This class handles all requests from the Discogs API.
    /// </summary>
    public class DiscogsRequestHandler
    {

        #region variable declarations
        //The beginning string for making an API request
        private const string discogsRequestStr = "https://api.discogs.com/database/search?barcode=";

        //The beginning of the URL needed to get a price suggestion from the API
        //private const string discogsPriceURL = "https://api.discogs.com/marketplace/price_suggestions/";

        //The private token specific to our account needed to access the API
        private const string privateToken = "&token=ShodKjTwqyTskQVcfnhGKLaQZajvcHNndfVykgHZ";

        //the private token needed to make a market request from the API
        //private const string marketToken = "?token=ShodKjTwqyTskQVcfnhGKLaQZajvcHNndfVykgHZ";

        //The record title for the given record
        private string titleStr;

        //The artist for the given record
        private string artistStr;

        //The year released for the given record
        private string yrStr;

        //The cover image for the given record
        private string coverImg;


        #endregion


        #region Constructors

        public DiscogsRequestHandler()
        {
            titleStr = "";
            artistStr = "";
            yrStr = "";
            coverImg = "";
        }

        #endregion

        /// <summary>
        /// Requests a record via the API given a string barcode.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public RecordInfo requestRecord(string barcode)
        {
            //The full url request to be sent to the API
            string requestStr = discogsRequestStr + barcode + privateToken;
      
            using (WebClient wc = new WebClient())
            {
                
                wc.Headers.Add("user-agent", "RCA");
                var json = wc.DownloadString(requestStr);
                string jsonString = json.ToString();
                filterJsonString(jsonString);
                if (titleStr == "")
                {
                    return new RecordInfoBuilder()
                    .withRecordName("BadRec")
                    .build();
                }
                return new RecordInfoBuilder()
                    .withRecordName(titleStr)
                    .withArtist(artistStr)
                    .withYear(int.Parse(yrStr))
                    .withAlbumArt(coverImg)
                    .build();
            } 
        }

        /// <summary>
        /// This method filters out important information from the JSON file given by the API.
        /// </summary>
        /// <param name="str"></param>
        private void filterJsonString(string str)
        {
            const string titleSearchStr = "title";
            const string yearSearchStr = "year";
            const string covImgSearchStr = "cover_image";
            //const string releaseIDStr = "id";
            string artistTitleStr = "";
            string[] jsonList = str.Split('"');
            const int parse_offset = 2;

            for(int i = 0; i < jsonList.Length; i++) 
            {
                if (jsonList[i].Contains(titleSearchStr))
                    artistTitleStr = jsonList[i + parse_offset];
                if (jsonList[i].Contains(yearSearchStr))
                    yrStr = jsonList[i + parse_offset];
                if (jsonList[i].Contains(covImgSearchStr))
                    coverImg = jsonList[i + parse_offset];
                //if (jsonList[i].Contains(releaseIDStr))
                //    releaseID = jsonList[i + parse_offset];
            }
            formatStringData(artistTitleStr);
        }

        /// <summary>
        /// Given the important info about a record, this method helps to format it for use in our program.
        /// </summary>
        /// <param name="artistTitleStr"></param>
        private void formatStringData (string artistTitleStr)
        {
            string[] strList = artistTitleStr.Split('-');
            if (strList.Length == 1)
                return;
            artistStr = strList[0];

            char[] temp = strList[1].ToCharArray();

            //copies the title without the leading space
            for (int x = 1; x < temp.Length; x++)
                titleStr += temp[x];
        }
    }
}
