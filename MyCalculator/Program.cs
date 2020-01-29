using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator uut = new Calculator();

            Console.WriteLine("Test Program: Calculator");

            //TEST-1.1: Add() - Positive
            Console.WriteLine("Test-1.1: Add(2, 2) -> expects: 4");
            Console.WriteLine("Result: " + uut.Add(2, 2));

            //TEST-1.2: Add() - Negative
            Console.WriteLine("Test-1.2: Add(-2, -2) -> expects: -4");
            Console.WriteLine("Result: " + uut.Add(-2, -2));

            //TEST-2.1: Subtract() - Positive
            Console.WriteLine("Test-2.1: Subtract(5, 2) -> expects: 3");
            Console.WriteLine("Result: " + uut.Subtract(5, 2));

            //TEST-2.2: Subtract() - Negative
            Console.WriteLine("Test-2.2: Subtract(2, 5) -> expects: -3");
            Console.WriteLine("Result: " + uut.Subtract(2, 5));

            //TEST-3.1: Multiply() - Positive * Positive
            Console.WriteLine("Test-3.1: Multiply(3, 3) -> expects: 9");
            Console.WriteLine("Result: " + uut.Multiply(3, 3));

            //TEST-3.2: Multiply() - Positive * Negative
            Console.WriteLine("Test-3.2: Multiply(3, -3) -> expects: -9");
            Console.WriteLine("Result: " + uut.Multiply(3, -3));

            //TEST-3.3: Multiply() - Negative * Negative
            Console.WriteLine("Test-3.3: Multiply(-3, -3) -> expects: 9");
            Console.WriteLine("Result: " + uut.Multiply(-3, -3));

            //TEST-4.1: Power() - x^0
            Console.WriteLine("Test-4.1: Power(10, 0) -> expects: 1");
            Console.WriteLine("Result: " + uut.Power(10, 0));

            //TEST-4.2: Power() - x^1
            Console.WriteLine("Test-4.1: Power(10, 1) -> expects: 10");
            Console.WriteLine("Result: " + uut.Power(10, 1));

            //TEST-4.3: Power() - x^-1
            Console.WriteLine("Test-4.1: Power(10, -1) -> expects: 0.1");
            Console.WriteLine("Result: " + uut.Power(10, -1));

        }
    }
}
