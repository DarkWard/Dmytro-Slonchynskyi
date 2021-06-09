using System;

namespace HomeTask_3_5.Bridge
{
    public class PopMusic : IMusicBox
    {
        public void Play()
        {
            Console.WriteLine("Pop music playing!");
        }

        public void Stop()
        {
            Console.WriteLine("Pop music finished!");
        }
    }
}
