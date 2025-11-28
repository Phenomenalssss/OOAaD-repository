using GameCharacterCommand;

namespace ProgramCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ник игрока = ");
            string name = Console.ReadLine();
            while (name.IsWhiteSpace() || name.Length == 0)
            {
                Console.Write("Ошибка. Введите ник игрока = ");
                name = Console.ReadLine();
            }
            PlayerReceiver player = new PlayerReceiver(name);
            InputInvoker game = new InputInvoker(player);
            game.Start();
            game.ReadInfo();
            game.Start();
        }
    }
}