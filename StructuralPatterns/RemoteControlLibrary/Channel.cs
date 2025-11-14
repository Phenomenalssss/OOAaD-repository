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
        private int _backChannel;
        private bool _isBackChannel = false;

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
            if (!_channels.Contains(number))
            {
                Console.WriteLine($"Ошибка. {number}-го канала не существует (существующие каналы: *.List())");
            }
            else
            {
                _isBackChannel = true;
                _backChannel = _currentChannel;
                _currentChannel = number;
                Console.WriteLine($"Переключение на {number}-й канал");
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
                _isBackChannel = true;
                _backChannel = _currentChannel;
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
                _isBackChannel = true;
                _backChannel = _currentChannel;
                _number--;
                _currentChannel = _channels[_number];
                Console.WriteLine($"Переключение на предыдущий канал ({_currentChannel})");
            }
        }

        public void Back()
        {
            if (!_isBackChannel)
            {
                Console.WriteLine("Ошибка. Вы не можете вернуться на прошлый канал");
            }
            else
            {
                int temp = _currentChannel;
                _currentChannel = _backChannel;
                _backChannel = temp;
                Console.WriteLine($"Переключение на прошлый канал ({_currentChannel})");
            }
        }
    }
}
