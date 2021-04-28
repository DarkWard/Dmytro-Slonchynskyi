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
    public static class Actions
    {
        public static Result FirstMethod()
        {
            Logger.Instance.Log(LogLevel.Information, "Start method: FirstMethod");

            return new Result { Status = true };
        }

        public static Result SecondMethod()
        {
            Logger.Instance.Log(LogLevel.Warning, "Skipped logic in method: SecondMethod");

            return new Result { Status = true };
        }

        public static Result ThirdMethod()
        {
            Logger.Instance.Log(LogLevel.Error, "ThirdMethod");

            return new Result { Status = false, Message = "I broke a logic" };
        }
    }
}
