using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_3_7
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            /**
            * Выполнить вычисление нескольких операция с использованием Task.
            * Использовать WhenAll() что бы вывести результаты выполнения всех операций после их выполнения.
            *
            * Написать программу, которая вычисляет рекурсивно числа Фибоначчи.
            * Запустить вычисление чисел Фибоначчи через Task.
            * Использовать отмену операции если выполнение происходит дольше 10 сек.*/
            var sp1 = new Spammer();
            var sp2 = new Spammer();
            var sp3 = new Spammer();

            var tasks = new Task[]
            {
                Task.Run(() => sp1.Spam(100, 1)),
                Task.Run(() => sp2.Spam(500, 2)),
                Task.Run(() => sp3.Spam(300, 3))
            };

            await Task.WhenAll(tasks);

            Console.WriteLine("You survived Ddos attack\n");

            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            var f1 = Fibonacci.CountAsync(20, token);
            var f2 = Fibonacci.CountAsync(20, token);

            Thread.Sleep(10000);
            cts.Cancel();

            Console.WriteLine($"Fibo of 20: {f1.Result}");
            Console.WriteLine($"Fibo of 100: {f2.Result}");
        }
    }
}