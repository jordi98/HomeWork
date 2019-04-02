using NUnit.Framework;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson15.Task1;

namespace Tests
{
    [TestFixture]
    public class SimpleCalculatorTest
    {
        private ICalculator<int> calculator;

        [SetUp]
        public void SetUp()
        {
            this.calculator = new SimpleCalculator();
        }

        [Test]
        public void AddTest()
        {
            int a = 5, b = 5, expected = 10;
            int actual = this.calculator.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubTest()
        {
            int a = 5, b = 5, expected = 0;
            int actual = this.calculator.Sub(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MulTest()
        {
            int a = 5, b = 5, expected = 25;
            int actual = this.calculator.Mul(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivTest()
        {
            int a = 5, b = 5, expected = 1;
            int actual = this.calculator.Div(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}