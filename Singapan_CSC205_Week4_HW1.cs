using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args) //Question 3. Rewrite prod method.
        {
            Console.WriteLine(Prod(1, 4));
        }
        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                return n * (Prod(m, n - 1));
            }
        }
    }
}

//Question 1. The output of this program is 24. The stack diagram has been attached as a separate file.
//Question 2. Explain in a few words what Prod does.
// Prod is a factorial and recursive program that invokes itself. It finds the product of positive descending integers starting from
// 4. 
