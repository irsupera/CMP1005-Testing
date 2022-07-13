using System;
using Calculator_logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void CalcClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        //Addition

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

        //Subtraction

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
        public void CalcSubtractAddTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
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

        //Multiplication

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
        public void CalcMultiplyAddTwoOpositeSignsIntegerNumbersWithNegativeRight(double expected, double left, double right)
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

        //Division

        [TestMethod]
        [DataRow(9, 0)]
        public void CalcThrowExceptionWhenDivideByZero(double left, double right)
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(left, right); });
        }
    }
}
