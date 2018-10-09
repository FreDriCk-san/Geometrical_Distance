using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project3;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class GeoPointTests
    {
        [TestMethod]
        public void TestCorrectPoint()
        {
            var start = new GeoPoint(0, 180);

            var end = new GeoPoint(65, 0);

            var calculating = new Calculating(start, end);

            Assert.AreEqual(calculating.Start, start);
            Assert.AreEqual(calculating.End, end);
        }


        [TestMethod]
        public void TestIncorrectPoint()
        {
            var start = new GeoPoint(255, 274);

            var end = new GeoPoint(0, 78);

            var calculating = new Calculating(start, end);

            Assert.AreNotEqual(calculating.Start, start);
            Assert.AreNotEqual(calculating.End, end);
        }


        [TestMethod]
        public void TestCalculate1()
        {
            var start = new GeoPoint(0, 0);

            var end = new GeoPoint(1, 0);

            var calculating = new Calculating(start, end);

            Assert.AreEqual(111, calculating.Distance(), 2);
        }


        [TestMethod]
        public void TestCalculate2()
        {
            var start = new GeoPoint(89.9, 0);

            var end = new GeoPoint(89.9, 1);

            var calculating = new Calculating(start, end);

            Assert.AreEqual(0.1, calculating.Distance(), 1);
        }
    }
}
