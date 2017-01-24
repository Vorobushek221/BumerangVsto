using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BumerangVsto.Business;

namespace TestProject.BusinessTest
{
    [TestClass]
    public class CurrencyConvertetTest
    {
        CurrencyConverter obj = new CurrencyConverter();

        [TestMethod]
        public void ConvetrByrToBynTest()
        {
            string byrStr = "16000";
            string bynStr = "1.60";
            string result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);

            byrStr = "100";
            bynStr = "0.01";
            result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);

            byrStr = "100";
            bynStr = "0.01";
            result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);

            byrStr = "10000";
            bynStr = "1.00";
            result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);

            byrStr = "999900000";
            bynStr = "99990.00";
            result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);

            byrStr = "0";
            bynStr = "0.00";
            result = obj.ConvetrByrToByn(byrStr);
            Assert.AreEqual(bynStr, result);
        }

        [TestMethod]
        public void ConvetrBynToByrTest()
        {
            string byrStr = "16000";
            string bynStr = "1.60";
            string result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);

            byrStr = "100";
            bynStr = "0.01";
            result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);

            byrStr = "100";
            bynStr = "0.01";
            result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);

            byrStr = "10000";
            bynStr = "1.00";
            result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);

            byrStr = "999900000";
            bynStr = "99990.00";
            result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);

            byrStr = "0";
            bynStr = "0.00";
            result = obj.ConvetrBynToByr(bynStr);
            Assert.AreEqual(byrStr, result);
        }



    }
}
