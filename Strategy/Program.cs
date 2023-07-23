using Strategy.Classes;
using Strategy.Core.Classes;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck modelDuck = new ModelDuck();

            modelDuck.PerformFly();
            modelDuck.PerformQuack();
            modelDuck.SetQuackBehaviour(new Squeak());
            modelDuck.PerformQuack();

            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Console.ReadKey();
        }
    }
}