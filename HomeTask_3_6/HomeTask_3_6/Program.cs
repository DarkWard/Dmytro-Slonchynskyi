using System.Collections.Concurrent;
using System.Threading;

namespace HomeTask_3_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var queue = new ConcurrentQueue<int>();
            var pub1 = new Publisher();
            var pub2 = new Publisher();

            var sub = new Subscriber(1, pub1);

            var thr1 = new Thread(() => pub1.Publish(queue));
            var thr2 = new Thread(() => pub2.Publish(queue));
            thr1.Start();
            thr2.Start();
        }
    }
}
