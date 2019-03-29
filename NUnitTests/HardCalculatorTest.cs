using NUnit.Framework;
using TestProject.TaskLibrary.Tasks.Lesson15.Task2;

namespace Tests
{
    [TestFixture]
    public class HardCalculatorTest
    {
        [Test]
        public void AddTest()
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 5, 7, 9, 4 };
            int[] actual = HardCalculator.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6, 5 };
            int[] expected = { -3, -3, -3, 5 };
            int[] actual = HardCalculator.Sub(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MulTest()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] expected = { 4, 10, 18 };
            int[] actual = HardCalculator.Mul(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivTest()
        {
            int[] a = { 4, 5, 6 };
            int[] b = { 1, 2, 3 };
            int[] expected = { 4, 2, 2 };
            int[] actual = HardCalculator.Div(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}