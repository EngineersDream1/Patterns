using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Core.Interfaces;

namespace Strategy
{
    public abstract class Duck
    {
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;

        public abstract void Display();

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All duck's can swim!");
        }

        public void SetFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour= fb;
        }

        public void SetQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour= qb;
        }
    }
}
