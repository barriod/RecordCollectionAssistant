using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.Data;
using RecordCollectionAssistant.SystemControllers;

namespace RecordCollectionAssistantTests
{
    [TestClass]
    public class ListSortingTests
    {
        Record r1;
        Record r2;
        Record r3;
        Record r4;
        RecordController sortingCont;


        [TestInitialize]
        public void initTests()
        {
            sortingCont = new RecordController();

            r1 = new Record(new RecordInfoBuilder()
                .withRecordName("channel ORANGE")
                .withArtist("Frank Ocean")
                .withYear(2012)
                .withRecordCondition(RecordCondition.NearMint)
                .withSleeveCondition(RecordCondition.GoodPlus)
                .withPrice(75.00)
                .withID(100)
                .build());

            r2 = new Record(new RecordInfoBuilder()
                .withRecordName("The College Dropout")
                .withArtist("Kanye West")
                .withYear(2004)
                .withRecordCondition(RecordCondition.VeryGoodPlus)
                .withSleeveCondition(RecordCondition.VeryGood)
                .withPrice(25.04)
                .withID(99)
                .build());

            r3 = new Record(new RecordInfoBuilder()
                .withRecordName("Salad Days")
                .withArtist("Mac Demarco")
                .withYear(2014)
                .withRecordCondition(RecordCondition.Mint)
                .withSleeveCondition(RecordCondition.Mint)
                .withPrice(19.54)
                .withID(98)
                .build());

            r4 = new Record(new RecordInfoBuilder()
                .withRecordName("Malibu")
                .withArtist("Anderson .Paak")
                .withYear(2016)
                .withRecordCondition(RecordCondition.NearMint)
                .withSleeveCondition(RecordCondition.NearMint)
                .withPrice(28.92)
                .withID(97)
                .build());

            sortingCont.getRecordList().addRecord(r1);
            sortingCont.getRecordList().addRecord(r2);
            sortingCont.getRecordList().addRecord(r3);
            sortingCont.getRecordList().addRecord(r4);

        }

        [TestMethod]
        public void testSortByRecordName()
        {
            sortingCont.sortByRecordName();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().RecordName, "channel ORANGE");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().RecordName, "Malibu");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().RecordName, "Salad Days");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().RecordName, "The College Dropout");

        }

        [TestMethod]
        public void testSortByArtistName()
        {
            sortingCont.sortByArtistName();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().Artist, "Anderson .Paak");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().Artist, "Frank Ocean");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().Artist, "Kanye West");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().Artist, "Mac Demarco");
        }

        [TestMethod]
        public void testSortByLowestToHighestPrice()
        {
            sortingCont.sortByLowestToHighestPrice();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().RecordName, "Salad Days");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().RecordName, "The College Dropout");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().RecordName, "Malibu");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().RecordName, "channel ORANGE");
        }

        [TestMethod]
        public void testSortByHighestToLowestPrice()
        {
            sortingCont.sortByHighestToLowestPrice();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().RecordName, "channel ORANGE");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().RecordName, "Malibu");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().RecordName, "The College Dropout");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().RecordName, "Salad Days"); 
        }

        [TestMethod]
        public void sortOldestToNewest()
        {
            sortingCont.sortOldestToNewest();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().RecordName, "The College Dropout");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().RecordName, "channel ORANGE");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().RecordName, "Salad Days");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().RecordName, "Malibu");
        }

        [TestMethod]
        public void testSortNewestToOldest()
        {
            sortingCont.sortNewestToOldest();

            Assert.AreEqual(sortingCont.getRecordList().getList()[0].getInfo().RecordName, "Malibu");
            Assert.AreEqual(sortingCont.getRecordList().getList()[1].getInfo().RecordName, "Salad Days");
            Assert.AreEqual(sortingCont.getRecordList().getList()[2].getInfo().RecordName, "channel ORANGE");
            Assert.AreEqual(sortingCont.getRecordList().getList()[3].getInfo().RecordName, "The College Dropout");
        }
    }
}
