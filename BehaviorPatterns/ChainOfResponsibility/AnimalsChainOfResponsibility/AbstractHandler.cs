using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AnimalsChainOfResposibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public event Action<string> OnHandled;

        public AbstractHandler(IHandler handler)
        {
            _nextHandler = handler;
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

        protected void HandlerEvent(string message)
        {
            OnHandled?.Invoke(message);
        }
    }
}
