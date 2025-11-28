using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterCommand.Commands
{
    public class ComboAttackCommand : ICommand
    {
        private PlayerReceiver _player;

        public ComboAttackCommand(PlayerReceiver player)
        {
            _player = player;
        }

        public void Execute()
        {
            Console.WriteLine("----- Комбо-атака -----");
            _player.Jump();
            _player.Attack();
            _player.CastSpell();
            Console.WriteLine("----- Комбо-атака -----");
        }

        public void Undo()
        {
            Console.WriteLine("Отмена комбо-атаки...");
        }
    }
}
