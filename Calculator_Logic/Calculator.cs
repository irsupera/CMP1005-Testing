using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        public double Add(double left, double right)
        {
            //set the sum of left and right parameters
            return left + right;
        }

        public double Subtract(double left, double right)
        {
            //set the difference of left and right parameters
            return left - right;
        }

        public double Multiply(double left, double right)
        {
            //set the product of left and right parameters
            return Math.Round(left * right, 2);
        }

        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                //set the qoutient of left and right parameters
                return Math.Round(left / right, 2);
            }
            else
            {   //pass exeption number divide by 0
                throw new DivideByZeroException();
            }

        }
    }
}
