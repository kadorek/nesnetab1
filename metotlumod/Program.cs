using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlumod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
                
			{
                
                bolunuyormu(i);
			}
            Console.ReadLine();
        }
        static void bolunuyormu(int sayi)
        {
            if (sayi%3==0)
            {
                Console.WriteLine("{0} sayısı üçe bölünebilir",sayi);
                
            } 
        }
    }
}

