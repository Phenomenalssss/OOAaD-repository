using MazeFactoryMethod;

namespace Program
{
    class ProgramFactoryMethod
    {
        static void Main(string[] args)
        {
            MazeGame justgame = new MazeGame();
            justgame.CreateMaze();

            EnchantedMazeGame enchactedgame = new EnchantedMazeGame();
            enchactedgame.CreateMaze();

            BombedMazeGame bombedgame = new BombedMazeGame();
            bombedgame.CreateMaze();
        }
    }
}