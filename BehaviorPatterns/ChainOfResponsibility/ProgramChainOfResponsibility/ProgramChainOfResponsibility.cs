using AnimalsChainOfResponsibility;
using AnimalsChainOfResposibility;
using System.Data.SqlTypes;
using System.Xml.XPath;

namespace ProgramChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractHandler monkey = new MonkeyHandler(null);
            PandaHandler panda = new PandaHandler(monkey);
            SquirrelHandler squirrel = new SquirrelHandler(panda);

            monkey.OnHandled += HanderEvent;
            Client.Feed(monkey);

            Console.WriteLine("-----------------------------------------------------------");

            panda.OnHandled += HanderEvent;
            Client.Feed(panda);

            Console.WriteLine("-----------------------------------------------------------");

            squirrel.OnHandled += HanderEvent;
            Client.Feed(squirrel);
        }

        public static void HanderEvent(string message)
        {
            Console.WriteLine($"[Event] {message}");
        }
    }
}