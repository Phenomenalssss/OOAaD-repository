using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class JumpCommand : ICommand
    {
        private PlayerReceiver _player;

        public JumpCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Jump();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена прыжка...");
        }
    }
}
