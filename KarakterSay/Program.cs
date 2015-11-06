using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterSay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] adetler = new int[256];
            Console.WriteLine("Lütfen bir metin giriniz : ");
            string metin = Console.ReadLine().Trim();

            for (int i = 0; i < metin.Length; i++)
            {
                char c = metin[i];
                int index = Convert.ToInt32(c);
                adetler[index]++;
            }

            for (int i = 0; i < adetler.Length; i++)
            {
                if (adetler[i] > 0)
                {
                    Console.WriteLine("'{0}' harfinden {1} adet mevcut.", Convert.ToChar(i), adetler[i]);
                }
            }

            Console.ReadKey();


        }
    }
}
