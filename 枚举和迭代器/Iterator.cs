using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举和迭代器
{
    class Iterator:IEnumerable,IEnumerator
    {
        public Person[] ArrayPerson;
        private int count;//集合中当前元素的索引
        private int length;
        public int Length { get { return length; } }

        public Iterator()
        {

        }

        public Iterator(int length)
        {
            this.length = length;
            ArrayPerson = new Person[Length];//初始化数组长度
            count = -1;  //初始化索引为-1,即第一个元素之前
        }



        /// <summary>
        /// 取到集合中当前元素
        /// </summary>
        public object Current
        {
            get
            {
                return ArrayPerson[count];
            }
        }

       
        /// <summary>
        /// 该枚举数支持在非泛型集合上进行简单迭代
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return this;    //返回
        }


        /// <summary>
        /// 将枚举数推进到集合的下一个元素
        /// 循环到集合中的下一个元素
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            int index = ++count;  //集合中当前元素的索引（每次都递增++）
            bool result = index < ArrayPerson.Length;//判断当前元素的索引小于数组的长度
            return result;
        }

        /// <summary>
        /// 将枚举数设置为初始位置，该位置位于集合中第一个元素之前
        /// </summary>
        public void Reset()
        {
            count = -1;
        }
    }
}
