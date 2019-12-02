using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.Data;


namespace RecordCollectionAssistant
{
    [TestClass]
    public class RecordListTests
    {
        RecordList rList = new RecordList();
        [TestMethod]
        public void testAddingValidRecords()
        {
            Record r1 = new Record(new RecordInfoBuilder()
                .withRecordName("test")
                .withArtist("testArtist")
                .withYear(2000)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Good)
                .withPrice(100.0)
                .withID(100)
                .build());

            Record r2 = new Record(new RecordInfoBuilder()
                .withRecordName("test2")
                .withArtist("testArtist")
                .withYear(1999)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Mint)
                .withPrice(200.0)
                .withID(99)
                .build());

            rList.addRecord(r1);
            Assert.AreEqual(rList.getRecord(100), r1);

            rList.addRecord(r2);
            Assert.AreEqual(rList.getRecord(99), r2);

            rList.removeRecord(100);
            rList.removeRecord(99);
        }

        [TestMethod]
        public void testRemovingRecords()
        {
            Record r2 = new Record(new RecordInfoBuilder()
                .withRecordName("test2")
                .withArtist("testArtist")
                .withYear(1999)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Mint)
                .withPrice(200.0)
                .withID(99)
                .build());
            rList.addRecord(r2);
            rList.removeRecord(r2.getInfo().ID);

            Assert.IsNull(rList.getRecord(r2.getInfo().ID));
        }

        [TestMethod]
        public void testFilteringRecords()
        {
            List<Record> tempList = new List<Record>();

            Record r7 = new Record(new RecordInfoBuilder()
                .withRecordName("Daniel12")
                .withArtist("TEST")
                .withYear(1999)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Good)
                .withPrice(200.0)
                .withID(99)
                .build());

            Record r8 = new Record(new RecordInfoBuilder()
                .withRecordName("Daniel13")
                .withArtist("TEST")
                .withYear(1999)
                .withRecordCondition(RecordCondition.Good)
                .withSleeveCondition(RecordCondition.Good)
                .withPrice(200.0)
                .withID(99)
                .build());

            rList.addRecord(r7);
            rList.addRecord(r8);

            tempList.Add(r7);

            Assert.ReferenceEquals(tempList, rList.filterList("12"));

            tempList.Remove(r7);
            tempList.Add(r8);

            Assert.ReferenceEquals(tempList, rList.filterList("13"));
        }

    }
        
}
