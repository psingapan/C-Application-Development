using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singapan_CS205_Week1Assignment
{
    class Singapan_CSC205_Week1_Problem2
    { 
        static void Results(string[] args)
        {
            // Homework Assignment #2
            // Convert three mathematical formula to C# expressions. 
            // a= 1.0, b=2.83, c=1.2, r= 1.0, theta= 0.523599
            double a = 1.0;
            double b = 2.83;
            double r = 1.0;
            double c = 1.2;
            double theta = 0.523599;
            double x1;
            double volume;
            double c1;
            

            x1 = -b + (Math.Sqrt(Math.Pow(b,2)))-(4*a*c)/(2*a);
            volume = (4/3) * Math.PI * r * (Math.Pow(r,3));
            c1 = (Math.Pow(Math.Sin(theta),2)) + (Math.Pow(Math.Sin(theta),2));
          

        
        }

    }
}
