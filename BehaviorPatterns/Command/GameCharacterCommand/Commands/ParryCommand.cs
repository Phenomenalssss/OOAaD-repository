using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class ParryCommand : ICommand
    {
        private PlayerReceiver _player;

        public ParryCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            Console.WriteLine("----- Парирование -----");
            _player.Defend();
            _player.Attack();
            Console.WriteLine("----- Парирование -----");
        }

        public void Undo()
        {
            Console.WriteLine("Отмена парирования...");
        }
    }
}