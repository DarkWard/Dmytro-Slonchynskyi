using System;

namespace HomeTask_3_5.Visitor
{
    public class SiteVisitor : IVisitor
    {
        public void VisitGoogleUser(GoogleUser user)
        {
            string result = "<Main><td>Google User</td>";
            result += "\n<td>Name" + user.Login + "</td>";
            result += "\n<tr><td>Email<td><td>" + user.Login + "</td></tr></Main>\n";
            Console.WriteLine(result);
        }

        public void VisitLoginUser(LoginUser user)
        {
            string result = "<Main><td>Google User</td>";
            result += "\n<td>Name" + user.Login + "</td>";
            result += "\n<tr><td>Login<td><td>" + user.Login + "</td></tr></Main>\n";
            Console.WriteLine(result);
        }

        public void VisitPhoneUser(PhoneUser user)
        {
            string result = "<Main><td>Google User</td>";
            result += "\n<td>Name" + user.Login + "</td>";
            result += "\n<tr><td>Number<td><td>" + user.Login + "</td></tr></Main>\n";
            Console.WriteLine(result);
        }
    }
}
