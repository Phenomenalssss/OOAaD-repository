using RemoteControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlBridge
{
    public class ExtendedDriverForRemoteControl : DriverForRemoteControl
    {
        private Sound _sound;
        private Channel _channel;

        public ExtendedDriverForRemoteControl(Power power, Settings settings, Sound sound, Channel channel) : base(power, settings)
        { 
            _sound = sound;
            _channel = channel;
        }

        public override void Operation()
        {
            Console.WriteLine("Расширенный пульт:");
            _power.TurnOn();
            _settings.BrightnessUp();
            _settings.BrightnessUp();
            _settings.BrightnessDown();
            _channel.List();
            _channel.Previous();
            _channel.Next();
            _channel.Next();
            _channel.ForNumber(7);
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeDown();
            _sound.VolumeMute();
            _sound.VolumeUp();
            _sound.VolumeUnMute();
            _settings.Subtitles();
            _settings.SetBrightness(77);
            _settings.InformationAboutRemoteControl();
            _power.TurnOff();
            Console.WriteLine();
        }
    }
}
