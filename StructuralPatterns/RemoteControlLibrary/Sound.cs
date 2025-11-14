using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlLibrary
{
    public class Sound
    {
        private bool _inMute = false;
        private int _volumeForMute;
        private const int _maxVolume = 100;
        private const int _minVolume = 0;

        public int Volume { get; private set; } = 50;

        public void VolumeUp()
        {
            if (_inMute)
            {
                VolumeUnMute();
            }

            if (Volume == _maxVolume)
            {
                Console.WriteLine("Ошибка. Звук на максимальной громкости");
            }
            else
            {
                Volume += 10;
                Console.WriteLine($"Увеличение громкости ({Volume})");
            }
        }

        public void VolumeDown()
        {
            if (_inMute)
            {
                VolumeUnMute();
            }

            if (Volume == _minVolume)
            {
                Console.WriteLine("Ошибка. Звук на минимальной громкости");
            }
            else
            {
                Volume -= 10;
                Console.WriteLine($"Уменьшение громкости ({Volume})");
            }
        }

        public void VolumeMute()
        {
            if (_inMute)
            {
                Console.WriteLine("Ошибка. Звук уже выключен");
            }
            else
            {
                _volumeForMute = Volume;
                Volume = 0;
                Console.WriteLine("Звук выключен");
                _inMute = true;
            }
        }

        public void VolumeUnMute()
        {
            if (!_inMute)
            {
                Console.WriteLine("Ошибка. Звук уже включён");
            }
            else
            {
                Volume = _volumeForMute;
                Console.WriteLine("Звук включён");
                _inMute = false;
            }
        }

        public void SetVolumeForYoutube()
        {
            Volume = 75;
            Console.WriteLine("Звук установлен для Youtube (75)");
        }

        public void SetVolumeForTwitch()
        {
            Volume = 60;
            Console.WriteLine("Звук установлен для Twitch (60)");
        }
    }
}
