using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31_lx
{
    class Sum
    {
        public static void add(int a, int b) {
            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
        }

        public static void add(double a, double b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
        }

        public static void add(float a, float b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
        }



        public static void add1<T>(T a, T b) {
            Console.WriteLine("{0}+{1}={2}",);
        }
    }
}
