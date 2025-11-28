using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class MoveBackCommand : ICommand
    {
        private PlayerReceiver _player;

        public MoveBackCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.MoveBack();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена шага назад...");
            _player.MoveForward();
        }
    }
}
