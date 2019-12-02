using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordCollectionAssistant.SystemControllers;
using RecordCollectionAssistant.Data;


namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class RecordControllerTests
    {
        RecordController controller;

        [TestInitialize]
        public void initTests()
        {
            controller = new RecordController();
            controller.addNewRecord("Dark Side Of The Moon", "Pink Floyd", 1973, RecordCondition.Fair, RecordCondition.GoodPlus, 24.83, null, "Notes");
            controller.addNewRecord("The Wall", "Pink Floyd", 1979, RecordCondition.Good, RecordCondition.VeryGood, 33.83, null, "Notes");
            controller.addNewRecord("Blonde", "Frank Ocean", 2016, RecordCondition.Mint, RecordCondition.NearMint, 415.00, null, "Notes");
        }

        [TestMethod]
        public void searchTest()
        {
            List<Record> searchedList = controller.searchRecord("The Wa").getList();
            Assert.AreEqual("The Wall", searchedList[0].getInfo().RecordName);
        }

        [TestMethod]
        public void getRecordGetListTest()
        {
            Record testRec = controller.getRecordList().getList()[0];
            Record duplicateRec = controller.getRecord(testRec.getInfo().ID);
            Assert.AreEqual(testRec.getInfo().ID, duplicateRec.getInfo().ID);
        }

        [TestMethod]
        public void editRecordTest()
        {
            Record recToEdit = controller.getRecordList().getList()[0];
            controller.editRecord("NewName", recToEdit.getInfo().ID, recToEdit.getInfo().Artist, recToEdit.getInfo().Year, recToEdit.getInfo().RecordCondition, recToEdit.getInfo().SleeveCondition, 50.00, null, "Notes");
            Assert.AreEqual(recToEdit.getInfo().RecordName, "NewName");
        }
    }
}
