using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyeYakin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir metin giriniz: ");
            string metin = Console.ReadLine().Trim().ToUpper().Replace(" ","");

            int[] farklar = new int[metin.Length];
            int enKucuk = 100;

            for (int i = 0; i < metin.Length; i++)
            {
                farklar[i] = Convert.ToInt32('Z') - Convert.ToInt32(metin[i]);
                if (enKucuk>farklar[i])
                {
                    enKucuk = farklar[i];
                }
            }



            for (int i = 0; i < farklar.Length; i++)
            {
                if (farklar[i]==enKucuk)
                {
                    Console.WriteLine("{0} karekteri Z karakterine en yakın karakterdir.",metin[i]);
                    break;
                }
            }

            Console.ReadLine();



            









        }
    }
}
