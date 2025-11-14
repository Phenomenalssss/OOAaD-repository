using RemoteControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlBridge
{
    public class ExtendedRemoteControl : RemoteControl
    {
        private Power _power;
        private Sound _sound;
        private Channel _channel;

        public ExtendedRemoteControl(Power power, Sound sound, Channel channel, DriverForRemoteControl driverForRemoteControl) : base(power, driverForRemoteControl) 
        {
            _power = power;
            _sound = sound;
            _channel = channel;
        }

        public override void Use()
        {
            Console.WriteLine("---------- Расширенный пульт ----------");
            _power.TurnOn();
            base.Use();
            _sound.SetVolumeForTwitch();
            _sound.SetVolumeForYoutube();
            _channel.Back();
            _power.TurnOff();
            Console.WriteLine("---------- Расширенный пульт ----------");            
        }
    }
}

//расширить -> ещё один пульт; пресеты для звука для определенного приложения, вернуться на предыдущий канал (по кругу)

