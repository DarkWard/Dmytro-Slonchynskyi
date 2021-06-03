using HomeTask_3_3.Task1;
using HomeTask_3_3.Task2;

namespace HomeTask_3_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var load = new Loader();
            var observer = new LoadingObserver(load);
            observer.Subscribe();
            load.Load();

            var pub = new Publisher();
            _ = new Subscriber(1, pub);

            pub.Publish();
        }
    }
}