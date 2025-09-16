using System;
using System.Numerics;
namespace BaiTapCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fraction a;
            Fraction b;

            Console.WriteLine("Enter two fractions to perform operations: ");
            Console.WriteLine("Enter the first fraction (numerator and denominator): ");
            while (true) 
            {
                int numeratorA;
                try
                {
                    Console.Write("Enter the numerator: ");
                    numeratorA = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Numerator must be a number. Please enter again.");
                    continue;
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Enter the denomiator: ");
                        int denominatorA = int.Parse(Console.ReadLine()!);
                        a = new Fraction(numeratorA, denominatorA);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Denominator must be a number. Please enter again.");
                    }
                }
                break;
                
            }

            Console.WriteLine("Enter the second fraction (numerator and denominator): ");
            while (true)
            {
                int numeratorB;
                try
                {
                    Console.Write("Enter the numerator: ");
                    numeratorB = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Numerator must be a number. Please enter again.");
                    continue;
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Enter the denomiator: ");
                        int denominatorB = int.Parse(Console.ReadLine()!);
                        b = new Fraction(numeratorB, denominatorB);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Denominator must be a number. Please enter again.");
                    }
                }
                break;

            }
            Console.WriteLine("Sum of two fractions: " + (a + b));
            Console.WriteLine("Difference of two fractions: " + (a - b));
            Console.WriteLine("Product of two fractions: " + (a * b));
            Console.WriteLine("Quotient of two fractions: " + (a / b));



        }


        
    }
}