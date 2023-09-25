using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint1.Task3.V9.Lib;

namespace Tyuiu.KoptyaevRS.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 150;
            var res1 = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(2, res1);
            var res2 = ds.ConvertMinutesToMinutes(x);
            Assert.AreEqual(30, res2);
        }
    }
}
