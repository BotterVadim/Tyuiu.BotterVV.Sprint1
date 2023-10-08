using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint1.Task6.V16.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Что?!";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            var wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
