using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsChainOfResposibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public SquirrelHandler(IHandler handler) : base(handler) { }

        public override object Handle(object request)
        {
            if (request.ToString() == "Орех")
            {
                HandlerEvent($"Белка съела {request}");
                return true;
            }
            else
            {
                Console.WriteLine($"- Белка не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
