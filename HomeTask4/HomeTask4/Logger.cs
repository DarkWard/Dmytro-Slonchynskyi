using System;
using System.IO;
using System.Text;

/*
 * Логер пишет на консоль информацию в формате “{время_лога}: {тип_лога}: {сообщение}”
 * Типы лога: Error, Info, Warning
 * Вся логика работы логгера должна быть в отдельном файле
 * Логер предоставляет методы для взаимодействия с ним.
 * Логер должен реализовать паттерн (шаблон) проектирование одиночка (singleton)
 * Логер должен сохранять весь текст отчетов в оперативной памяти и при необходимости его отдавать
*/

namespace HomeTask4
{
    public class Logger
    {
        private static StringBuilder _result;
        private static Logger _logger;
        private static DateTime _time = DateTime.Now;

        private Logger()
        {
            _result = new StringBuilder("Log start:");
        }

        public static Logger Instance
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }

                return _logger;
            }
        }

        public void Log(string message, string type)
        {
            string str = $"{{{_time.ToLongTimeString()}}}: {{{type}}}: {{{message}}}";
            Console.WriteLine(str);
            _result.Append(str);
        }

        public void WriteToFile()
        {
            File.WriteAllText("log.txt", _result.ToString());
        }
    }
}