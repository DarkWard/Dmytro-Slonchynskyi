using System;
using System.IO;

/*
 * Создать в отдельном файле класс Starter с методом Run
 * Сигнатура метода ничего не принимает и не возвращает
 *
 * Метод Run содержит:
 * Цикл(счетчик) на 100 итераций
 * Внутри цикла в случайном порядке вызывается один из 3х методов класса Actions
 * Если метод вернул Result со значением Status = false, то вызвать логгер и записать в него “Action failed by a reason:” и сообщение об ошибке из объекта Result
 * Этот лог должен быть с типом Error.
*/

namespace HomeTask4
{
    public static class Starter
    {
        public static void Run()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var randomValue = random.Next(1, 4);

                switch (randomValue)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Actions.FirstMethod();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Actions.SecondMethod();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        var res = Actions.ThirdMethod();
                        Logger.Instance.Log(LogLevel.Error, $"Action failed by a reason: {res.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        throw new ArgumentException("Random value is out of the range");
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.GetAllLogs());
        }
    }
}
