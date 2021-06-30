using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singapan_CSC205_Week6_HW2
{
    //1. Create a new program called Rational.cs that defines a class named Rational. A Rational object should have two integer fields to store the numerator and denominator.
    class Rational
    {
        public int Numerator;
        public int Denominator;

        //2.Write a default constructor, one that takes no arguments, and that sets the numerator to 0 and denominator to 1.
        public Rational()
        {
            this.Numerator = 0;
            this.Denominator = 1;
        }

        //5. Write a parametric constructor for your class that takes two arguments and that uses them to initialize the fields.
        public Rational(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        //3.Write a method called WriteRational that takes a Rational object as an argument and outputs it in some reasonable format.
        public static void WriteRational(Rational r)
        {
            if (r.Denominator == 0 || r.Numerator==0)
            {
                Console.WriteLine("This division cannot be conducted because the either the numerator or denominator is 0.");
                

            }else
            {
                Console.WriteLine("The result of WriteRational method is: " + r.Numerator / r.Denominator);
            }
            

        }
        //7. Write a method called Negate that reverses the sign of a rational number.This method should be a modifier, so it should return void. Add lines to Main to test the new method.
        public static void Negate(Rational r)
        {
            r.Numerator = r.Numerator * -1;
            if (r.Denominator <= 0)
            {
                r.Numerator = r.Numerator * -1;
                r.Denominator = r.Denominator * -1;
            }
        }

        //8. . Write a method called Invert that inverts the number by swapping the numerator and denominator. Add lines to Main to test the new method.
        public static void Invert(int numerator, int denominator)
        {
            int myNumerator = denominator;
            int myDenominator = numerator;
            Console.WriteLine($"The inversion of the numbers received are {myNumerator} and {myDenominator}");

        }
        //9.Write a method called ToDouble that converts the rational number to a double(floating-point number) and returns the result. This method is a pure function; it does not modify the object. As always, test the new method.
        public static void ToDouble(int numerator, int denominator)

        {
            if (denominator == 0 || numerator == 0)
            {
                Console.WriteLine("This division cannot be conducted because the either the numerator or denominator is 0.");
             
            }
            else
            {
                double myResult = numerator / denominator;


                double floatingNum = Convert.ToDouble(myResult);
                Console.WriteLine($"The double floating point result of {numerator}/{denominator} is: {floatingNum}");
                
            }
        }
        public static int greatestCommonDivisor(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                return numerator;
            }
            else
            {
                return greatestCommonDivisor(denominator, numerator % denominator);
            }


        }
        //10. Write a modifier named reduce that reduces a rational number to its lowest term.
        public static void Reduce(int numerator, int denominator)
        {
            if (denominator == 0 || numerator == 0)
            {
                Console.WriteLine("This division cannot be conducted because the either the numerator or denominator is 0.");
            }
            else
            {
                numerator = numerator / greatestCommonDivisor(numerator, denominator);
                denominator = denominator / greatestCommonDivisor(numerator, denominator);
            }
        }
        //10.Write a method called Add that takes two Rational numbers as arguments and returns a new Rational object. The return object should contain the sum of the arguments. There are several ways to add fractions. You can use any one you want, but you should make sure that the result of the operation
        //is reduced so that the numerator and denominator have no common divisor (other than 1).
        public static Rational Add(Rational Rational2, Rational Rational3)
        {
            var Rational4 = new Rational(0, 0);


            if (Rational2.Denominator == Rational3.Denominator)
            {
                Rational4.Numerator = Rational2.Numerator + Rational3.Numerator;
                Rational4.Denominator = Rational3.Denominator;
                return Rational4;
            }
            else
            {
                Rational4.Numerator = Rational2.Numerator * Rational3.Denominator;
                Rational4.Denominator = Rational2.Denominator * Rational3.Denominator;

                Rational3.Numerator = Rational3.Numerator * Rational2.Denominator;
                Rational3.Denominator = Rational3.Denominator * Rational2.Denominator;

                Rational4.Numerator += Rational3.Numerator;

                int remain, num1, num2;
                num1 = Rational4.Numerator;
                num2 = Rational4.Denominator;
                remain = num1 % num2;
                while (remain != 0)
                {
                    remain = num1 % num2;
                    num1 = num2;
                    num2 = remain;
                }
                int GCD = num1;

                Rational4.Numerator = Rational4.Numerator / GCD;
                Rational4.Denominator = Rational4.Denominator / GCD;

                return Rational4;
                
            }
        }
    }
}



