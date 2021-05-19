using System;

namespace ModuleTwo
{
    public abstract class User
    {
        public User(string login, string password, int number, string email)
        {
            Login = login;
            Password = password;
            Numner = number;
            Email = email;
        }

        public User(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
        }

        public User(string login, string password, int number)
        {
            Login = login;
            Password = password;
            Numner = number;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        protected User()
        {
        }

        [RequiredField(FieldName = "Login")]
        public string Login { get; }
        [RequiredField(FieldName = "Password")]
        public string Password { get; }
        public int Numner { get; set; }
        public string Email { get; set; }
    }
}