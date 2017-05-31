using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("狗蛋",22);
            dic.Add("嘎嘎", 32);
            dic.Add("哈哈", 20);
            //遍历
            foreach (KeyValuePair<string,int> item in dic)
            {
                Console.WriteLine(item.Key+"    "+item.Value);
            }

            //获取泛型集合中的当前元素
            Console.WriteLine(dic["狗蛋"]);

            Console.WriteLine(dic.ContainsKey("狗蛋"));

            //尝试获取指定的key说对应的value
            int number;
            dic.TryGetValue("哈哈" ,out number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
