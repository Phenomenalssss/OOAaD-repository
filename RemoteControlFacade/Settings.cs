using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlFacade
{
    public class Settings
    {
        private bool _subtitles = false;
        private int _brightness = 50;

        public int Brightness
        {
            get { return _brightness; }
            private set;
        }

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
            if (brightness <= -1 || brightness >= 101)
            {
                _brightness = brightness;
                Console.WriteLine($"Установлена яркость: {_brightness}");
            }
        }

        public void BrightnessUp()
        {
            if (_brightness >= 100)
            {
                Console.WriteLine("Ошибка. Яркость на максмимальном значении");
            }
            else
            {
                _brightness += 10;
                Console.WriteLine($"Яркость увеличена ({_brightness})");
            }
        }

        public void BrightnessDown()
        {
            if (_brightness <= 0)
            {
                Console.WriteLine("Ошибка. Яркость на минимальном значении");
            }
            else
            {
                _brightness -= 10;
                Console.WriteLine($"Яркость снижена ({_brightness})");
            }
        }

        public void InformationAboutRemoteControl()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Модель пульта: Facade");
            Console.WriteLine("Версия: 3.4.2");
            Console.WriteLine("Дата выпуска: 02.11.2025");
            Console.WriteLine("-----");
        }
    }
}
