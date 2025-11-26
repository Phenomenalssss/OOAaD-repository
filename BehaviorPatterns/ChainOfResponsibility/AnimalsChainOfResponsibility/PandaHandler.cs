using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AnimalsChainOfResposibility
{
    public class PandaHandler : AbstractHandler
    {
        public PandaHandler(IHandler handler) : base(handler) { }

        public override object Handle(object request)
        {
            if (request.ToString() == "Бамбук")
            {
                HandlerEvent($"Панда съела {request}");
                return true;
            }
            else
            {
                Console.WriteLine($"- Панда не смогла съесть {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
