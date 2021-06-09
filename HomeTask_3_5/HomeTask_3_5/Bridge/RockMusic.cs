using System;

namespace HomeTask_3_5.Bridge
{
    public class RockMusic : IMusicBox
    {
        public void Play()
        {
            Console.WriteLine("Rock music playing!");
        }

        public void Stop()
        {
            Console.WriteLine("Rock music finished!");
        }
    }
}
