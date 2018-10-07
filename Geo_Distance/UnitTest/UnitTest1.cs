using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geo_Distance;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCorrectPoint()
        {
            var start = new Point
            {
                X = 0,
                Y = 180
            };

            var end = new Point
            {
                X = 65,
                Y = 0
            };


            var calculating = new Calculating(start, end);

            Assert.AreEqual(calculating.start, start);
            Assert.AreEqual(calculating.end, end);
        }


        [TestMethod]
        public void TestIncorrectPoint()
        {
            var start = new Point
            {
                X = 274,
                Y = 255
            };

            var end = new Point
            {
                X = 78,
                Y = 0
            };

            var calculating = new Calculating(start, end);

            Assert.AreNotEqual(calculating.start, start);
            Assert.AreNotEqual(calculating.end, end);
        }


        [TestMethod]
        public void TestCalculate1()
        {
            var start = new Point
            {
                X = 0,
                Y = 180
            };

            var end = new Point
            {
                X = 0,
                Y = 0
            };

            var calculating = new Calculating(start, end);

            Assert.AreEqual(20020, calculating.Distance(), 6000);
        }


        [TestMethod]
        public void TestCalculate2()
        {
            var start = new Point
            {
                X = 90,
                Y = 0
            };

            var end = new Point
            {
                X = 0,
                Y = 140
            };

            var calculating = new Calculating(start, end);

            Assert.AreEqual(10010, calculating.Distance(), 6000);
        }
    }
}
