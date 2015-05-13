using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Radius of the Circle : ");
            double aRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of the Circle is :" );
            Console.WriteLine( GetArea(aRadius));
            Console.WriteLine("The Perimeter of the Circle is : ");
            Console.WriteLine(GetPerimeter(aRadius));
            Console.ReadKey();


        }

        static double GetArea(double aRadius)
        {
            return Math.PI * aRadius * aRadius ; 
        }
        static double GetPerimeter(double aRadius)
        {
            return 2 * Math.PI * aRadius;
        }
    }
}
