using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal abstract class Fruit
    {
        public double Price;
        public string Sort;

        public Fruit(double price, string sort)
        {
            Price = price;
            Sort = sort;
        }
        public abstract void Taste();
        
    }
   
}
