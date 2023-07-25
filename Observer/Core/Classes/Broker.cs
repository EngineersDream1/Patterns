using Observer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Core.Classes
{
    internal class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable stock;

        public Broker(string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stockInfo = (StockInfo)ob;

            if(stockInfo.USD>85)
            {
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
            }
            else
            {
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, stockInfo.USD);
            }
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
