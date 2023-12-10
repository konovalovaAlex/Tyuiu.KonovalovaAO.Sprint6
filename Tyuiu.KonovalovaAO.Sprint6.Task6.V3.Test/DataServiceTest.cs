using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V3";

            string res = ds.CollectTextFromFile(path);
            string wait = "rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz";
            Assert.AreEqual(wait, res);
        }
    }
}
