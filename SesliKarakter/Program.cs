using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cümleyi giriniz");
            string cumle = Console.ReadLine().Trim();
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                int durum = SesliMi(cumle[i]);
                if (durum == 1)
                {
                    sayac++;
                }
            }
            Console.WriteLine("yazdığınız cumle içerisinde {0} adet sesli harf mevcut.",sayac);
            Console.ReadLine();
        }
        static int SesliMi(char harf)
        {
            int sonuc = 0;
            char[] d = { 'a', 'e', 'ı', 'i', 'o', 'ü', 'ö', 'u' };
            
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == harf)
                {
                    sonuc = 1;
                    break;
                }

            }
            return sonuc;

        }
    }
}
