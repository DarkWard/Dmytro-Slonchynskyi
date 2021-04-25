using System;

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
    public class Starter
    {
        public static void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                bool status = true;
                var random = new Random().Next(1, 4);
                Result res = new Result();

                if (random == 1)
                {
                    res = Actions.FirstMethod();
                    status = res.Status;
                }
                else if (random == 2)
                {
                    res = Actions.SecondMethod();
                    status = res.Status;
                }
                else if (random == 3)
                {
                    res = Actions.ThirdMethod();
                    status = res.Status;
                }

                if (!status)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Logger.Instance.Log($"Action failed by a reason: {res.Message}", "Error");
                }
            }
        }
    }
}
