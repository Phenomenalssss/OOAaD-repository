using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsChainOfResposibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Банан")
            {
                return $"+ Обезьяна съела {request.ToString()}";
            }
            else
            {
                Console.WriteLine($"- Обезьяна не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
