using System;

namespace HomeTask_3_3.Task1
{
    public class Loader
    {
        public Loader()
        {
        }

        public event EventHandler EHandler;
        public int Progress { get; set; }

        public void NotifyObservers()
        {
            EHandler?.Invoke(this, EventArgs.Empty);
        }

        public void Load()
        {
            for (int i = 0; i < 101; i++)
            {
                Progress = i;
                NotifyObservers();
            }
        }
    }
}
