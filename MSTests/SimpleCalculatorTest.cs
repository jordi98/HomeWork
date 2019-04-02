using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson15;
using TestProject.TaskLibrary.Tasks.Lesson15.Task1;

namespace MSTests
{
    [TestClass]
    public class SimpleCalculatorTest
    {
        private ICalculator<int> calculator;

        [TestInitialize]
        public void SetUp()
        {
            this.calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void AddTest()
        {
            int a = 5, b = 5, expected = 10;
            int actual = this.calculator.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            int a = 5, b = 5, expected = 0;
            int actual = this.calculator.Sub(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            int a = 5, b = 5, expected = 25;
            int actual = this.calculator.Mul(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            int a = 5, b = 5, expected = 1;
            int actual = this.calculator.Div(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
