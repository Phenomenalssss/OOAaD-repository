using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class MoveLeftCommand : ICommand
    {
        private PlayerReceiver _player;
        public MoveLeftCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.MoveLeft();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена шага влево...");
            _player.MoveRight();
        }
    }
}
