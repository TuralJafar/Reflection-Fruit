using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Orange:Fruit
    {
        public double VitaminC;
        public Orange(double vitaminC, double price, string sort):base(price,sort)
        {
            VitaminC = vitaminC;

        }

        public override void Taste()
        {
            Console.WriteLine("pineapple is sour");
        }
    }
}
