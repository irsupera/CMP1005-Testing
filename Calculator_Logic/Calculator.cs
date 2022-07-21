using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        public double Add(double left, double right)
        {
            return left + right;
        }

        public double Subtract(double left, double right)
        {
            return left - right;
        }

        public double Multiply(double left, double right)
        {
            return Math.Round(left * right, 2);
        }

        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                return Math.Round(left / right, 2);
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
    }
}
