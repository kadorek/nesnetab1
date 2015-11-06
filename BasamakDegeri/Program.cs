using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasamakDegeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] basamaklar = { "birler", "onlar", "yüzler", "binler", "on binler" };

            Console.WriteLine("Lütfen en fazla 5 basamaklı olmak üzere bir sayı giriniz ;");

            string sayi = Console.ReadLine().Trim();

            int min = 10;

            for (int i = 0; i < sayi.Length; i++)
            {
                if (min > Convert.ToInt32(sayi[i].ToString()))
                {
                    min = Convert.ToInt32(sayi[i].ToString());
                }
            }

            Console.WriteLine("min:{0}",min);
            for (int i = 0; i < sayi.Length; i++)
            {
                if (min.ToString() == sayi[i].ToString())
                {

                    //Console.WriteLine("karakter:{0}",sayi[i]);
                    Console.WriteLine("en küçük basamak değerine '{0}' basamağı sahiptir.", basamaklar[i-basamaklar.Length-sayi.Length]);
                    break;
                }
            }

            Console.ReadLine();



        }
    }
}
