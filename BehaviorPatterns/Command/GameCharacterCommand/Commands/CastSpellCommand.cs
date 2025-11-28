using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class CastSpellCommand : ICommand
    {
        private PlayerReceiver _player;

        public CastSpellCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.CastSpell();
        }

        public void Undo()
        {
            Console.WriteLine("Отмена заклинания...");
        }
    }
}
