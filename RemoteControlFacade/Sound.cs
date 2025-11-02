using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlFacade
{
    public class Sound
    {
        private int _volume = 50;
        private bool _inMute = false;
        private int _volumeForMute;

        public int Volume
        {
            get { return _volume; }
            private set;
        }

        public void VolumeUp()
        {
            if (_inMute)
            {
                Console.WriteLine("Ошибка. Звук выключен.");
            }
            else
            {
                if (_volume == 100)
                {
                    Console.WriteLine("Ошибка. Звук на максимальной громкости");
                }
                else
                {
                    _volume += 10;
                    Console.WriteLine($"Увеличение громкости ({_volume})");
                }
            }
        }

        public void VolumeDown()
        {
            if (_inMute)
            {
                Console.WriteLine("Ошибка. Звук выключен.");
            }
            else
            {
                if (_volume == 0)
                {
                    Console.WriteLine("Ошибка. Звук на минимальной громкости");
                }
                else
                {
                    _volume -= 10;
                    Console.WriteLine($"Уменьшение громкости ({_volume})");
                }
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
                _volumeForMute = _volume;
                _volume = 0;
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
                _volume = _volumeForMute;
                Console.WriteLine("Звук включён");
                _inMute = false;
            }
        }
    }
}
