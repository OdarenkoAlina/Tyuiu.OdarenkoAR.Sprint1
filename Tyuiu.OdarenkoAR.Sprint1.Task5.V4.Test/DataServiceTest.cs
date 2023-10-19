using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint1.Task5.V4.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 5000;
            int wait = 1;
            var res = ds.SecondsToHours(k);
            Assert.AreEqual(wait, res);
        }
    }
}
