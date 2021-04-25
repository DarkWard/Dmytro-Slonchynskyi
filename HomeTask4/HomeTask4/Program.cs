/*
 * По окончанию цикла сформировать файл в котором будет текст всех записанных логов
 * В методе Main класса Program вызвать метод Run
 */

namespace HomeTask4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();
            Logger.Instance.WriteToFile();
        }
    }
}