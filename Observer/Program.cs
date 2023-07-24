using Observer.Core.Classes;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Market!");

            Stock stock = new Stock();
            
            Console.ReadKey();
        }
    }
}