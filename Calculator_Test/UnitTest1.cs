using System;
using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        //Calculator object
        Calculator calc = new Calculator();

        //Calculator initialization test method
        [TestMethod]
        public void CalcClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        //Addition test methods

        [TestMethod]
        [DataRow(3, 2, 1)]
        public void CalcCanAddTwoPositiveIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-3, -2, -1)]
        public void CalcCanAddTwoNegativeIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-1, -2, 1)]
        public void CalcCanAddTwoOpositeSignsIntegerNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(1, 2, -1)]
        public void CalcCanAddTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(3.2, 2.1, 1.1)]
        public void CalcCanAddTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-3.2, -2.1, -1.1)]
        public void CalcCanAddTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(-1, -2.1, 1.1)]
        public void CalcCanAddTwoOpositeSignsDecimalNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(1, 2.1, -1.1)]
        public void CalcCanAddTwoOpositeSignsDecimalNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(3.1, 1, 2.1)]
        public void CalcCanAddOneIntegerNumberAndOneDecimalNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        [DataRow(0, -Math.PI, Math.PI)]
        public void CalcCanAddTwoOpositeSignsIrrationalNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        //Subtraction test methods

        [TestMethod]
        [DataRow(1, 2, 1)]
        public void CalcCanSubtractTwoPositiveIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1, -2, -1)]
        public void CalcCanSubtractTwoNegativeIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-3, -2, 1)]
        public void CalcCanSubtractTwoOpositeSignsIntegerNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(3, 2, -1)]
        public void CalcCanSubtractTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1, 2.1, 1.1)]
        public void CalcCanSubtractTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1, -2.1, -1.1)]
        public void CalcCanSubtractTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-3.2, -2.1, 1.1)]
        public void CalcCanSubtractTwoOpositeSignsDecimalNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(3.2, 2.1, -1.1)]
        public void CalcCanSubtractTwoOpositeSignsDecimalNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1.1, 1, 2.1)]
        public void CalcCanSubtractOneIntegerNumberAndOneDecimalNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-Math.PI, 0, Math.PI)]
        public void CalcCanSubtractZeroAndIrrationalNumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        //Multiplication test methods

        [TestMethod]
        [DataRow(2, 2, 1)]
        public void CalcCanMultiplyTwoPositiveIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(2, -2, -1)]
        public void CalcCanMultiplyTwoNegativeIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-2, -2, 1)]
        public void CalcCanMultiplyTwoOpositeSignsIntegerNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-2, 2, -1)]
        public void CalcCanMultiplyAddTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(2.31, 2.1, 1.1)]
        public void CalcCanMultiplyTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(2.31, -2.1, -1.1)]
        public void CalcCanMultiplyTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-2.31, -2.1, 1.1)]
        public void CalcCanMultiplyTwoOpositeSignsDecimalNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-2.31, 2.1, -1.1)]
        public void CalcCanMultiplyTwoOpositeSignsDecimalNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(2.1, 2.1, 1)]
        public void CalcCanMultiplyANumberByOneResultsANumber(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(0, 2.1, 0)]
        public void CalcCanMultiplyANumberByZeroResultsZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        //Division test methods

        [TestMethod]
        [DataRow(2, 2, 1)]
        public void CalcCanDivideTwoPositiveIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(2, -2, -1)]
        public void CalcCanDivideTwoNegativeIntegerNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, -2, 1)]
        public void CalcCanDivideTwoOpositeSignsIntegerNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-2, 2, -1)]
        public void CalcCanDivideTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1.91, 2.1, 1.1)]
        public void CalcCanDivideTwoPositiveDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1.91, -2.1, -1.1)]
        public void CalcCanDivideTwoNegativeDecimalNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-1.91, -2.1, 1.1)]
        public void CalcCanDivideTwoOpositeSignsDecimalNumbersWithNegativeLeft(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-1.91, 2.1, -1.1)]
        public void CalcCanDivideTwoOpositeSignsDecimalNumbersWithNegativeRight(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(0, 0, 1)]
        public void CalcCanDivideZeroByANumberResultsZero(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(9, 0)]
        public void CalcThrowExceptionWhenDivideByZero(double left, double right)
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(left, right); });
        }
    }
}
