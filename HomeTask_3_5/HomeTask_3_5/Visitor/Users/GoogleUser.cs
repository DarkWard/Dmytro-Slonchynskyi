namespace HomeTask_3_5.Visitor
{
    public class GoogleUser : User
    {
        public GoogleUser(string email, string password)
            : base(email, password)
        {
            Email = email;
        }

        public string Email { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitGoogleUser(this);
        }
    }
}
