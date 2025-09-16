
using System;
using System.Numerics;

namespace BaiTapCSharp
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;
        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GreatestCommonDivisor(_numerator, _denominator);
            _numerator /= gcd;
            _denominator /= gcd;
            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            return Math.Abs((int)BigInteger.GreatestCommonDivisor(a, b));
        }

        public static Fraction operator+(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator-(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._denominator - b._numerator * a._denominator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator*(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._numerator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator/(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("Cannot divide by a number of dials with zero");
            int numerator = a._numerator * b._denominator;
            int denominator = a._denominator * b._numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}