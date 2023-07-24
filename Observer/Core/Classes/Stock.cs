using Observer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Core.Classes
{
    class Stock : IObservable
    {
        StockInfo stockInfo;
        List<IObserver> observers;

        public Stock()
        {
            observers= new List<IObserver>();
            stockInfo= new StockInfo();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(IObserver o in observers)
            {
                o.Update();
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(80, 90);
            stockInfo.EUR = rnd.Next(90, 100);
            NotifyObservers();
        }
        
    }
}
