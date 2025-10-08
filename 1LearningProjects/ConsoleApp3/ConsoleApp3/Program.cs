using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        // ref'de ilkdeğer olmak zorunda, out ise ilk değer olmak  zounda değil
        public void getValue(out int x){
            int temp = 5;
            x = temp;
        }

        public void setValue(out int k, out int v){
            Console.WriteLine("Enter hte first value: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hte first value: ");
            v = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args){
            Program p = new Program();

            int a = 100;
            int x, y;

            Console.WriteLine("Before Mehthod call, value of a : {0}", a);

            p.getValue(out a);

            Console.WriteLine("Before Mehthod call, value of a : {0}", a);

            p.setValue(out x, out y);
            Console.WriteLine("x = {0}, y = {1}",x,y);
        }
    }
}
