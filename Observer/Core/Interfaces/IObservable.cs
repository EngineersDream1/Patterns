using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Core.Interfaces
{
    interface IObservable
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
