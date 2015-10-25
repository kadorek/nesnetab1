using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Merhaba");
            Console.WriteLine("Lütfen notunuzu giriniz ( 5 lik sistem)");
            int not = Convert.ToInt32(Console.ReadLine());
            switch (not)
            {
                case 1:
                    Console.WriteLine("Kaldınız.");
                    break;
                case 2:
                    Console.WriteLine("Kaldınız.");
                    break;
                case 3:
                    Console.WriteLine("Geçtiniz.");
                    break;
                case 4:
                    Console.WriteLine("Geçtiniz.");
                    break;
                case 5:
                    Console.WriteLine("Geçtiniz.");
                    break;
                default:
                    Console.WriteLine("HATA! Böyle bir not olamaz !");
                    break;
            }
            Console.ReadLine();
        }
    }
}
