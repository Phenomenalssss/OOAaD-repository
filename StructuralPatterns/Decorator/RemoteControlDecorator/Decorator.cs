using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlLibrary;

namespace RemoteControlDecorator
{
    public abstract class Decorator : Driver
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
            _driver.Operation();
        }
    }
}
