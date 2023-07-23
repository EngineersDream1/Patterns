using Strategy.Core.Classes;
using Strategy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm model duck!");
        }
    }
}
