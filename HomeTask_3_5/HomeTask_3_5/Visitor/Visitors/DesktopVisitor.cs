using System;

namespace HomeTask_3_5.Visitor
{
    public class DesktopVisitor : IVisitor
    {
        public void VisitGoogleUser(GoogleUser user)
        {
            string result = $"GOOGLE USER\nNAME: {user.Email}\nEMAIL: {user.Email}\n";
            Console.WriteLine(result);
        }

        public void VisitLoginUser(LoginUser user)
        {
            string result = $"LOGIN USER\nNAME: {user.Login}\nLOGIN: {user.Login}\n";
            Console.WriteLine(result);
        }

        public void VisitPhoneUser(PhoneUser user)
        {
            string result = $"PHONE USER\nNAME: {user.Number}\nNUMBER: {user.Number}\n";
            Console.WriteLine(result);
        }
    }
}
