using System;
using ModuleTwo.Exceptions;

namespace ModuleTwo
{
    internal class Register : User
    {
        public Register(string login, string password, int number, string email)
            : base(login, password, number, email)
        {
        }

        public Register(string login, string password, string email)
            : base(login, password, email)
        {
        }

        public Register(string login, string password, int number)
            : base(login, password, number)
        {
        }

        public Register(string login, string password)
            : base(login, password)
        {
        }

        public static void Menu()
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Выберите пункт из меню:\n\n1: Регистрация по логину\n2: Регистриция через Google\n3: Регистрация по номеру телефона\n4: Отмена\n");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            try
                            {
                                RegisterViaLogin();
                            }
                            catch (PasswordTooWeakException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (UserExistsException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (FieldRequiredException ex)
                            {
                                Console.WriteLine($"Поле {ex.FieldName} обязательно для заполнения!");
                            }

                            break;

                        case 2:
                            try
                            {
                                RegisterViaGoogle();
                            }
                            catch (PasswordTooWeakException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (UserExistsException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (FieldRequiredException ex)
                            {
                                Console.WriteLine($"Поле {ex.FieldName} обязательно для заполнения!");
                            }

                            break;

                        case 3:
                            try
                            {
                                RegisterViaPhone();
                            }
                            catch (PasswordTooWeakException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (UserExistsException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (FieldRequiredException ex)
                            {
                                Console.WriteLine($"Поле {ex.FieldName} обязательно для заполнения!");
                            }

                            break;

                        case 4:
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

        public static void RegisterViaLogin()
        {
            string login = string.Empty;
            string password = string.Empty;
            int number = 0;
            string email = string.Empty;
            User user;

            Console.WriteLine("Введите желаемый логин\n");
            login = Console.ReadLine();

            if (login == null)
            {
                CheckRequiredField("Login");
            }
            else
            {
                DataBase.Instance.CheckLogin(login);
            }

            Console.WriteLine("Введите надёжный пароль (5 и более символов)\n");
            password = Console.ReadLine();

            if (password == null)
            {
                CheckRequiredField("Password");
            }
            else
            {
                DataBase.Instance.CheckPassword(password);
            }

            Console.WriteLine("Введите номер телефона (необязательно)");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                CheckRequiredField("Number");
            }

            Console.WriteLine("Введите Е-мейл (необязательно)");
            email = Console.ReadLine();

            if (email == null)
            {
                CheckRequiredField("Email");
            }

            if (number == 0 && email == null)
            {
                user = new Register(login, password);
            }
            else if (number != 0 && email == null)
            {
                user = new Register(login, password, number);
            }
            else if (number == 0 && email != null)
            {
                user = new Register(login, password, email);
            }
            else
            {
                user = new Register(login, password, number, email);
            }

            DataBase.Instance.AddUser(user);
            Console.WriteLine("Пользователь успешно создан!");
        }

        public static void RegisterViaGoogle()
        {
            string login = string.Empty;
            string password = string.Empty;
            int number = 0;
            User user;

            Console.WriteLine("При регистрации через Google почта будет использована в качестве логина");
            Console.WriteLine("Введите Е-мейл\n");
            login = Console.ReadLine();

            if (login == null)
            {
                CheckRequiredField("Login");
            }
            else
            {
                DataBase.Instance.CheckLogin(login);
            }

            Console.WriteLine("Введите надёжный пароль (5 и более символов)\n");
            password = Console.ReadLine();

            if (password == null)
            {
                CheckRequiredField("Password");
            }
            else
            {
                DataBase.Instance.CheckPassword(password);
            }

            Console.WriteLine("Введите номер телефона (необязательно)");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                CheckRequiredField("Number");
            }

            if (number == 0)
            {
                user = new Register(login, password, login);
            }
            else
            {
                user = new Register(login, password, number, login);
            }

            DataBase.Instance.AddUser(user);
            Console.WriteLine("Пользователь успешно создан!");
        }

        public static void RegisterViaPhone()
        {
            int login = 0;
            string password = string.Empty;
            string email = string.Empty;
            User user;

            Console.WriteLine("При регистрации через номер телефона, он будет использован в качестве логина");

            Console.WriteLine("Введите номер телефона\n");
            login = Convert.ToInt32(Console.ReadLine());

            if (login == 0)
            {
                CheckRequiredField("Login");
            }
            else
            {
                DataBase.Instance.CheckLogin($"{login}");
            }

            Console.WriteLine("Введите надёжный пароль (5 и более символов)\n");
            password = Console.ReadLine();

            if (password == null)
            {
                CheckRequiredField("Password");
            }
            else
            {
                DataBase.Instance.CheckPassword(password);
            }

            Console.WriteLine("Введите Е-мейл (необязательно)");
            email = Console.ReadLine();

            if (email == null)
            {
                CheckRequiredField("Number");
            }

            if (email == null)
            {
                user = new Register($"{login}", password, login);
            }
            else
            {
                user = new Register($"{login}", password, login, email);
            }

            DataBase.Instance.AddUser(user);
            Console.WriteLine("Пользователь успешно создан!");
        }

        public static void CheckRequiredField(string fieldName)
        {
            var attr = Attribute.GetCustomAttribute(typeof(User).GetProperty(fieldName), typeof(RequiredFieldAttribute)) as RequiredFieldAttribute;

            if (attr != null)
            {
                throw new FieldRequiredException(fieldName, "Поле обязательно для заполнения");
            }
        }
    }
}