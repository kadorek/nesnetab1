using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgelesayivedizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int boyut = r.Next(50);
            int[] dizi = new int[boyut];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1000);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.WriteLine("boyut ={0}",boyut);
            Console.ReadLine();
        }
    }
}
