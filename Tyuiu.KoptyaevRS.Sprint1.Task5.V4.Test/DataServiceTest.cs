using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KoptyaevRS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 13257;
            int res = ds.SecondsToHours(x);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
