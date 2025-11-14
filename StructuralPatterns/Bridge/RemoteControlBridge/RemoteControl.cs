using RemoteControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlBridge
{
    public class RemoteControl
    {
        private Power _power;
        private DriverForRemoteControl _driverForRemoteControl;

        public RemoteControl(Power power, DriverForRemoteControl driverForRemoteControl)
        {
            _power = power;
            _driverForRemoteControl = driverForRemoteControl;
        }

        public virtual void Use()
        {
            Console.WriteLine("---------- Абстрактный пульт ----------");
            _power.TurnOn();
            _driverForRemoteControl.Operation();
            _power.TurnOff();
            Console.WriteLine("---------- Абстрактный пульт ----------");
        }
    }
}
