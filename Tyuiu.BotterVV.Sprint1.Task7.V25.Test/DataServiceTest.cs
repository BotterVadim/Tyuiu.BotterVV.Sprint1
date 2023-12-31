﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint1.Task7.V25.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6.858;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
