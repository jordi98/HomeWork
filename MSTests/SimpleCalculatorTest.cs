using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.TaskLibrary.Tasks.Lesson15.Task1;

namespace MSTests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            int a = 5, b = 5, expected = 10;
            int actual = SimpleCalculator.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            int a = 5, b = 5, expected = 0;
            int actual = SimpleCalculator.Sub(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            int a = 5, b = 5, expected = 25;
            int actual = SimpleCalculator.Mul(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            int a = 5, b = 5, expected = 1;
            int actual = SimpleCalculator.Div(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
