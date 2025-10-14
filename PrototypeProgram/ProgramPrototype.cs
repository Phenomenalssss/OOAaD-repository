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

            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new Room(1), new Door(new Room(1), new Room(2)));
            Maze maze = game.CreateMaze(simpleMazeFactory);

            MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(new Maze(), new BombedWall(), new RoomWithBomb(1), new Door(new Room(1), new Room(2)));
            Maze bombedmaze = game.CreateMaze(bombedMazeFactory);
        }
    }
}