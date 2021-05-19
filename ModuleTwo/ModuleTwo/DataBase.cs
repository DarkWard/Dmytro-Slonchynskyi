using System;
using ModuleTwo.Exceptions;

namespace ModuleTwo
{
    internal class DataBase
    {
        private static User[] _users;
        private static DataBase _base;

        private DataBase()
        {
        }

        public static DataBase Instance
        {
            get
            {
                if (_base == null)
                {
                    _base = new DataBase();
                }

                return _base;
            }
        }

        public void AddUser(User user)
        {
            if (_users == null)
            {
                _users = new User[] { user };
            }
            else
            {
                var temporary = new User[_users.Length + 1];

                for (int i = 0; i < _users.Length; i++)
                {
                    temporary[i] = _users[i];
                }

                temporary[_users.Length] = user;
                _users = temporary;
            }
        }

        public void CheckLogin(string login)
        {
            if (_users != null)
            {
                foreach (var temp in _users)
                {
                    if (login.ToLower().CompareTo(temp.Login.ToLower()) == 0)
                    {
                        throw new UserExistsException("Пользователь с таким логином уже зарегистрирован");
                    }
                }
            }
        }

        public void CheckPassword(string password)
        {
            if (password.Length < 5)
            {
                throw new PasswordTooWeakException("Пароль слишком легко угадать");
            }
        }

        public User[] GetAllUsers()
        {
            if (_users == null)
            {
                throw new MissingUserException("В базе нет пользователей");
            }
            else
            {
                return _users;
            }
        }
    }
}
