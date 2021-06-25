using System;
using System.IO;
using System.Text;
namespace Singapan_CSC205_Week6_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            reading();
          

            static void reading()
            {
                //Assigning the file name to the variable.
                var path = "Mockingjay.txt";
                var file = "NewLine" + path;

                

                //Activate methods from StreamReader and StreamWriter while referencing the file.
                using var sr = new StreamReader(path);
                using var sw = new StreamWriter(file);


                string line = "";
                int counter = 0;


                while (line != null)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(counter + ":" + line);
                    sw.WriteLine(counter + ":" + line);
                    counter++;
                }
            }

           

        }
    }
}

       

