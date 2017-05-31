using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31_lx

{
    /// <summary>
    /// 泛型类，T可以是任何类型
    /// 泛型在编译的时候不指定数据类型，在调用的时候才指定数据类型
    /// 使用泛型可以使用任何类型的数组
    /// 泛型的优点：首先避免了装箱和拆箱，保护了类型安全，提高了程序性能。
    /// 泛型不能使用比较运算符，T的数据类型不能明确
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ArrayDeam<T>
    {
        private T [] array;
        //数组当前索引
        private int count = 0;
        public int Length { set; get; }

        public ArrayDeam() {
            array = new T[50];
        }

        public T this[int index] {
            set {
                array[index] = value;
            }

            get {
                return array[index];
            }
        }


        public int Count { get { return count; } }

        public void Add(T value) {
            array[count] = value;
            count++;
        }
        public void Show (){

            string str = "当前元素的个数为："+count+"：(";

            for (int i = 0; i < Count; i++)
            {
                str += array[i];
                if (i < Count - 1)
                {
                    str += " , ";
                }             
            }
            str += ")";
            Console.WriteLine(str);
        }
    }
}
