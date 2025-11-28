using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class MoveRightCommand : ICommand
    {
        private PlayerReceiver _player;

        public MoveRightCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.MoveRight();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена шага вправо...");
            _player.MoveLeft();
        }
    }
}
