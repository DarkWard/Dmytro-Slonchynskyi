using System;
using ModuleTwo.Exceptions;

namespace ModuleTwo
{
    public class Starter
    {
        public static void Run()
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Выберите пункт из меню:\n\n1: Создать пользователя\n2: Просмотреть пользователей\n3: Выход\n");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            try
                            {
                                Register.Menu();
                            }
                            catch (WrongInputException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;

                        case 2:
                            try
                            {
                                foreach (var t in DataBase.Instance.GetAllUsers())
                                {
                                    Console.WriteLine($"Login: {t.Login}\nNumber: {t.Numner}\nEmail: {t.Email}\n");
                                }
                            }
                            catch (MissingUserException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;

                        case 3:
                            exit = true;
                            break;

                        default:
                            throw new ArgumentException("Input value is out of the range");
                    }
                }
                catch (Exception ex)
                {
                    _ = ex;
                    throw new WrongInputException("Введено неверное значение!");
                }
            }
            while (!exit);
        }
    }
}