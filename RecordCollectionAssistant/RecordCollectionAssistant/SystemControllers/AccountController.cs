using RecordCollectionAssistant.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace RecordCollectionAssistant.SystemControllers
{
    /// <summary>
    /// Controller that operates on accounts. Does all logic/operations
    /// to add new accounts, remove accounts and retrieve record infromation
    /// for each account for the RecordController to use to add the saved
    /// records to the list of records.
    /// </summary>
    public class AccountController
    {
        #region Variable Declarations

        private List<Account> accountList = new List<Account>();
        private const int DEBUG_DIRECTORY_OFFSET = 10;
        private string directoryPath = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
        private string regularDirectory;
        private string accountListDirectory;
        private string recordsDirectory;
        private RecordController controller;
        private StreamWriter sw;
        private StreamReader sr;
        private Account currentAccount;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that takes a record controller from the starting file
        /// </summary>
        /// <param name="controller"></param>
        public AccountController(RecordController controller)
        {
            this.controller = controller;
            regularDirectory = directoryPath.Substring(0, directoryPath.Length - DEBUG_DIRECTORY_OFFSET);
            accountListDirectory = regularDirectory + "/AccountsDatabase/AccountInformation.txt";
            recordsDirectory = regularDirectory + "/AccountsDatabase/RecordDirectory";
        }

        #endregion

        /// <summary>
        /// Checks if there is a duplicate username in the accounts masterlist
        /// by checking if the username already is in existence.
        /// </summary>
        /// <param name="possibleUsername"></param>
        /// <returns></returns>
        public bool isDuplicateUsername(string possibleUsername)
        {
            foreach (Account a in accountList)
                if (a.username == possibleUsername)
                    return true;
            return false;
        }

        /// <summary>
        /// Gets the regular directory path to the project. Used for importing/exporting
        /// from textfiles within the project directories.
        /// </summary>
        /// <returns></returns>
        public string getRegularDirectoryPath()
        {
            return regularDirectory;
        }

        /// <summary>
        /// Verifies that the username and password credentials matches one of the
        /// accounts within the master account list.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Account verifyAccountLogin(string u, string pass)
        {
            foreach (Account acct in accountList)
            {
                if (u == acct.username && pass == acct.password)
                {
                    currentAccount = acct;
                    currentAccount.setFilePath(recordsDirectory + "/" + currentAccount.username + ".txt");
                    populateAccountRecordsFromFile();
                    controller.setAccount(currentAccount);
                    return acct;
                }
            }
            return null;
        }

        /// <summary>
        /// Populates the entire account list from the appropriate master
        /// .txt file that holds all account information. All methods then use
        /// the list generated from this method to check for validity with account
        /// opeartions rather than using the textfile to do so. (which would be bad)
        /// </summary>
        public void populateAccountRecordsFromFile()
        {
            string line;
            sr.Close();
            sr = new StreamReader(recordsDirectory + "/" + currentAccount.username + ".txt");
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

        /// <summary>
        /// Creates a single .txt directory file for a logged in accounts'
        /// list of records. Each account has it's own textfile with it's own
        /// record information.
        /// </summary>
        public void createRecordDirectory()
        {
            sw.Close();
            string path = recordsDirectory + "/" + currentAccount.username + ".txt";
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.Flush();
                sw.Close();
            }
        }

        /// <summary>
        /// Reads the accounts to the textfile that have been added during this session.
        /// When an account is made, it is added to the list of accounts this class holds
        /// and will add any new user/pass to the .txt file that holds the master list.
        /// </summary>
        public void readCurrentAccountsToList()
        {
            string line;
            sr = new StreamReader(accountListDirectory);
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                    break;
                string[] splitString = line.Split(':');
                accountList.Add(new Account(splitString[0], splitString[1]));
            }
            sr.Close();
            sr.Dispose();
        }

        /// <summary>
        /// Writes a new account to the file if it is made of master account list.
        /// </summary>
        /// <param name="a"></param>
        public void writeNewAccountToFile(Account a)
        {
            FileStream outputFileStream = new FileStream(accountListDirectory, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(outputFileStream);
            string username = a.username;
            string password = a.password;
            currentAccount = new Account(username, password);
            currentAccount.setFilePath(recordsDirectory + "/" + currentAccount.username + ".txt");
            controller.setAccount(currentAccount);
            sw.WriteLine(username + ":" + password);
            sw.Flush();
            createRecordDirectory();
            sw.Close();
            setCurrentAccount(a);
        }

        /// <summary>
        /// Adds account to the account list this class holds
        /// </summary>
        /// <param name="acc"></param>
        public void addAccount(Account acc)
        {
            accountList.Add(acc);
        }

        /// <summary>
        /// Sets the current account after logging in so that the 
        /// controller knows which recordlist to retrieve.
        /// </summary>
        /// <param name="acc"></param>
        public void setCurrentAccount(Account acc)
        {
            this.currentAccount = acc;
        }

        /// <summary>
        /// Removes an account from the list.
        /// </summary>
        /// <param name="acc"></param>
        public void removeAccount(Account acc)
        {
            accountList.Remove(acc);
        }

        /// <summary>
        /// Gets Record/Sleeve condition from string
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
