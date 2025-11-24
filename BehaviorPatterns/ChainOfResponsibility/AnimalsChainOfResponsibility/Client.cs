using AnimalsChainOfResposibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsChainOfResponsibility
{
    public class Client
    {
        public static void Feed(AbstractHandler handler)
        {
            foreach(var food in new List<string> { "Орех", "Яблоко", "Банан", "Огурец", "Арбуз", "Бамбук" })
            {
                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Не получилось((((");
                }
            }
        }
    }
}
