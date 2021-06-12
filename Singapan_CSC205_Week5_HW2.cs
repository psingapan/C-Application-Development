using System;

namespace Singapan_CSC205_Week5_HW2
{
    class Test
    {
        static void Main(string[] args)
        {
            string myString = "hello";
            bool aTrue = true;
            char myChar = 'a';
            int num = 15;
            var myStringAndChar = myString + myChar;


            Console.WriteLine($"Using the + sign for a string and character will get me: {myStringAndChar}");
            Console.WriteLine(myStringAndChar.GetType());


        }
    }
}

//HW Problem 2: Exercise 7.5. 
//Create a new program named Test.cs and write a Main method that contains expressions that combine various types using the + operator.
//For example, what happens when you \add" a string and a char? Does it perform addition or concatenation?
//What is the type of the result? (How can you determine the type of the result?)

//When you add the string and character together with the (+) operator, it concatenates the string and character together. To determine the type of result