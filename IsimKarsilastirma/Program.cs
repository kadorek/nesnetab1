using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsimKarsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir isim gir:");
            string isim = Console.ReadLine();
            switch (isim)
            {
                case "ali":
                case "veli":
                    Console.WriteLine("Doğru");
                    break;
                case "ayşe":
                case "fatma":
                    Console.WriteLine("Yanlış");
                    break;
                default:

                    Console.WriteLine("Hatalı giriş.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
