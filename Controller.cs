namespace rowboat
{
    public class Controller
    {
        private const string ENTER = "<ENTER>";
        private const int delay = 10;
        private Connector connector;

        public Controller()
        {
            connector = new Connector();
        }
    }
}