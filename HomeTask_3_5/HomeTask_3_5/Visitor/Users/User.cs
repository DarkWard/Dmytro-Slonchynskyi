namespace HomeTask_3_5.Visitor
{
    public abstract class User
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        protected User()
        {
        }

        public string Login { get; }
        public string Password { get; }

        public virtual void Accept(IVisitor visitor)
        {
        }
    }
}