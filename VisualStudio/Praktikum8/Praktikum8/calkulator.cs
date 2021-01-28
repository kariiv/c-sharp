using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Praktikum8
{
    class Calculator
    {
        public int Substract(int a, int b)
        {
            return a - b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public int Multiply3(int a, int b, int c)
        {
            return a * b * c;
        }
        public int Squere(int a)
        {
            return a*a;
        }
    }
}
