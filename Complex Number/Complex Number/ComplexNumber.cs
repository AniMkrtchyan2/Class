using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number
{
    public struct Complex
    {
        public int real;
        public int imaginary;
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex one, Complex two)
        {
            return new Complex(one.real + two.real, one.imaginary + two.imaginary);
        }
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
        public static Complex operator -(Complex one, Complex two)
        {
            return new Complex(one.real - two.real, one.imaginary - two.imaginary);
        }
        public static Complex operator *(Complex one, Complex two)
        {
            return (new Complex(one.real * two.real - one.imaginary * two.imaginary,
            one.real * two.imaginary + two.real * one.imaginary));
        }
        public static Complex operator/(Complex one, Complex two)
        {
            if ((one.real == 0) &&
            (two.imaginary == 0))
                throw new DivideByZeroException("Can't divide by zero Complex number");

            int newReal =
            (one.real * two.real + one.imaginary * two.imaginary) /
            (two.real * two.real + two.imaginary * two.imaginary);
            int newImaginary =
            (one.real * one.imaginary - one.real * two.imaginary) /
            (two.real * two.real + two.imaginary * two.imaginary);

            return (new Complex(newReal, newImaginary));
        }
        public static Complex Add(Complex one, Complex two)
        {
            return (one + two);
        }

        public static Complex Subtract(Complex one, Complex two)
        {
            return (one - two);
        }

        public static Complex Multiply(Complex one, Complex two)
        {
            return (one * two);
        }

        public static Complex Divide(Complex one, Complex two)
        {
            return (one / two);
        }
    }
}
