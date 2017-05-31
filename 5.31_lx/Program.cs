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
            //ArrayDeam<int> ad = new ArrayDeam<int>();
            //ad.Add(10);
            //ad.Add(11);
            //ad.Add(12);
            //ad.Add(13);
            //ad.Show();
            //ad[0] = 22;

            Product[] p = new Product[3];
            p[0] = new Product("电脑", 1212, "联想");
            p[1] = new Product("冰箱", 999, "海尔");
            p[2] = new Product("手机",555,"小米");

            foreach (Product item in p)
            {
                Console.WriteLine(item.Name+"   "+item.Price+"      "+item.Vendor);
            }
            Console.ReadKey();
        }
    }
}
