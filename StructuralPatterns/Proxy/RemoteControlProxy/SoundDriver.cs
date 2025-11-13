using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlLibrary;

namespace RemoteControlProxy
{
    public class SoundDriver : IDriver
    {
        private Sound _sound;

        public SoundDriver(Sound sound)
        {
            _sound = sound;
        }

        public void Operation()
        {
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeUp();
            _sound.VolumeDown();
            _sound.VolumeMute();
            _sound.VolumeUp();
            _sound.VolumeUnMute();
        }
    }
}
