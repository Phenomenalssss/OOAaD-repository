namespace MazeFactory
{
    public class MazeFactory
    {
        private static MazeFactory _instance = null;

        protected MazeFactory() { }

        public static MazeFactory Instance()
        {
            if (_instance == null)
            {
                string mazeStyle 
                _instance = new MazeFactory();
            }
            return _instance;
        }
    }
}
