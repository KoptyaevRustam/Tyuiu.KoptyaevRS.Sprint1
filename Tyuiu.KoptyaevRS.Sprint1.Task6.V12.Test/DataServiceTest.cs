using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint1.Task6.V12.Lib;

namespace Tyuiu.KoptyaevRS.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "дождь идет, на улице дождь";
            DataService ds = new DataService();
            bool res = ds.CheckLastWordRepetiton(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
