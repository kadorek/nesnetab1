using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E-posta adresinizi giriniz:");
            string ePosta = Console.ReadLine().Trim();
            int etYeri = -1;
            for (int i = 0; i < ePosta.Length; i++)
            {
                if (ePosta[i]=='@')
                {
                    etYeri = i;
                    break;
                }
            }
            if (etYeri < 1)
            {
                Console.WriteLine("Yanlış e-Posta...");
                Console.ReadLine();
                return;
            }
            int noktaYeri = -1;
            for (int i = etYeri+1; i < ePosta.Length; i++)
            {
                if (ePosta[i]=='.')
                {
                    noktaYeri = i;
                    break;
                }
            }
            if (noktaYeri == -1)
            {
                Console.WriteLine("Yanlış e-Posta...");
                Console.ReadLine();
                return;
                
            }

            Console.WriteLine("{0} adresi dogru bir e-Posta adresidir.",ePosta);
            Console.ReadLine();
        }
    }
}
