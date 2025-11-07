using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlLibrary;

namespace RemoteControlDecorator
{
    public class Decorator : Driver
    {
        private Driver _driver;

        public Decorator(Driver driver) 
        {
            _driver = driver;
        }

        public void SetComponent(Driver driver)
        {
            _driver = driver;
        }

        public override void Operation()
        {
            if (_driver != null)
            {
                _driver.Operation();
            }
            else
            {
                new Exception("Ошибка. Данного драйвера не существует");
            }
        }
    }
}
