using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class DefendCommand : ICommand
    {
        private PlayerReceiver _player;

        public DefendCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Defend();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена защиты...");
        }
    }
}
