using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Core.Interfaces;

namespace Strategy.Core.Classes
{
    public class Quack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
