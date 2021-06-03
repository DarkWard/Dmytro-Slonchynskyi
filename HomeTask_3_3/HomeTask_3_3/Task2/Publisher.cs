using System;

namespace HomeTask_3_3.Task2
{
    public class Publisher
    {
        public event EventHandler EHandler;

        public void Publish()
        {
            Console.WriteLine("Event pubblishing");
            EventRaiser(EventArgs.Empty);
        }

        public void EventRaiser(EventArgs e)
        {
            var eve = EHandler;

            if (EHandler != null)
            {
                EHandler(this, e);
            }
        }
    }
}