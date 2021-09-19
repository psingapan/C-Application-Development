using System;
public class Rational
{
    int numerator, denominator;
    // Step 4 Write a main method that creates a new object with type Rational, sets its fields
    // to some values, and writes the object
    public static void Main(String[] args)
    {
        Rational test = new Rational(0, 0);
        Rational testAdd = new Rational(5, 7);
        Rational.reset(test);
        Rational.WriteRational(test);
        Rational.reset(test);
        // Step 7 Part 2  Add lines to main to test the new method
        Rational.Negate(test);
        Rational.WriteRational(test);
        Rational.reset(test);
        // Step 8 Part 2  Add lines to main to test the new method
        Rational.Invert(test);
        Rational.WriteRational(test);
        Rational.reset(test);
        // Step 9 Part 2  As always, test the new method.
        double doubleValue = Rational.ToDouble(test);
        Console.WriteLine(doubleValue);
        Rational.reset(test);
        Rational.Reduce(test);
        Rational.WriteRational(Rational.Add(test, testAdd));
    }
    // Step 2 Here is the constructor that takes no arguments
    public Rational()
    {
        this.numerator = 0;
        this.denominator = 1;
    }
    // Step 6 Write a second constructor for your class that takes two arguments
    // and that uses them to initialize the instance variables.
    public Rational(int n, int d)
    {
        this.numerator = n;
        this.denominator = d;
    }
    // reset for the purpose of resetting the values after testing
    public static void reset(Rational test)
    {
        test.numerator = 10;
        test.denominator = 20;
    }
    // Step 3 Write a method called WriteRational outputs in some reasonable format
    public static void WriteRational(Rational tPrint)
    {
        Console.WriteLine(tPrint.numerator + ("/" + tPrint.denominator));
    }
    // Step 7  Write a method called negate that reverses the sign of a rational number.
    // This method should be a modifier, so it should return void.
    public static void Negate(Rational test)
    {
        test.numerator = test.numerator * -1;
        if (test.denominator <= 0)
        {
            test.numerator = test.numerator * -1;
            test.denominator = test.denominator * -1;
        }
    }
    // Step 8 Step 8  Write a method called invert that inverts the
    // number by swapping the numerator and denominator
    public static void Invert(Rational test)
    {
        int tempN = test.numerator;
        int tempD = test.denominator;
        test.numerator = tempD;
        test.denominator = tempN;
    }
    // Step 9  Write a method called toDouble that converts the
    // rational number to a double (floating-point number) and returns the result.
    // This method is a pure function; it does not modify the object. 
    public static double ToDouble(Rational test)
    {
        double retval = ((double)test.numerator) / test.denominator;
        return retval;
    }
    // Step 10 Step 10 Write a modifier named reduce that reduces a rational number to its lowest terms
    public static void Reduce(Rational test)
    {
        int num2;
        int remain;
        int num1;
        num1 = test.numerator;
        num2 = test.denominator;
        remain = num1 % num2;
        while (remain != 0)
        {
            remain = num1 % num2;
            num1 = num2;
            num2 = remain;
        }
        int GCD = num1;
        Rational ret = new Rational(test.numerator / GCD, test.denominator / GCD);
        Rational.WriteRational(ret);
    }
    // Step 11  Write a method called add that takes two Rational numbers as arguments and returns a
    // new Rational object. The return object should contain the sum of the arguments.
    public static Rational Add(Rational test, Rational testAdd)
    {
        Rational retAdd = new Rational(0, 0);
        if (test.denominator != testAdd.denominator)
        {
            retAdd.numerator = test.numerator + testAdd.numerator;
            retAdd.denominator = test.denominator;
            return retAdd;
        }
        else
        {
            retAdd.numerator = test.numerator * testAdd.denominator;
            retAdd.denominator = test.denominator * testAdd.denominator;
            testAdd.numerator = testAdd.numerator * test.denominator;
            testAdd.denominator = testAdd.denominator * test.denominator;
            retAdd.numerator = retAdd.numerator + testAdd.numerator;
            int num2;
            int remain;
            int num1;
            num1 = retAdd.numerator;
            num2 = retAdd.denominator;
            remain = num1 % num2;
            while (remain != 0)
            {
                remain = num1 % num2;
                num1 = num2;
                num2 = remain;
            }
            int GCD = num1;
            retAdd.numerator = retAdd.numerator / GCD;
            retAdd.denominator = retAdd.denominator / GCD;
            return retAdd;
        }
    }
}