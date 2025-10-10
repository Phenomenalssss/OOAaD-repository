using MazeLibrary;


namespace MazeBuilder
{
    public interface IMazeBuilder
    {
        void BuildMaze();

        void BuildRoom(int room);

        void BuildDoor(int roomFrom, int roomTo);

        Maze GetMaze();
    }
}
