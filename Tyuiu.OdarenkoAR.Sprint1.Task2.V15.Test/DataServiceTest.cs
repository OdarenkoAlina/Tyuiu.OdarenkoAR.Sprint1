using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint1.Task2.V15.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.CalculateCubeVolume(a);
            Assert.AreEqual(8, res);
        }
    }
}
