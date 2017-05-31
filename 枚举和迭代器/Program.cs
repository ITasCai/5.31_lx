using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举和迭代器
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator it = new Iterator(3);
            it.ArrayPerson[0] = new Person("张三",18);
            it.ArrayPerson[1] = new Person("狗蛋", 28);
            it.ArrayPerson[2] = new Person("李四", 14);

            foreach (Person item in it)
            {
                Console.WriteLine("姓名："+item.Name+"      "+"年龄"+item.Age);
            }

            Console.ReadKey();
        }
    }
}
