namespace HomeTask_3_5.Visitor
{
    public interface IVisitor
    {
        void VisitGoogleUser(GoogleUser user);
        void VisitPhoneUser(PhoneUser user);
        void VisitLoginUser(LoginUser user);
    }
}
