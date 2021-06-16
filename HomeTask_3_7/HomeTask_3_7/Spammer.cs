using System;
using System.Threading;

namespace HomeTask_3_7
{
    public class Spammer
    {
        public void Spam(int interval, int id)
        {
            Console.WriteLine($"Spammer number {id} began to collect data");

            var result = new string[10];
            for (int i = 0; i < 5; i++)
            {
                result[i] = $"Ddos hit number {i + 1} from spammer number {id}";
                Thread.Sleep(interval);
            }

            Console.WriteLine($"Spammer number {id} colleted enough data attack begins");
            Console.WriteLine(ToString(result));
        }

        private static string ToString(string[] input)
        {
            var res = string.Empty;
            foreach (var t in input)
            {
                res += t + '\n';
            }

            return res;
        }
    }
}
