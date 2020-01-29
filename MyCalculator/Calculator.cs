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
            return a + b;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            Accumulator /= b;
            return Accumulator;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        public double Power(double exp)
        {
            if (Accumulator == 0 && exp < 0)
                throw new Exception("You tried calculating 0 to the power of a negative value. This is the same as dividing by 0");

            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            if(x == 0 && exp < 0)
                throw new Exception("You tried calculating 0 to the power of a negative value. This is the same as dividing by 0");
            
            return Math.Pow(x, exp);
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
