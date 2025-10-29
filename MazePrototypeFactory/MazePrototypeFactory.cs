using MazeLibrary;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeAbstractFactory;

namespace MazePrototype
{
    public class MazePrototypeFactory : IMazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public Maze MakeMaze()
        {
            return _prototypeMaze.Clone();
        }

        public Room MakeRoom(int number) 
        {
            Room room = (Room) _prototypeRoom.Clone();
            room.Initialize(number);
            return room;
        }

        public Wall MakeWall()
        {
            return (Wall) _prototypeWall.Clone();
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            Door door = (Door) _prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
