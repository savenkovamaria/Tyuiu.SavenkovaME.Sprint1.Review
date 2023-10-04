using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 5.612;
            Assert.AreEqual(wait, res);
        }
    }
}
