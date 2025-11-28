using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class UseItemCommand : ICommand
    {
        private PlayerReceiver _player;

        public UseItemCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.UseItem();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена использования предмета...");
        }
    }
}
