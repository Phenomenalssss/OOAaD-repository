using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand
{
    public class PlayerReceiver
    {
        private string _name;

        public PlayerReceiver(string name)
        {
            _name = name;
        }

        public void MoveLeft()
        {
            Console.WriteLine($"Игрок {_name} сделал шаг влево");
        }

        public void MoveRight()
        {
            Console.WriteLine($"Игрок {_name} сделал шаг вправо");
        }

        public void MoveForward()
        {
            Console.WriteLine($"Игрок {_name} сделал шаг вперёд");
        }

        public void MoveBack()
        {
            Console.WriteLine($"Игрок {_name} сделал шаг назад");
        }

        public void Jump()
        {
            Console.WriteLine($"Игрок {_name} прыгнул");
        }

        public void Attack()
        {
            Console.WriteLine($"Игрок {_name} атаковал");
        }

        public void Defend()
        {
            Console.WriteLine($"Игрок {_name} защитился");
        }

        public void CastSpell()
        {
            Console.WriteLine($"Игрок {_name} применил заклинание");
        }

        public void UseItem()
        {
            Console.WriteLine($"Игрок {_name} использовал предмет");
        }
    }
}
