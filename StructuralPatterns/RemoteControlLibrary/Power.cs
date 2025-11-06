using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlLibrary
{
    public class Power
    {
        private bool _power = false;

        public void TurnOn()
        {
            if (_power == true)
            {
                Console.WriteLine("Ошибка. Телевизор уже включён");
            }
            else
            {
                Console.WriteLine("Включение телевизора...");
                _power = true;
            }
        }

        public void TurnOff()
        {
            if (_power == false)
            {
                Console.WriteLine("Ошибка. Телевизор уже выключен");
            }
            else
            {
                _power = false;
                Console.WriteLine("Выключение телевизора...");
            }
        }
    }
}
