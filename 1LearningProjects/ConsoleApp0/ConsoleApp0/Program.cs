using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0
{
    internal class Program
    {
        class Bread
        {
            public int counter;
        }

        static class Butter
        {
            public static int counter;
        }
        static void Main(string[] args)
        {
            /*  Deneme1
            const double pi = 3.14159;

            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            */

            Bread a = new Bread();
            a.counter = 5;
            Console.WriteLine("Bread: " + a.counter);

            Butter.counter = 1;
            Console.WriteLine("Butter counter: " + Butter.counter);
        }
    }
}
