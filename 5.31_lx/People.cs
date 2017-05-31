using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31_lx
{
    class People : IComparable
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public People(string name,int age) {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            People p = (People)obj;
            return this.age.CompareTo(p.age);


            int result;
            if (this.age > p.age)
            {
                return 1;
            }
            else if (this.age < p.age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            return result;
        }
    }
}
