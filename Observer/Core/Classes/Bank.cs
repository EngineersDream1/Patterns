using Observer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Core.Classes
{
    internal class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        
        public Bank(string name, IObservable obs)
        {
            Name = name;
            this.stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stockInfo = (StockInfo)ob;

            if(stockInfo.EUR>95)
            {
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, stockInfo.EUR);
            }
            else
            {
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, stockInfo.EUR);
            }
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
