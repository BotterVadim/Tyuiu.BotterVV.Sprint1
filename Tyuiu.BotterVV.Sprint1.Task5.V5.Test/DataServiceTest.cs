using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 65738.9432211;
            double wait = 9;
            var res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}
