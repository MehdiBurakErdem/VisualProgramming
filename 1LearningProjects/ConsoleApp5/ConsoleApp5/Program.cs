using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[] temp1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] temp = {1, 2, 3, 4, 5, 6 }; //ancak önce sadece temp değişkenini oluştuurp sonra obje oluşturmak istersek sağ tarafı böyle yapamıyoruz new ... kullanmamız gerekiyor

            for (int i = 0; i < arry.GetLength(0); i++)
            {
                for (int j = 0; j < arry.GetLength(1); j++)
                {
                    Console.Write(arry[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
