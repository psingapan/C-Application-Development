using System;

namespace Understanding_Classes
{
    class Wizard
    {
        //These are members/fields that you establish for the class. It declares the variable types that will be used when instantiating the Wizard Class. These variables are used
        //to describe the wizard class
        public string name;
        public string favoriteSpell;
        public int spellSlots;
        public float experience;

        // Method within the Wizard class
        public void castSpell()
        {
           if( spellSlots>0)
           {
            Console.WriteLine(name+ "casts"+ favoriteSpell);
            spellSlots--;
           }else
           {
               Console.WriteLine("Get rekt"+ name+", you're out of spell slots!");
           }
        }

    }
    class Program

    {
        static void Main(string[]args)
       {
           //Instantiate the wizard class here.
           Wizard wizard01= new wizard();
           
           //Assigning variables to the wizard01 object that had just been instantiated.
           wizard01.favoriteSpell= "Unexpecto Patronum";
           wizard01.spellSlots= 2;
           wizard01.experience= 0;
           wizard01.name= "Garry Shopper";

           //Invoking the method specific to the wizard01 class
           wizard01.castSpell();


       } 
    }
}