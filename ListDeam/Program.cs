using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDeam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("狗蛋");
            list.Add("李四");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
            List<string> list1 = new List<string>();
            list1.Add("哈哈");
            list1.Add("嘎嘎");
            //将指定元素添加到元素末尾
            list1.AddRange(list);

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }

            //contains方法

            Console.WriteLine(list1.Contains("狗蛋"));
            Console.WriteLine("--------------------------");

            //list转换为数组
            string[] arr = list1.ToArray();
            string s = string.Join("|", arr);
            //foreach (string item in arr)
            //{
            //    Console.Write(item+" ");
            //}
            Console.WriteLine(s);
            //
            list1.Remove("嘎嘎");
            list1.RemoveAt(0);









          






            Console.ReadLine();
        }
    }
}
