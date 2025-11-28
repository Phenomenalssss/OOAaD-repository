using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class MoveForwardCommand : ICommand
    {
        private PlayerReceiver _player;

        public MoveForwardCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.MoveForward();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена шага вперёд...");
            _player.MoveBack();
        }
    }
}
