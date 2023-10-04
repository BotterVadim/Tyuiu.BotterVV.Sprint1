using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint1.Task2.V22.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds2 = new DataService();
            int x, y, z;
            x = 10;
            y = 10;
            z = 10;
            var res = ds2.CalculateAVGValue(x, y, z);
            Assert.AreEqual(10, res);
        }
    }
}
