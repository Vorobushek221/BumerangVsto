using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BumerangVsto.Model.Money;

namespace TestProject.ModelTest.MoneyTest
{
    [TestClass]
    public class BynTest
    {
        [TestMethod]
        public void ByrCtorTest()
        {
            var sumOfMoney = Byn.GetInstance(0.78m);
            Assert.AreEqual(sumOfMoney.Rubbles, 0);
            Assert.AreEqual(sumOfMoney.Kopeck, 78);

            sumOfMoney = Byn.GetInstance(1789.1m);
            Assert.AreEqual(sumOfMoney.Rubbles, 1789);
            Assert.AreEqual(sumOfMoney.Kopeck, 10);

            sumOfMoney = Byn.GetInstance(0m);
            Assert.AreEqual(sumOfMoney.Rubbles, 0);
            Assert.AreEqual(sumOfMoney.Kopeck, 0);

            sumOfMoney = Byn.GetInstance(14m);
            Assert.AreEqual(sumOfMoney.Rubbles, 14);
            Assert.AreEqual(sumOfMoney.Kopeck, 0);

            sumOfMoney = Byn.GetInstance(15.1555m); 
            Assert.AreEqual(sumOfMoney.Rubbles, 15);
            Assert.AreEqual(sumOfMoney.Kopeck, 16);

            //------------------------------------------------------------

            sumOfMoney = Byn.GetInstance("15.85");
            Assert.AreEqual(sumOfMoney.Rubbles, 15);
            Assert.AreEqual(sumOfMoney.Kopeck, 85);

            sumOfMoney = Byn.GetInstance("15,85");
            Assert.AreEqual(sumOfMoney.Rubbles, 15);
            Assert.AreEqual(sumOfMoney.Kopeck, 85);

            sumOfMoney = Byn.GetInstance("0,8");
            Assert.AreEqual(sumOfMoney.Rubbles, 0);
            Assert.AreEqual(sumOfMoney.Kopeck, 80);

            sumOfMoney = Byn.GetInstance("0.08");
            Assert.AreEqual(sumOfMoney.Rubbles, 0);
            Assert.AreEqual(sumOfMoney.Kopeck, 8);
        }
    }
}
