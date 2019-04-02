using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson15.Task2;

namespace MSTests
{
    [TestClass]
    public class HardCalculatorTest
    {
        private ICalculator<int[]> calculator;

        [TestInitialize]
        public void SetUp()
        {
            this.calculator = new HardCalculator();
        }

        [TestMethod]
        public void AddTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 5, 7, 9 };
            int[] actual = this.calculator.Add(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { -3, -3, -3 };
            int[] actual = this.calculator.Sub(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 4, 10, 18 };
            int[] actual = this.calculator.Mul(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            int[] a = { 4, 5, 6 };
            int[] b = { 1, 2, 3 };
            int[] expected = { 4, 2, 2 };
            int[] actual = this.calculator.Div(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
