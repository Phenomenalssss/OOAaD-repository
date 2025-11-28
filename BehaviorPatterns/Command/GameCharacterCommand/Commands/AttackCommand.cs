using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class AttackCommand : ICommand
    {
        private PlayerReceiver _player;
        public AttackCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Attack();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена атаки...");
        }
    }
}
