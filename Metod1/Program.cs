using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod1
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama();
            toplama2(11,7);
            int g1, g2;
            Console.WriteLine("lütfen birinci sayıyı giriniz");
            g1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            g2 = Convert.ToInt32(Console.ReadLine());
            toplama2(g1,g2);
            Console.WriteLine(toplama3(g1, g2));
            Console.ReadLine();


        }

        static void Toplama()
        {
            Console.WriteLine(6+5);
            
        }
        static void toplama2(int sayi1,int sayi2)
        {
           
            Console.WriteLine(sayi1+sayi2);
        }

        static int toplama3(int s1,int s2)
        {
            return s1 + s2;
        }

    }
}
