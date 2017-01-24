using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BumerangVsto.Model;

namespace TestProject.ModelTest
{
    [TestClass]
    public class PriceTagListTest
    {
        [TestMethod]
        public void AddTest()
        {
            var list = new PriceTagList();
            var tag = new PriceTag("desc", "1000", "prv", "12342", "123/2134/2314");
        }
    }
}
