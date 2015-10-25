using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiGirdirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("Lütfen toplanacak ilk sayıyı giriniz ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen toplanacak ikinci sayıyı giriniz ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen toplanacak ilk sayıyı giriniz ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi1 + sayi2 + sayi3;



            //  int toplam = sayi1 + sayi2;
            Console.WriteLine("Girilen sayıların toplam: {0}", sonuc);

            // Console.WriteLine("Lütfen toplanacak ilk sayıyı giriniz ")





            Console.ReadLine();
        }
    }
}
