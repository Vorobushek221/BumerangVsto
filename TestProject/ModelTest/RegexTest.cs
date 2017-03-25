using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using BumerangVsto.Model.Global;

namespace TestProject.ModelTest
{
    [TestClass]
    public class RegexTests
    {
        [TestMethod]
        public void ByrRegexTest()
        {
            var regex = new Regex(Constants.BynRegexPattern);
            string str = "0.99";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "1.99";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "5.99";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "1.00";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "0";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = ".12";
            Assert.AreEqual(regex.IsMatch(str), false);

            str = "120.";
            Assert.AreEqual(regex.IsMatch(str), false);

            str = "120";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "ag";
            Assert.AreEqual(regex.IsMatch(str), false);

            str = "0,00";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "123,10";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = "00,017";
            Assert.AreEqual(regex.IsMatch(str), true);

            str = ".";
            Assert.AreEqual(regex.IsMatch(str), false);

            str = ",";
            Assert.AreEqual(regex.IsMatch(str), false);
        }
    }
}
