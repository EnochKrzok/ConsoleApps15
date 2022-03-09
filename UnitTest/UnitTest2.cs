using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace UnitTest
{
    [TestClass]
    public class UnitTestApp02
    {
        [TestMethod]
        public void TestMetricUnderLow()
        {
            BMI app02 = new();

            app02.weight = 45.5;
            app02.height = 1.93;

            app02.MetricBMI();
            Assert.AreEqual(12 , Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricUnderHigh()
        {
            BMI app02 = new();

            app02.weight = 63.6;
            app02.height = 1.879;

            app02.MetricBMI();
            Assert.AreEqual(18 , Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricNormalLow()
        {
            BMI app02 = new();

            app02.weight = 47.1;
            app02.height = 1.6;

            app02.MetricBMI();
            Assert.AreEqual(18, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricNormalHigh()
        {
            BMI app02 = new();

            app02.weight = 65.9;
            app02.height = 1.651;

            app02.MetricBMI();
            Assert.AreEqual(24, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOverLow()
        {
            BMI app02 = new();

            app02.weight = 59.1;
            app02.height = 1.524;

            app02.MetricBMI();
            Assert.AreEqual(25, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOverHigh()
        {
            BMI app02 = new();

            app02.weight = 97.7;
            app02.height = 1.828;

            app02.MetricBMI();
            Assert.AreEqual(29, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb1Low()
        {
            BMI app02 = new();

            app02.weight = 75;
            app02.height = 1.574;

            app02.MetricBMI();
            Assert.AreEqual(30, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb1High()
        {
            BMI app02 = new();

            app02.weight = 79.5;
            app02.height = 1.524;

            app02.MetricBMI();
            Assert.AreEqual(34, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb2Low()
        {
            BMI app02 = new();

            app02.weight = 84.1;
            app02.height = 1.549;

            app02.MetricBMI();
            Assert.AreEqual(35, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb2High()
        {
            BMI app02 = new();

            app02.weight = 97.7;
            app02.height = 1.574;

            app02.MetricBMI();
            Assert.AreEqual(39, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb3Low()
        {
            BMI app02 = new();

            app02.weight = 93.2;
            app02.height = 1.524;

            app02.MetricBMI();
            Assert.AreEqual(40, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestMetricOb3High()
        {
            BMI app02 = new();

            app02.weight = 97.7;
            app02.height = 1.524;

            app02.MetricBMI();
            Assert.AreEqual(42, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialUnderLow()
        {
            BMI app02 = new();

            app02.weight = 100;
            app02.height = 76;

            app02.ImperialBMI();
            Assert.AreEqual(12, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialUnderHigh()
        {
            BMI app02 = new();

            app02.weight = 135;
            app02.height = 72;

            app02.ImperialBMI();
            Assert.AreEqual(18, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialNormalLow()
        {
            BMI app02 = new();

            app02.weight = 125;
            app02.height = 69;

            app02.ImperialBMI();
            Assert.AreEqual(18, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialNormalHigh()
        {
            BMI app02 = new();

            app02.weight = 125;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(24, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOverLow()
        {
            BMI app02 = new();

            app02.weight = 185;
            app02.height = 72;

            app02.ImperialBMI();
            Assert.AreEqual(25, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOverHigh()
        {
            BMI app02 = new();

            app02.weight = 215;
            app02.height = 72;

            app02.ImperialBMI();
            Assert.AreEqual(29, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb1Low()
        {
            BMI app02 = new();

            app02.weight = 155;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(30, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb1High()
        {
            BMI app02 = new();

            app02.weight = 175;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(34, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb2Low()
        {
            BMI app02 = new();

            app02.weight = 180;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(35, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb2High()
        {
            BMI app02 = new();

            app02.weight = 200;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(39, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb3Low()
        {
            BMI app02 = new();

            app02.weight = 205;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(40, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TestImperialOb3High()
        {
            BMI app02 = new();

            app02.weight = 215;
            app02.height = 60;

            app02.ImperialBMI();
            Assert.AreEqual(42, Math.Round(app02.bmi, MidpointRounding.AwayFromZero));
        }
    }
}
