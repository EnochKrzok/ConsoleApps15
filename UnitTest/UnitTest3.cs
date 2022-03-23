using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace UnitTest
{
    [TestClass]
    public class UnitTestApp03
    {
        [TestMethod]
        public void TestZerotoGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(0);

            Assert.AreEqual(Grades.F, grade);
        }

        [TestMethod]
        public void Test39toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(39);

            Assert.AreEqual(Grades.F, grade);
        }

        [TestMethod]
        public void Test40toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(40);

            Assert.AreEqual(Grades.D, grade);
        }

        [TestMethod]
        public void Test49toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(49);

            Assert.AreEqual(Grades.D, grade);
        }

        [TestMethod]
        public void Test50toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(50);

            Assert.AreEqual(Grades.C, grade);
        }

        [TestMethod]
        public void Test59toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(59);

            Assert.AreEqual(Grades.C, grade);
        }

        [TestMethod]
        public void Test60toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(60);

            Assert.AreEqual(Grades.B, grade);
        }

        [TestMethod]
        public void Test69toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(69);

            Assert.AreEqual(Grades.B, grade);
        }

        [TestMethod]
        public void Test70toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(70);

            Assert.AreEqual(Grades.A, grade);
        }

        [TestMethod]
        public void Test100toGrade()
        {
            StudentGrades grades = new();

            Grades grade = grades.ConvertMarktoGrade(100);

            Assert.AreEqual(Grades.A, grade);
        }

        [TestMethod]
        public void TestMean()
        {
            StudentGrades grades = new();

            grades.Marks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            grades.CalculateMean();

            Assert.AreEqual(55, grades.Mean);
        }

        [TestMethod]
        public void TestMin()
        {
            StudentGrades grades = new();

            grades.Marks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            grades.CalculateMinMax();

            Assert.AreEqual(10, grades.Min);
        }

        [TestMethod]
        public void TestMax()
        {
            StudentGrades grades = new();

            grades.Marks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            grades.CalculateMinMax();

            Assert.AreEqual(100, grades.Max);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            StudentGrades grades = new();
            
            grades.Marks = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            grades.CalculateGradeProfile();

            bool expectedGradeProfile;
            expectedGradeProfile = ((grades.Gradeprofile[0] == 30) &&
                                     (grades.Gradeprofile[1] == 10) &&
                                     (grades.Gradeprofile[2] == 10) &&
                                     (grades.Gradeprofile[3] == 10) &&
                                     (grades.Gradeprofile[4] == 40));

            Assert.IsTrue(expectedGradeProfile);
        }
    }
}