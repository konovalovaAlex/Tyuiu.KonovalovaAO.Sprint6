using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint6.Task5.V22.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startStep = -5;
            int stopStep = 5;
            int len = (stopStep - startStep) + 1;
            double[] res = new double[len];
            res = dataService.GetMassFunction(startStep, stopStep);
            double[] wait = new double[len];
            wait[0] = 70.14;
            wait[1] = 55.21;
            wait[2] = 41.05;
            wait[3] = 27.96;
            wait[4] = 15.48;
            wait[5] = 1;
            wait[6] = -13.06;
            wait[7] = -28.16;
            wait[8] = -42.96;
            wait[9] = -56.77;
            wait[10] = -69.83;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
