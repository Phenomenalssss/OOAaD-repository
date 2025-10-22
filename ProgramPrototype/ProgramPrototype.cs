using MazeAbstractFactory;
using MazeLibrary;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazePrototype;

namespace ProgramPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();

            JustMazePrototype simpleMazeFactory = new JustMazePrototype(new Maze(), new Wall(), new Room(5), new Door(new Room(3), new Room(11)));
            Maze maze = game.CreateMaze(simpleMazeFactory);

            JustMazePrototype bombedMazeFactory = new JustMazePrototype(new Maze(), new BombedWall(), new RoomWithBomb(8), new Door(new RoomWithBomb(2), new RoomWithBomb(10)));
            Maze bombedmaze = game.CreateMaze(bombedMazeFactory);

            JustMazePrototype enchantedMazeFactory = new JustMazePrototype(new Maze(), new Wall(), new EnchantedRoom(13), new EnchantedDoor(new EnchantedRoom(7), new EnchantedRoom(9)));
            Maze enchantedmaze = game.CreateMaze(enchantedMazeFactory);
        }
    }
}