using System;

namespace Singapan_CSC205_Week6_HW2
{
    class Program
    {
        //4.Write a Main method that creates a new object with type Rational, sets its fields to some values, and writes the object.
        static void Main(string[] args)
        {
            var Rational1 = new Rational();

            Console.WriteLine($"For the first set of Rational1 object: ");
        // Testing different ways of invoking class methods
            Rational.WriteRational(Rational1);
            Rational.Negate(Rational1);
            Rational.Invert(Rational1.Numerator, Rational1.Denominator);
            Rational.ToDouble(Rational1.Numerator, Rational1.Denominator);
            Rational.greatestCommonDivisor(Rational1.Numerator, Rational1.Denominator);
            Rational.Reduce(Rational1.Numerator, Rational1.Denominator);

            
            var Rational2 = new Rational(2,3);
            Console.WriteLine($"For the second set of Rational2 object: ");
            // Testing different ways of invoking class methods
            Rational.WriteRational(Rational2);
            Rational.Negate(Rational2);
            Rational.Invert(Rational2.Numerator, Rational2.Denominator);
            Rational.ToDouble(Rational2.Numerator, Rational2.Denominator);
            Rational.greatestCommonDivisor(Rational2.Numerator, Rational2.Denominator);
            Rational.Reduce(Rational2.Numerator, Rational2.Denominator);

            
            // Used for the Rational.Add method
            var Rational3 = new Rational(3, 4);


            var Rational4 = new Rational();
            Rational4 = Rational.Add(Rational2, Rational3);
            Console.WriteLine($"For the third set of Rational3 object: ");
            Console.WriteLine(Rational.Add(Rational2, Rational3));






        }
    }
}
