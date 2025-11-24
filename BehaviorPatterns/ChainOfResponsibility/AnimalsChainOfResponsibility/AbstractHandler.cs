using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsChainOfResposibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"? Ошибка: Ни одно животное не смогло съесть {request.ToString()}");
                return null;
            }
        }
    }
}
