using System;

namespace rowboat
{
    internal class Connector
    {
        private dynamic COM_Object; 
        private dynamic session; 
        private dynamic screen;
        private const int DELAY = 10; 
        private const string CLEAR = "<CLEAR>";

        public Connector()
        {
            this.COM_Object = Activator.CreateInstance(Type.GetTypeFromProgID("PASSPORT.System")); 
            this.session = null; 
            this.screen = null; 

            for (int i = 1; i <= this.COM_Object.Sessions.Count; i++)
            {
                string sessionName = (this.COM_Object.Session.Item(i).FullName).toUpper();
                string sessionType = "3270DSP"; 

                if (sessionName.Contains(sessionType))
                {
                    this.session = this.COM_Object.Session.Item(i);
                    this.screen = this.session.screen;
                }
            }
            if (this.session == null) throw new Exception("Couldn't find PASSPORT COM object");
        }

        public void put(string keys, int row, int col) 
        {
            screen.SendKeys(keys);
            screen.MoveTo(row, col);
        }

        public void put(string keys) 
        {
            screen.SendKeys(keys);
            screen.WaitHostQuiet(DELAY);
        }

        public bool clear() 
        {
            put(CLEAR);
            put(CLEAR);
            string display = "";
            for (int i = 1; i <= screen.Rows; i++)
            {
                display += screen.GetString(i, 1, 80); 
            }
            display = display.Trim();
            
            return display.Length == 0;
        }

        public string get(int row, int col, int length)
        {
            return screen.GetString(row, col, length);
        }

        public void move(int row, int col)
        {
            screen.MoveTo(row, col);
        }
    }
}