using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Core.Interfaces
{
    interface IObserver
    {
        void Update(Object ob);
    }
}
