using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlBridge
{
    public class RemoteControl
    {
        public static void Use(DriverForRemoteControl DriverForRemoteControl)
        {
            DriverForRemoteControl.Operation();
        }
    }
}
