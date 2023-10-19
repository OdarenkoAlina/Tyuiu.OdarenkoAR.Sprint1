using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint1.Task6.V7.Lib;
namespace Tyuiu.OdarenkoAR.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string text = "Все полы вымыты";
            DataService ds = new DataService();
            var res = ds.DeleteLastLetter(text);
            string wait = text.Remove(text.Length - 1);
            Assert.AreEqual(wait, res);
        }
    }
}
