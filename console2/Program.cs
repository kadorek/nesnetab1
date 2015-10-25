using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console2
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = 54;
            if (not<25)
            {
                Console.WriteLine("{0} 0 aldınız", not);
            }
            if (not<45 && not>=25)
            {
                Console.WriteLine("{0} 1 aldınız", not);
            }
            if (not < 55 && not >= 45)
            {
                Console.WriteLine("{0} 2 aldınız", not);
            }
            if (not < 70 && not > 54)
            {
                Console.WriteLine("{0} 3 aldınız", not);
            }
            if (not < 85 && not > 69)
            {
                Console.WriteLine("{0} 4 aldınız",not);
            }
            if (not <= 100 && not > 84)
            {
                Console.WriteLine("{0} 5 aldınız", not);
            }

            Class1.d();

            Console.ReadLine();
        }
    }
}
