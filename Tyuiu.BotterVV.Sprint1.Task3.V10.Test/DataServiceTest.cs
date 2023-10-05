using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds3 = new DataService();
            double number = 23.6;
            double rub = 23;
            var res = ds3.NumberToMoney(number);
            Assert.AreEqual(rub, res);
        }

        [TestMethod]
        public void ValidExpression1()
        {
            DataService1 ds33 = new DataService1();
            double number = 23.6;
            double kop = 60;
            var res = ds33.NumberToMoney(number);
            Assert.AreEqual(kop, res);
        }
    }
}
