using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public enum OrderStatus
    {
        Pending = 1,     // Beklemede
        Processing = 2,  // İşleniyor
        Shipped = 3,     // Kargolandı
        Delivered = 4,   // Teslim Edildi
        Cancelled = 5    // İptal Edildi
    }

    internal class Program
    {
        public static void PrintOrderStatus(OrderStatus status)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Sipariş durumu (sayısal): {0}", (int)status);
            Console.WriteLine("Sipariş durumu (isim): {0}", status);

            switch (status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Sipariş henüz işlenmeye başlamadı.");
                    break;
                case OrderStatus.Processing:
                    Console.WriteLine("Sipariş hazırlanıyor.");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Sipariş kargoya verildi.");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Sipariş teslim edildi.");
                    break;
                case OrderStatus.Cancelled:
                    Console.WriteLine("Sipariş iptal edildi.");
                    break;
                default:
                    Console.WriteLine("Bilinmeyen sipariş durumu!");
                    break;
            }
            Console.WriteLine("------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bir sipariş durumu girin (1-5): ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (Enum.IsDefined(typeof(OrderStatus), userInput))
            {
                OrderStatus userStatus = (OrderStatus)userInput; //En öenmli satır bence
                PrintOrderStatus(userStatus);
            }
            else
            {
                Console.WriteLine("Geçersiz durum kodu!");
            }
        }
    }
}
