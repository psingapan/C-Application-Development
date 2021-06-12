using System;

namespace Singapan_CSC205_Week5_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user with input
            Console.WriteLine("Please enter a word and I will check if it is in alphabetical order: ");
           
            //assigning user input to the variable, alphabet
            string alphabet = Console.ReadLine();
            
           //Invoking the method with the argument passed in by user input and printing out the final result
            Console.WriteLine(IsAbecedarian(alphabet));
           

        }
        public static bool IsAbecedarian(string alphabet)
        {
            //Assigning the variables here or fields
            int index = 0;
            // Checks if there is an 'a' in the string. If there is an 'a', we will return the index position of that and assign it to firstChar.
            int firstChar = alphabet.IndexOf('a');
            
            //Conditional statement that while the index of 0 remains less than the total length of the user input string...
            while (index < alphabet.Length)
            {
                // another sub conditional statement that checks if the first index position where 'a' appears precedes 
                if (alphabet[index] < firstChar)
                {

                    return false;
                }
               //if it fails the if-conditional statement, we will reassign the firstChar (the original index position where 'a' appears) to the string index of the argument AND increment that index each time so it traverses through and iterates.
                else
                    firstChar = alphabet[index];
                    index++;
            }
            return true;
        }

    }   
}

