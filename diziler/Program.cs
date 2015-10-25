using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d=new int[5];
            int[] d1 = { 5, 6, 0, 18, 5 };
            d[0] = d1[0];
            for (int i = 0; i < d1.Length; i++)
            {
                d[i]=d1[i];
            }
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
            Console.ReadLine();
        }
    }
}
