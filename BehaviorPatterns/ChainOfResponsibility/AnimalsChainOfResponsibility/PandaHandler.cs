using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AnimalsChainOfResposibility
{
    public class PandaHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Бамбук")
            {
                return $"+ Панда съела {request.ToString()}";
            }
            else
            {
                Console.WriteLine($"- Панда не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
