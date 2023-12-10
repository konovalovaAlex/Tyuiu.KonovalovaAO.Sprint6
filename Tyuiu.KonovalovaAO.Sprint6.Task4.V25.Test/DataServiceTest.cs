﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint6.Task4.V25.Lib;
namespace Tyuiu.KonovalovaAO.Sprint6.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(1, 3);
            double[] wait = { 0.02, -1.87, 0 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
