using System;

namespace Singapan_CSC205_Week3_HW3
{
    class Multadd
    {
        static void Main(string[] args)
        {
            double mA= multAdd(1.0,2.0,3.0);
            Console.WriteLine($"The multiadditionization of the numbers are: {mA}");

            double mA_sin = multAdd(Math.Cos(Math.PI / 4), 0.5, Math.Sin(Math.PI / 4));
            Console.WriteLine($"The sum of sin and cosine of the numbers are: {mA_sin}");

            double mA_log = multAdd(1.0, Math.Log(10), (Math.Log(10) +Math.Log(2)));
            Console.WriteLine($"The log of the numbers are: {mA_log}");
          
        }
        public static double multAdd(double a,double b, double c)
        {
            return (double)(a * b) + c;
                      
        }
        public static void yikes(double x) //Question 5
        {
            double a = x;
            double b = Math.Exp(-x);
            double c = Math.Sqrt(1.0 - b);
            multAdd(a, b, c);
            

        }
    }
}

