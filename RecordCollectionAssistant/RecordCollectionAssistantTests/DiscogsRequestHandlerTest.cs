using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordCollectionAssistant.API;
using RecordCollectionAssistant.Data;

namespace RecordCollectionAssistant
{
    [TestClass]
    public class DiscogsRequestHandlerTest
    {
        DiscogsRequestHandler drh;
        long validBarcodeInt = 602527755281;
        string invalidBarcode;
        string validBarcode;

        [TestInitialize]
        public void initTests()
        {
            drh = new DiscogsRequestHandler();
            validBarcode = validBarcodeInt.ToString();
            invalidBarcode = "wuwuwuwuwueee";
        }

        [TestMethod]
        public void invalidBarcodeTest()
        {
            RecordInfo testInfo = drh.requestRecord(invalidBarcode);
            Assert.AreEqual(testInfo.Artist, null);
        }

        [TestMethod]
        public void validBarcodeTest()
        {
            RecordInfo testInfo = drh.requestRecord(validBarcode);
            Assert.AreEqual("channel ORANGE", testInfo.RecordName);
        }
    }
}
