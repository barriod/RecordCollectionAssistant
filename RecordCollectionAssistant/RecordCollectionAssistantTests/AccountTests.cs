using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class AccountTests
    {
        private RecordList recList = new RecordList();
        private Account newAccount;

        [TestInitialize]
        public void initializeTests()
        {
            newAccount = new Account("durkeed", "likesjava");
            recList.addRecord(new Record(new RecordInfo("a", 1, RecordCondition.Good, RecordCondition.Good, 1, "b", 1, "c", "d")));
        }

        [TestMethod]
        public void testCopyRecs()
        {
            Account copiedAccount = new Account(newAccount);
            Assert.AreEqual(newAccount.username, copiedAccount.username);
            Assert.AreEqual(newAccount.password, copiedAccount.password);
        }

        [TestMethod]
        public void testRecordList()
        {
            newAccount.getRecList().addRecord(new Record(new RecordInfo("a", 1, RecordCondition.Good, RecordCondition.Good, 1, "b", 1, "c", "d")));
            Assert.ReferenceEquals(newAccount.getRecList(), recList);
        }

    }
}
