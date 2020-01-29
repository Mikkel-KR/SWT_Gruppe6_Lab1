using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is the calculator BJØLLEFISK
namespace MyCalculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public double Add(double a) //overloading bitches (udskrift med acumulator dims)
        {
            Accumulator += a;

            return Accumulator;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            Accumulator = a / b;
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }
    }
}
