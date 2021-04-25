/*
 * Необходимо создать в отдельном файле класс Actions в котором будет 3 метода
 * Сигнатура методов в классе Actions: методы ничего не принимают и возвращают объект класса Result.
 * Методы в классе Actions должны вызывать логгер для того чтобы записать сообщение в котором будет указан текст :
 *
 * 1 метод “Start method:” и имя этого метода. Этот лог должен быть с типом Info. Метод возвращает Result где Status =  true
 * 2 метод “Skipped logic in method:” и имя этого метода. Этот лог должен быть с типом Warning. Метод возвращает Result где Status =  true
 * 3 метод Метод возвращает Result где свойство об ошибке = “I broke a logic”. а Status = false
*/

using System;

namespace HomeTask4
{
    public class Actions
    {
        public static Result FirstMethod()
        {
            var res = new Result();
            res.Status = true;
            Console.ForegroundColor = ConsoleColor.Green;

            Logger.Instance.Log("Start method: FirstMethod", "Info");

            return res;
        }

        public static Result SecondMethod()
        {
            var res = new Result();
            res.Status = true;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Logger.Instance.Log("Skipped logic in method: SecondMethod", "Warning");

            return new Result();
        }

        public static Result ThirdMethod()
        {
            var res = new Result();
            res.Status = false;
            res.Message = "I broke a logic";
            Console.ForegroundColor = ConsoleColor.Red;

            Logger.Instance.Log("ThirdMethod", "Error");

            return res;
        }
    }
}
