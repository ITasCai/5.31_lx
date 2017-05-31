using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31_lx
{
    class Product :IComparable
    {
        public string Name { get; set; }
        public int Price { set; get; }
        public string Vendor { set; get; }


        public Product(string Name,int Price,string Vendor) {
            this.Name = Name;
            this.Price = Price;
            this.Vendor = Vendor;
        }

        public int CompareTo(object obj)
        {
            Product p = (Product)obj;
            return this.Price.CompareTo(p.Price);


            int result;
            if (this.Price > p.Price)
            {
                return 1;
            }
            else if (this.Price < p.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            return result;
        }



        //public double GetDuan(object obj)
        //{

        //    Product p = (Product)obj;
        //    double result;
        //    if (this.Price>p.Price)
        //    {
        //        return 1;
        //    }
        //    else if (this.Price < p.Price)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //    return result;

    //}
    }
}
