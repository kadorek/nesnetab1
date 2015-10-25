using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumleCKelime
{
    class Program
    {
        static void Main(string[] args)
        {
            string bilinmeyenMetin = Console.ReadLine();
            string[] parcalar = bilinmeyenMetin.Split(' ');
            for (int i = 0; i < parcalar.Length; i++)
            {
                Console.WriteLine("{1}", parcalar[i]);
            }
            
            
        }
    }
}
