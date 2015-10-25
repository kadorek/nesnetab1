using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToplamaGenel(3,5,7));
            Console.WriteLine(ToplamaGenel(4,5,6,7,8));
            Console.ReadLine();
        }
        static int ToplamaGenel(params int[] gelenSayilar)
        {
            int toplam = 0;
            for (int i = 0; i < gelenSayilar.Length; i++)
            {
                toplam += gelenSayilar[i];  
            }
            return toplam;
        }
    }
}
