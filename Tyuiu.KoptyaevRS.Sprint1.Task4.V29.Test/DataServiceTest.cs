using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.KoptyaevRS.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.0625, res);
        }
    }
}
