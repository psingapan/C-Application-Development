using System;

namespace Singapan_CSC205_Week4_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0.0;
            while (count < 1.0) //Question 2. Alteration of the not operator to < 
            {
                count = count + 0.1;
                Console.Write("{0:R}", count);
                Console.ReadLine();
            }
        }
    }
}

//Question 1. The program continues to run when it reaches 1 because as a double, when it hits 0.999 it adds another 0.1 which results to 1.09999 and then proceeds to 1.2 then 1.3