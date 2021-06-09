namespace HomeTask_3_5.Visitor
{
    public class PhoneUser : User
    {
        public PhoneUser(string number, string password)
            : base(number, password)
        {
            Number = number;
        }

        public string Number { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitPhoneUser(this);
        }
    }
}
