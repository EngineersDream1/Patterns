using Observer.Core.Classes;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Market!");

            Stock stock = new Stock();
            Bank bank = new Bank("ВТБ", stock);
            Broker broker = new Broker("Сергей Александрович", stock);
            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            Console.Read();

            Console.ReadKey();
        }
    }
}