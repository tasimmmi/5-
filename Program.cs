using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {   // Задание 1
                //double z = 5.777; double t = 6;
                //double a = 1.957; double x = 8.33;
                //double b = 9;

                //double result1 = (a * x - Math.Exp(-b / x)) / (z * Math.Sqrt(Math.Abs(Math.Sin(z / t + t))));
                //Console.Write($" y= {result1}");

                //Задание 2
                double x = Convert.ToDouble(Console.ReadLine());
                double g = 5.0 / 3.0 - Math.Atan(Math.Sqrt(2 - Math.Cos(2 * x))) - Math.Exp(-x / 5.0);
                Console.WriteLine($" y= {g}");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double g2 = 5.0 / 3.0 - Math.Atan(Math.Sqrt(2 - Math.Cos(2 * x2))) - Math.Exp(-x2 / 5.0);
                Console.WriteLine($" y= {g2}");
            }
            
        }
    }
}
