using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsChainOfResposibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Орех")
            {
                return $"+ Белка съела {request.ToString()}";
            }
            else
            {
                Console.WriteLine($"- Белка не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
