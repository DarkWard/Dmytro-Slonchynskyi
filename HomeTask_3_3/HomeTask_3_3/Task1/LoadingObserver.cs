using System;

namespace HomeTask_3_3.Task1
{
    public class LoadingObserver : IObserver
    {
        private Loader _subject;

        public LoadingObserver(Loader subject)
        {
            _subject = subject;
        }

        public void Subscribe()
        {
            _subject.EHandler += PrintLoad;
        }

        public void UnSubscribe()
        {
            _subject.EHandler += PrintLoad;
        }

        private void PrintLoad(object sender, EventArgs e)
        {
            if (_subject.Progress == 100)
            {
                Console.WriteLine("Loading complete!");
            }
            else if (_subject.Progress % 5 == 0)
            {
                Console.WriteLine($"Loading: {_subject.Progress}%");
            }
        }
    }
}