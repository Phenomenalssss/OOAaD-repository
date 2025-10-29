using MazeAbstractFactory;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System.Net.NetworkInformation;

namespace Singleton
{
    public class MazeSingletonFactory : IMazeFactory
    {
        static private IMazeFactory _instance = null;

        private MazeSingletonFactory() { }

        public static IMazeFactory Instance()
        {
            if (_instance == null)
            {
                Console.WriteLine("Вы создали единственный экземпляр лабиринта");
                _instance = new JustMazeFactory();
            }
            Console.WriteLine($"Экземпляр лабиринта уже существует");
            return _instance;
        }

        public Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали обычный лабиринт -----");
            return new Maze();
        }

        public Wall MakeWall()
        {
            return new Wall();
        }

        public Room MakeRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new Room(number);
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
