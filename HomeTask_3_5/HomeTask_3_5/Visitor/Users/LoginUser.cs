namespace HomeTask_3_5.Visitor
{
    public class LoginUser : User
    {
        public LoginUser(string login, string password)
            : base(login, password)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitLoginUser(this);
        }
    }
}
