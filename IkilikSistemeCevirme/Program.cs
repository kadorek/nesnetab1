using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkilikSistemeCevirme
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int s1 = sayi;
            string sonuc = "", kalan = "";
            while (sayi>=2)
            {
                kalan = (sayi % 2).ToString();
                sayi = (sayi - (sayi % 2)) / 2;//sayi/2
                sonuc = kalan + sonuc;
                
            }
            sonuc = sayi.ToString() + sonuc;
            Console.WriteLine("{0} sayısının 2 lik sistemdeki karsılıgı {1}  dir.",s1,sonuc);
            Console.ReadLine();
        }
        
    }
}
