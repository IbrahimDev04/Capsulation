using ConsoleApp17.Models;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uname = new User("ibrahim", "xusmandi", "Ssadw2323");
            //var uname1 = new User("ibrahim", "xusmandi", "sadw2323");
            //var uname2 = new User("ibrahim", "xusmandi", "Sadw");
            //var uname3 = new User("ibrahim", "xusmandi", "Sadw3");

            uname.ChangePassword("Ssadw2323","fdgagf2dsaf");

        }
        
    }
}