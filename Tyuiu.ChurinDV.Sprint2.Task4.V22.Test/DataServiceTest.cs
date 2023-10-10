using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint2.Task4.V22.Lib;


namespace Tyuiu.ChurinDV.Sprint2.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 13;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 348.846;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.173;

            Assert.AreEqual(wait, res);
        }
    }
}
