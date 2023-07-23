using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        FlyBehaviour flyBehaviour;
        QuackBehaviour quackBehaviour;

        public Duck(FlyBehaviour flyBehaviour, QuackBehaviour quackBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
            this.quackBehaviour = quackBehaviour;
        }

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
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
