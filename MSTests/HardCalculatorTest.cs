using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.TaskLibrary.Tasks.Lesson15.Task2;

namespace MSTests
{
    [TestClass]
    public class HardCalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 5, 7, 9 };
            int[] actual = HardCalculator.Add(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { -3, -3, -3 };
            int[] actual = HardCalculator.Sub(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 4, 10, 18 };
            int[] actual = HardCalculator.Mul(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            int[] a = { 4, 5, 6 };
            int[] b = { 1, 2, 3 };
            int[] expected = { 4, 2, 2 };
            int[] actual = HardCalculator.Div(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
