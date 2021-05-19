using System;
using ModuleTwo.Exceptions;

namespace ModuleTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Starter.Run();
            }
            catch (WrongInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}