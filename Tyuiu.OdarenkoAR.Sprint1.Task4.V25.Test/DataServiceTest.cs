using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint1.Task4.V25.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double wait = 0.649;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
