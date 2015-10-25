using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlari1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazi = "kitap";
            string boslukluYazi = "  kök sal  ";
            string buyukYazi = "ENGIN";
            int[] dizi = { 3, 5, 7 };
            int s1 = 3;
            Console.WriteLine("deneme yazisi{0}", boslukluYazi);
            Console.WriteLine("deneme yazisi{0}", boslukluYazi.Trim());
            Console.WriteLine(boslukluYazi.ToUpper());
            Console.WriteLine(buyukYazi.ToLower());

            string ilkUc = boslukluYazi.Trim().Substring(0, 3);
            string sonUc = boslukluYazi.Trim().Substring(4);
            string bilinmeyenMetin = Console.ReadLine().Trim();
            Console.WriteLine("ilk uc harf : {0}", ilkUc);
            Console.WriteLine("son uc harf : {0}", sonUc);
            Console.WriteLine("bilinmeyenin son ucu : {0}", bilinmeyenMetin.Substring(bilinmeyenMetin.Length - 3));
            string[] parcalar = bilinmeyenMetin.Split(' ');
            for (int i = 0; i < parcalar.Length; i++)
            {
                Console.WriteLine("parca {0} : {1}", i, parcalar[i]);
            }

            string yeniMetin = bilinmeyenMetin.Replace(" ", "-");
            Console.WriteLine("yeni metin : {0}", yeniMetin);

            string slinmisMetin = yeniMetin.Remove(0, 5);
            Console.WriteLine("silinmis metin : {0}", slinmisMetin );


            Console.ReadLine();
        }
    }
}
