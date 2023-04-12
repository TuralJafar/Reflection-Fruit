using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Apple:Fruit
    {
        public double VitaminA;
        public double VitaminB;
        public Apple( double vitaminA, double vitaminB, double price, string sort) :base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }

        public override void Taste()
        {
            Console.WriteLine("apple is tasty");
        }
    }
}
