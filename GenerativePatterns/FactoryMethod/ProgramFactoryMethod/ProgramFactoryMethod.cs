using MazeFactoryMethod;

namespace Program
{
    class ProgramFactoryMethod
    {
        static void Main(string[] args)
        {
            MazeCreator justmaze = new MazeCreator();
            justmaze.CreateMaze();

            EnchantedMazeCreator enchactedmaze = new EnchantedMazeCreator();
            enchactedmaze.CreateMaze();

            BombedMazeCreator bombedmaze = new BombedMazeCreator();
            bombedmaze.CreateMaze();
        }
    }
}