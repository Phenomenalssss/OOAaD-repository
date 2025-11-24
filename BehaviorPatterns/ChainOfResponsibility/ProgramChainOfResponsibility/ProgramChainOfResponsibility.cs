using AnimalsChainOfResponsibility;
using AnimalsChainOfResposibility;
using System.Xml.XPath;

namespace ProgramChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyHandler monkey = new MonkeyHandler();
            PandaHandler panda = new PandaHandler();
            SquirrelHandler squirrel = new SquirrelHandler();

            monkey.SetNext(panda).SetNext(squirrel);
            Client.Feed(monkey);

            Console.WriteLine("-----------------------------------------------------------");

            Client.Feed(panda);
        }
    }
}