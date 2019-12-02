using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.SystemControllers;

namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class AccountControllerTests
    {
        Account a1;
        Account a2;
        Account a3;
        Account a4;
        AccountController actrl;
        RecordController rctrl;

        [TestInitialize]
        public void initAccountTests()
        {
            rctrl = new RecordController();
            actrl = new AccountController(rctrl);

            a1 = new Account("devin", "durkee");
            a2 = new Account("daniel", "barrio");
            a3 = new Account("ean", "baker");
            a4 = new Account("ryan", "debusk");

            actrl.addAccount(a1);
            actrl.addAccount(a2);
            actrl.addAccount(a3);
            actrl.addAccount(a4);

        }
        [TestMethod]
        public void invalidUsername()
        {
            Assert.IsNull(actrl.verifyAccountLogin("dev", "durkee"));
        }

        [TestMethod]
        public void invalidPassword()
        {
            Assert.IsNull(actrl.verifyAccountLogin("devin", "durkeed"));
        }

        [TestMethod]
        public void duplicatedUsernameTest()
        {
            Assert.IsTrue(actrl.isDuplicateUsername("devin"));
        }
    }
}
