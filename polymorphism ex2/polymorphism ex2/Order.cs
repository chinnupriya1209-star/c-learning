using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_ex2
{
    internal class Foodorder
    {

        public void orderFood(string food)
        {
            Console.WriteLine("ordered:" + food);
        }
        public void orderFood(string food, int quality)
        {
            Console.WriteLine("ordered:" + quality + "" + food);

        }
        public void orderFood(string food, int quality,string drink)

        {
            Console.WriteLine("ordered:" +  quality + "" + food +"with" + drink);



        }


    }
}
