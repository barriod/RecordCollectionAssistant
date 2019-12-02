using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// Account class that holds a record list for a specific user
    /// uniquely identified by a username
    /// </summary>
    public class Account
    {

        #region variable declarations
        //holds the record list tied to this account
        public RecordList list;

        //Username for this account
        public string username { get; private set; }

        //Password for this account
        public string password { get; private set; }

        //Filepath that holds the record list for this account
        public string filepath { get; set; }
        #endregion


        #region constructors

        /// <summary>
        /// Constructor that accepts a username and password to create a new account
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        public Account(string user, string pass)
        {
            this.username = user;
            this.password = pass;
            list = new RecordList();
        }

        /// <summary>
        /// Copy constructor for accounts
        /// </summary>
        /// <param name="a"></param>
        public Account(Account a)
        {
            this.username = a.username;
            this.password = a.password;
        }

        #endregion


        #region setters
        /// <summary>
        /// Sets the file path for the account
        /// </summary>
        /// <param name="path"></param>
        public void setFilePath(string path)
        {
            this.filepath = path;
        }



        /// <summary>
        /// Sets a new/updated record list for this account
        /// </summary>
        /// <param name="newList"></param>
        public void setRecList(RecordList newList)
        {
            list = newList;
        }
        #endregion


        #region getters
        /// <summary>
        /// Returns the record list attached to this account;
        /// </summary>
        /// <returns></returns>
        public RecordList getRecList()
        {
            return list;
        }


        /// <summary>
        /// Returns the filepath that holds the record for this accounts
        /// </summary>
        /// <returns></returns>
        public string getRecordPath()
        {
            return filepath;
        }


        #endregion

    }


}
