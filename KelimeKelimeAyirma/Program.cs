using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeKelimeAyirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Cümlenizi Giriniz.. : ");
            string cumle = Console.ReadLine().Trim();
            cumle = cumle.Replace(","," ");
            cumle = cumle.Replace(";"," ");
            string[] kelimeler = cumle.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++) 
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.ReadLine();
        }
    }
}
