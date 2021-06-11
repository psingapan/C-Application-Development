using System;

namespace Singapan_CSC205_Week5_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            encap("((3 + 7) * 2)");
        }
        public static int encap (string s) //1. Encapsulating the code fragment
        {
            int len = s.Length;
            int i = 0;
            int count = 0;
            while (i < len)
            {
                char c = s[i];
                if (c == '(')
                {
                    count = count + 1;
                  
                }
                else if (c == ')')
                {
                    count = count - 1;
                 
                }
                i = i + 1;

            }
            Console.WriteLine(count);
            return count;

        }
    }
}

//2. The resulting method will yield the final count as 0. This is because the if, elseif statements cancel each other out based on the argument passed.
//3. To generalize it more, instead of passing in the argument directly (or hard-coded) in the main method, you would take user input. So you would need
//to utilize a Console.WriteLine to prompt the user with a question and Console.ReadLine and assign it to a variable.