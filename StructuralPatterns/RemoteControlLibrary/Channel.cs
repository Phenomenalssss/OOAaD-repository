using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlLibrary
{
    public class Channel
    {
        private static List<int> _channels = new List<int> {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
        private int _number = 0;
        private int _currentChannel;

        public Channel()
        {
            _currentChannel = _channels[_number];
        }

        public void List()
        {
             Console.WriteLine("Список каналов: " + string.Join(", ", _channels));
        }

        public void ForNumber(int number)
        {
            if (number >= 11 || number <= 0)
            {
                Console.WriteLine("Ошибка. Данного канала не существует (существующие каналы: 1-10)");
            }
            else
            {
                _currentChannel = _channels[number];
                Console.WriteLine($"Переключение на {number}-й канал ({_channels[number]})");
            }
        }

        public void Next() 
        {
            if (_currentChannel == _channels.Last())
            {
                Console.WriteLine("Ошибка. Следующего канала не существует");
            }
            else
            {
                _number++;
                _currentChannel = _channels[_number];
                Console.WriteLine($"Переключение на следующий канал ({_currentChannel})");
            }
        }

        public void Previous()
        {
            if (_currentChannel == _channels.First())
            {
                Console.WriteLine("Ошибка. Предыдущего канала не существует");
            }
            else
            {
                _number--;
                _currentChannel = _channels[_number];
                Console.WriteLine($"Переключение на предыдущий канал ({_currentChannel})");
            }
        }
    }
}
