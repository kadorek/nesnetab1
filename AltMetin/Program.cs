using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltMetin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin gir:");
            string metin = Console.ReadLine().Trim();
            Console.WriteLine("Lütfen parça başlangıcını girin:");
            int basParca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen parça uzunluğu girin:");
            int uzunluk= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parça:{0}",ParcaMetin(metin,basParca,uzunluk));
            Console.ReadLine();


        }
        static string ParcaMetin(string anaMetin ,int baslangic,int adet)
        {
            string sonuc = "";
            int sayac = 0;
            if (baslangic>=anaMetin.Length)
            {
                Console.WriteLine("Lütfen doğru aralıkta değer giriniz.");
                return "";
            }
            for (int i = baslangic; i < anaMetin.Length; i++)
            {
                if (sayac<adet)
                {
                    sonuc += anaMetin[i];
                    sayac++;
                }
               
            }
            return sonuc;
        }
    }
}
