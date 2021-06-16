using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_3_7
{
    public class Fibonacci
    {
        public static async ValueTask<int> CountAsync(int n, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Operation cancelled!");
                return 0;
            }
            else
            {
                return await Task.Run(() => Fibo(n, token));
            }
        }

        private static int Fibo(int n, CancellationToken token)
        {
            if ((n == 0 || n == 1) && !token.IsCancellationRequested)
            {
                return n;
            }
            else if (!token.IsCancellationRequested)
            {
                return Fibo(n - 1, token) + Fibo(n - 2, token);
            }
            else
            {
                Console.WriteLine("Operation was cancelled!");
                return 0;
            }
        }
    }
}