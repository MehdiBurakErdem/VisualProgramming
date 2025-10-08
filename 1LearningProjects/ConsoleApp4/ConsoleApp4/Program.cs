using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();
            Console.WriteLine("Default deger : {0}", d);

            DateTime d2 = new DateTime(2003, 09, 11);
            Console.WriteLine("Dogum Tarihim : {0}", d2);

            DateTime dn = DateTime.Now;
            Console.WriteLine("Simdiki Zaman : {0}", dn);

            Console.WriteLine("Yasım : {0}", dn.Year - d2.Year);
        }
    }
}
