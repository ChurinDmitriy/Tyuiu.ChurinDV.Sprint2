using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint2.Task3.V6.Lib;


namespace Tyuiu.ChurinDV.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.Calculate(x);
            double wait = 5.833;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.5;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -12;
            double res = ds.Calculate(x);
            double wait = -131.917;

            Assert.AreEqual(wait, res);
        }
    }
}
