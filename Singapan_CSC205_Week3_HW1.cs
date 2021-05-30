using System;

namespace Singapan_CSC205_Week3_HW1
{
    class Buzz
    {
        public static void Baffle(string blimp)
        {
            Console.WriteLine(blimp);// #2 
            Zippo("ping", -5);
        }
        public static void Zippo(string quince, int flag)
        {
            if (flag < 0)
            {
                Console.WriteLine(quince + "zoop"); // #3
            }
            else
            {
                Console.WriteLine("ik"); // #1 the arguments passed in main method is 13<0==False so this gets executed first.
                Baffle(quince);
                Console.WriteLine("boo-wa-ha-ha"); // #4
            }
        }
        public static void Main(string[] args)
        {
            Zippo("rattle", 13);
        }
    }
}
//Write the number 1 next to the first statement of this program that will be executed. Be careful to distinguish things that are statements from things that are not.

//2. Write the number 2 next to the second statement, and so on until the end of the program. If a statement is executed more than once, it might end up with more than one number next to it.

//3. What is the value of the parameter blimp when Baffle gets invoked?
//Answer: rattle

//4. What is the output of this program?
//Answer:   ik
//          rattle
//          pingzoop
//          boo-wa-ha-ha