using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();

            return a / b;
        }
        public double Power(double x, double exp) => Math.Pow(x, exp);
    }
}
