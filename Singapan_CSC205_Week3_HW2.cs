using System;

namespace Singapan_CSC205_Week3_HW2
{
    class Singapan_CSC205_Week3_HW2
    {
        static void Main(string[] args)
        {
            CheckFermat(3,2,4,2);
        }
        public static void CheckFermat(int a, int b, int c, int n)
        {
            int x = (int)(Math.Pow(a, n) + Math.Pow(b, n));
            
            if (x== Math.Pow(c, n) && (n > 2))
            {
                Console.WriteLine("Holy smokes, Fermat was wrong!");
            }

            else
            {
                Console.WriteLine("No, that doesn't work.");
            }
          
        }
    }
}
