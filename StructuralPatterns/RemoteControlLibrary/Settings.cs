using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlLibrary
{
    public class Settings
    {
        private bool _subtitles = false;
        private const int _maxBrightness = 100;
        private const int _minBrightness = 0;

        public int Brightness { get; private set; } = 50;

        public void Subtitles()
        {
            if (_subtitles)
            {
                _subtitles = false;
                Console.WriteLine("Субтитры выключены");
            }
            else
            {
                _subtitles = true;
                Console.WriteLine("Субтитры включены");
            }
        }

        public void SetBrightness(int brightness)
        {
            if (brightness <= _maxBrightness && brightness >= _minBrightness)
            {
                Brightness = brightness;
                Console.WriteLine($"Установлена яркость: {Brightness}");
            }
            else
            {
                Console.WriteLine("Ошибка. Неверное значение яркости");
            }
        }

        public void BrightnessUp()
        {
            if (Brightness >= _maxBrightness)
            {
                Console.WriteLine("Ошибка. Яркость на максмимальном значении");
            }
            else
            {
                Brightness += 10;
                Console.WriteLine($"Яркость увеличена ({Brightness})");
            }
        }

        public void BrightnessDown()
        {
            if (Brightness <= _minBrightness)
            {
                Console.WriteLine("Ошибка. Яркость на минимальном значении");
            }
            else
            {
                Brightness -= 10;
                Console.WriteLine($"Яркость снижена ({Brightness})");
            }
        }
    }
}
