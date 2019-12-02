using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.CommandPattern;
using RecordCollectionAssistant.Data;

namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class RecordInvokerTests
    {
        RecordList list;
        RecordInvoker r;
        Record rec;

        [TestInitialize]
        public void initTests()
        {
            rec = new Record(new RecordInfoBuilder()
                .withRecordName("test")
                .withArtist("testArtist")
                .withYear(2000)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Good)
                .withPrice(100.0)
                .withID(100)
                .build());
            list = new RecordList();
            r = new RecordInvoker();
        }

        [TestMethod]
        public void checkDo()
        {
            r.doCommand(new AddRecord(rec, list));
            Assert.IsNotNull(list.getList());
        }

        [TestMethod]
        public void checkUndo()
        {
            r.undo();
            Assert.IsTrue(list.getList().Count < 1);
        }

        [TestMethod]
        public void checkRedo()
        {
            r.redo();
            Assert.IsNotNull(list.getList());
        }
    }
}
