using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace UnitTest
{
    [TestClass]
    public class UnitTestApp01
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter app01 = new();
            
            app01.inputUnit = "miles";
            app01.outputUnit = "feet";

            app01.inputLength = 2;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(10560.0393700365, app01.outputLength);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter app01 = new();

            app01.inputUnit = "feet";
            app01.outputUnit = "miles";

            app01.inputLength = 10560;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(1.9999926220032003, app01.outputLength);
        }

        [TestMethod]
        public void TestMilesToMeters()
        {
            DistanceConverter app01 = new();

            app01.inputUnit = "miles";
            app01.outputUnit = "meters";

            app01.inputLength = 2;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(3218.7, app01.outputLength);
        }

        [TestMethod]
        public void TestMetersToMiles()
        {
            DistanceConverter app01 = new();

            app01.inputUnit = "meters";
            app01.outputUnit = "miles";

            app01.inputLength = 3218.69;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(1.9999938647410003, app01.outputLength);
        }

        [TestMethod]
        public void TestMetersToFeet()
        {
            DistanceConverter app01 = new();

            app01.inputUnit = "meters";
            app01.outputUnit = "feet";

            app01.inputLength = 2;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(6.56167979, app01.outputLength);
        }

        [TestMethod]
        public void TestFeetToMeters()
        {
            DistanceConverter app01 = new();

            app01.inputUnit = "feet";
            app01.outputUnit = "meters";

            app01.inputLength = 6.56168;

            app01.ConvertToMeters();
            app01.ConvertFromMeters();
            Assert.AreEqual(2.000000064, app01.outputLength);
        }
    }
}