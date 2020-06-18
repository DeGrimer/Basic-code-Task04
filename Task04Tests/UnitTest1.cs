using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test04
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMaxElementFinding()
        {
            var a = new int[] { 1, 1, 1, 1, 1, 1, 1 };
            var result = Task04.Program.MaxFinder(a, 0, a[0]);
            Assert.AreEqual(1, result);
            a = new int[] { 0, -1, 11, 21, 1, 2, 8, 65, 34, 21, 765, -12, 566, 7878, -199, 0, 34, 65, 87, 12, 34 };
            result = Task04.Program.MaxFinder(a, 0, a[0]);
            Assert.AreEqual(7878, result);
        }
        [TestMethod]
        public void CheckFindingElementIndexBetweenEqualSums()
        {
            var result = Task04.Program.IndexFinder(new double[] { });
            Assert.AreEqual(-1, result);
            result = Task04.Program.IndexFinder(new double[] { 49.2, 35.36, 38.94, 45.37, 44.16, 35.41, 21.61, 27.89, 28.58, 34.82, 28.17, 9.27, 5.41, 37.19, 30.55, 29.23, 37.3, 15.71, 21.33, 13.25, 18.05, 13.61, 30.12, 23.14, 10.89, 26.24, 10.04, 15.75, 38.75, 4.01, 15.17, 23.89, 5.22, 43.34, 37.06, 3.04, 47.04, 40.42, 31, 15.31, 10.22, 40.34, 36.42, 4.05, 28.47, 29.61, 16.67, 5.99, 28.92, 43.35, 7.33, 46.36, 14.77, 4.66, 3.26, 25.13, 32.78, 6.94, 22.42, 18.88, 4.15, 38.17, 21.95, 33.69, 8.03, 16.45, 19.66, 19.92, 22, 45.47, 8.33, 43.63, 40.46, 32.27, 43.01, 37.07, 39.08, 42.76, 32.63, 35.82, 38.75, 17.93, 7.82, 29.3, 33.04, 33.17, 37.29, 26.2, 43.23, 31.5, 11.73, 42.44, 6.11, 2.81, 1.43, 21.72, 38.86, 16.75, 26.05, 36.74, 18.63, 20, 8.48, 45.89, 38.02, 33.4, 0.01 });
            Assert.AreEqual(54, result);
        }
        [TestMethod]
        public void CheckStringConcatenation()
        {
            var result = Task04.Program.StringConcatenation("AsdfeAd", "Assqaasssqs");
            Assert.AreEqual("AsdfeAdqaaq", result);
            result = Task04.Program.StringConcatenation("BasDerT", "fYmDaQ");
            Assert.AreEqual("BasDerTfYmQ", result);
        }
        [TestMethod]
        public void CheckNextBiggerDigit()
        {
            var result = Task04.Program.FindNextBiggerNumber(1234321);
            Assert.AreEqual(1241233, result);
            result = Task04.Program.FindNextBiggerNumber(1234126);
            Assert.AreEqual(1234162, result);
        }
        [TestMethod]
        public void CheckFilterDigit()
        {
            var result = Task04.Program.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7);
            var expect = new int[] { 7, 7, 70, 17 };
            CollectionAssert.AreEqual(expect, result);
            result = Task04.Program.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 6);
            expect = new int[] { 6, 68, -69 };
            CollectionAssert.AreEqual(expect, result);
        }
    }
}