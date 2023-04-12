using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Pinapple:Fruit
    {
        public double VitaminE;
        public double VitaminD;
        public Pinapple(double vitaminE,double vitaminD, double price, string sort) :base(price, sort)
        {  
            VitaminD = vitaminD;
            VitaminE = vitaminE;
        }

        public override void Taste()
        {
            Console.WriteLine("pineapple is sweet");
        }
    }
}
