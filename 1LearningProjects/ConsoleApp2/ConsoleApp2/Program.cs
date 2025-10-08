using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public void getAvarage(ref int[] x, int size, ref double avg)
        {
            int i;
            int sum = 0;

            for (i = 0; i < size; i++){
                sum += x[i];
            }
            avg = sum / size;
            
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Program p = new Program();
            double sonuc = 0;

            p.getAvarage(ref a ,5 ,ref sonuc);
            Console.WriteLine("Average is : " + sonuc);

        }
    }
}
