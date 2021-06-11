using System;

namespace Singapan_CSC205_Week4_HW2
{
    class Singapan_CSC205_Week4_HW2_Recurse
    {
        static void Main(string[] args) //2. Write some code in Main that tests each of these methods.
        {
            Console.WriteLine(First("Simply Sam"));
            Console.WriteLine(Rest("Simply Sam"));
            Console.WriteLine(Length("Simply Sam"));
            ReverseString("Simply Sam");

        }
        public static char First(string s)
        {
            return s[0];
        }
        public static string Rest(string s) // rest: returns a new string that contains all but the first letter of the given string
        {
            return s.Substring(1);
        }

        public static int Length(string s) // length: returns the length of the given string
        {
            return s.Length;
        }
        public static void WriteString(string s) //3. Write a method called WriteString that takes a string as a parameter and that prints the letters of the string, one on each line. It should be a void method.
        {

            int i = 0;
            while (i <= s.Length)
            {
                char letter = s[i];
                Console.WriteLine(letter);
                i++;
            }
        }
        public static void WriteBackward(string s) //4. Write a method called WriteBackward that does the same thing as WriteString but that prints the string backward(one character per line).
        {
            int i = s.Length - 1;
            while (i >= -1)
            {
                char letter = s[i];
                Console.WriteLine(letter);
                i--;
            }
        }
        public static string ReverseString(string s) //5. Write a method called ReverseString that takes a string as a parameter and returns a new string as a return value. The new strin should contain the same letters as the parameter, but in reverse order.
        {
            int i = s.Length - 1;
            while (i >=-1)
            {
                char letter = s[i];
                Console.Write(letter);
                i--;
            }
            return s;
        }
    }
}
    

