using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Core.Interfaces;

namespace Strategy.Core.Classes
{
    public class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
