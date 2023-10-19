using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint1.Task7.V19.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -5.159;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
