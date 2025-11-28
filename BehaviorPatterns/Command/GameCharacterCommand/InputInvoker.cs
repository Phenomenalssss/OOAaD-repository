using GameCharacterCommand.Commands;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;

namespace GameCharacterCommand
{
    public class InputInvoker
    {
        private PlayerReceiver _player;
        private List<ICommand> _commands = new List<ICommand>();
        private bool _isReadInfo = false;
        private Stack<ICommand> _history = new Stack<ICommand>();
        private int _countOfCommands = 0;

        public InputInvoker(PlayerReceiver player)
        {
            _player = player;
            _commands.Add(new MoveForwardCommand(_player));
            _commands.Add(new MoveBackCommand(_player));
            _commands.Add(new MoveLeftCommand(_player));
            _commands.Add(new MoveRightCommand(_player));
            _commands.Add(new AttackCommand(_player));
            _commands.Add(new DefendCommand(_player));
            _commands.Add(new JumpCommand(_player));
            _commands.Add(new CastSpellCommand(_player));
            _commands.Add(new UseItemCommand(_player));
            _commands.Add(new ComboAttackCommand(_player));
            _commands.Add(new ParryCommand(_player));
        }

        public void Start()
        {
            if (_isReadInfo)
            {
                Console.WriteLine("----------------------");
                while (true)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift) && keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Игра завершена");
                        break;
                    }

                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift) && keyInfo.Key == ConsoleKey.Delete)
                    {
                        if (_history.Count > 0)
                        {
                            _history.Pop().Undo();
                        }
                        else
                        {
                            Console.WriteLine("История команд пуста");
                        }
                    }

                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift) && keyInfo.Key == ConsoleKey.C)
                    {
                        Console.WriteLine($"Количество выполненных команд = {_countOfCommands}");
                    }

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                            _countOfCommands++;
                            _commands[0].Execute();
                            _history.Push(_commands[0]);
                            break;
                        case ConsoleKey.S:
                            _countOfCommands++;
                            _commands[1].Execute();
                            _history.Push(_commands[1]);
                            break;
                        case ConsoleKey.A:
                            _countOfCommands++;
                            _commands[2].Execute();
                            _history.Push(_commands[2]);
                            break;
                        case ConsoleKey.D:
                            _countOfCommands++;
                            _commands[3].Execute();
                            _history.Push(_commands[3]);
                            break;
                        case ConsoleKey.Spacebar:
                            _countOfCommands++;
                            _commands[6].Execute();
                            _history.Push(_commands[6]);
                            break;
                        case ConsoleKey.Q:
                            _countOfCommands++;
                            _commands[7].Execute();
                            _history.Push(_commands[7]);
                            break;
                        case ConsoleKey.E:
                            _countOfCommands++;
                            _commands[8].Execute();
                            _history.Push(_commands[8]);
                            break;
                        default:
                            break;
                    }

                    if (!keyInfo.Modifiers.HasFlag(ConsoleModifiers.Alt) && keyInfo.Key == ConsoleKey.Z)
                    {
                        _countOfCommands++;
                        _commands[4].Execute();
                        _history.Push(_commands[4]);
                    }

                    if (!keyInfo.Modifiers.HasFlag(ConsoleModifiers.Alt) && keyInfo.Key == ConsoleKey.X)
                    {
                        _countOfCommands++;
                        _commands[5].Execute();
                        _history.Push(_commands[5]);
                    }

                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Alt) && keyInfo.Key == ConsoleKey.Z)
                    {
                        _countOfCommands++;
                        _commands[9].Execute();
                        _history.Push(_commands[9]);
                    }

                    if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Alt) && keyInfo.Key == ConsoleKey.X)
                    {
                        _countOfCommands++;
                        _commands[10].Execute();
                        _history.Push(_commands[10]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Сначала прочитайте информацию (ReadInfo())");
            }
        }

        public void ReadInfo()
        {
            if (!_isReadInfo)
            {
                _isReadInfo = true;
            }
            Console.WriteLine("Информация об игре:");
            Console.WriteLine("Завершить игру - <Shift + Esc>");
            Console.WriteLine("Отменить команду - <Shift + Delete>");
            Console.WriteLine("Узнать количество выполненных команд - <Shift + C>");
            Console.WriteLine("Шаг вперёд - <W>");
            Console.WriteLine("Шаг назад - <S>");
            Console.WriteLine("Шаг влево - <A>");
            Console.WriteLine("Шаг вправо - <D>");
            Console.WriteLine("Атака - <Z>");
            Console.WriteLine("Защита - <X>");
            Console.WriteLine("Прыжок - <Backspace>");
            Console.WriteLine("Заклинание - <Q>");
            Console.WriteLine("Использование предмета - <E>");
            Console.WriteLine("Комбо-атака - <Alt + Z>");
            Console.WriteLine("Парирование - <Alt + X>");
        }
    }
}
