using System;
using HomeTask_3_5.Visitor;
using HomeTask_3_5.Bridge;

namespace HomeTask_3_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Visitor demo:\n");
            DataBase.Instance.AddUser(new GoogleUser("my.email@google.com", "13412414"));
            DataBase.Instance.AddUser(new PhoneUser("3809990000", "13412414"));
            DataBase.Instance.AddUser(new LoginUser("MyLogin", "13412414"));

            Console.WriteLine("Representation for sites:");
            DataBase.Instance.Accept(new SiteVisitor());
            Console.WriteLine("\nRepresentation for desktops:");
            DataBase.Instance.Accept(new DesktopVisitor());

            Console.WriteLine("\n\nBridge Demo:\n");
            Listener man1 = new Rocker();
            man1.Listen();
            man1.StopListening();

            Listener man2 = new MusicLover(new PopMusic());
            man2.Listen();
            man2.StopListening();
            man2.Genre = new RockMusic();
            man2.Listen();
            man2.StopListening();
        }
    }
}