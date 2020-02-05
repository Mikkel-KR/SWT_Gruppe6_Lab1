using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void SetupTest()
        {
            //Arrange
            uut = new Calculator();
        }

        [TestCase(2,2,4)]
        [TestCase(-2,-2,-4)]
        [TestCase(-2,2,0)]
        [TestCase(1.25,1.35,2.6)]
        public void AddTest_Success(double a, double b, double expectedResult)
        {
            // Arrange
            // - uses SetupTest()

            // Act
            double result = uut.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(10,5,5)]
        [TestCase(5, 5, 0)]
        [TestCase(-10, 5, -15)]
        [TestCase(10, -5, 15)]
        [TestCase(-10, -5, -5)]
        [TestCase(1.8, 1.2, 0.6)]
        public void Subtract_Success(double a, double b, double expectedResult)
        {
            double result = uut.Subtract(a, b);

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.005));
        }

        [TestCase(100,0,0)]
        [TestCase(0, -100, 0)]
        [TestCase(2, 10, 20)]
        [TestCase(2, -10, -20)]
        [TestCase(-10, -10, 100)]
        [TestCase(1.5, 2, 3)]
        public void Multiply_Success(double a, double b, double expectedResult)
        {
            double result = uut.Multiply(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(0, 2, 0)]
        [TestCase(10, 5, 2)]
        [TestCase(5, 10, 0.5)]
        [TestCase(-10, -5, 2)]
        [TestCase(-10, 5, -2)]
        public void Divide_Success(double a, double b, double expectedResult)
        {
            double result = uut.Divide(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_DivideByZero_ExceptionThrown()
        { 
            Assert.That(() => uut.Divide(10,0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(0,10,0)]
        [TestCase(0, 0, 1)]
        [TestCase(10, -1, 0.1)]
        [TestCase(10, 0, 1)]
        [TestCase(10, 1, 10)]
        [TestCase(10, 2, 100)]
        [TestCase(10, 3, 1000)]
        public void PowerTest_Success(double a, double b, double expectedResult)
        {
            double result = uut.Power(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Power_0ToThePowerOfNegativeValue_ExceptionThrown()
        {
            Assert.That(() => uut.Power(0, -1), Throws.Exception.With.Message);
        }

        [TestCase(10,5,4,2,3,1000)]
        [TestCase(10, 10, 10, 10, 10, 0)]
        public void Accumulator_DifferentCombinations_ReturnsAccumulatedCorrectResult(double add, double subt, double mult, 
            double div, double pow, double expectedResult)
        {
            //Arrange
            uut.Clear();

            //Act
            uut.Add(add);
            uut.Subtract(subt);
            uut.Multiply(mult);
            uut.Divide(div);
            uut.Power(pow);

            double result = uut.Accumulator;

            //Assert
            Assert.That(result,Is.EqualTo(expectedResult));
        }

        [Test]
        public void Accumulator_Divide_DividingByZero_ExceptionsThrown()
        {
            //Arrange
            uut.Clear();
            uut.Add(20); //Accumulator holds 20

            //Assert
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Accumulator_Power_0ToThePowerOfNegativeValue_ExceptionsThrown()
        {
            //Arrange
            uut.Clear(); // value == 0

            //Assert
            Assert.That(() => uut.Power(-1), Throws.Exception.With.Message);
        }

    }
}
