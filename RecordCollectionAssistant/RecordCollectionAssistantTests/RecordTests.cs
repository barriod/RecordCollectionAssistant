using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordCollectionAssistant.Data;

namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class RecordTests
    {
        Record newRec;
        int id = 10101;

        [TestInitialize]
        public void initTests()
        {
            int id = 10101;
            newRec = new Record(new RecordInfoBuilder()
                .withRecordName("All Eyez On Me")
                .withArtist("Tupac Shakur")
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Good)
                .withYear(1996)
                .withPrice(110.0)
                .withID(id)
                .build());
        }

        [TestMethod]
        public void recordCopyingTests()
        {
            Record copiedRec = new Record(newRec.getInfo());
            Assert.AreEqual(id, copiedRec.getInfo().ID);
        }

        [TestMethod]
        public void editRecordAndGettersTest()
        {
            newRec.editRecord(newRec.getInfo().RecordName, newRec.getInfo().Artist,
                newRec.getInfo().Year, newRec.getInfo().RecordCondition, newRec.getInfo().SleeveCondition, 50.00, null, newRec.getInfo().Note);
            Assert.AreEqual(50.0, newRec.getInfo().Price);
        }

        [TestMethod]
        public void containsCharacterTest()
        {
            Assert.IsTrue(newRec.containsCharacter("All"));
            Assert.IsFalse(newRec.containsCharacter("zzz"));
        }

    }
}
