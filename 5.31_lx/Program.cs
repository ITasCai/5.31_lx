using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDeam<int> ad = new ArrayDeam<int>();
            ad.Add(10);
            ad.Add(11);
            ad.Add(12);
            ad.Add(13);
            ad.Show();

            Console.ReadKey();
        }
    }
}
