using System;

namespace Singapan_CSC205_Week2_Program3
{
    class fourdigit
    {
        static void Main(string[] args)
        {
            //Problem 3
            int fourDigitNum = 1234;
            int a = (fourDigitNum / 1000) % 10;
            int b = (fourDigitNum / 100) % 10;
            int c = (fourDigitNum / 10) % 10;
            int d = (fourDigitNum / 10);

            Console.WriteLine($"The original number is {fourDigitNum}");
            Console.WriteLine($"The sum of the digits is {a+b+c+d}");
            Console.WriteLine($"The reversed order of the digits is {d}{c}{b}{a}");
            Console.WriteLine($"The last digit placed in the first position looks like {d}{a}{b}{c}");
            Console.WriteLine($"When the second and third digits are exchanged, it looks like {a}{c}{b}{d}");
        }
    }
}