using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalTurk
{
    public class Session
    {
        private User user1 = new User();
        private User user2 = new User();
        public void SetUpSession()
        {
            Console.WriteLine("Hello World! \nMy name is Mechanical Turk");
            user1.SetName();
        }
        public void RunSession()
        {
            Console.WriteLine(user1.name + ", I am happy to report the session is now running.");
            Console.WriteLine(user1.name + ", What are your thoughts on what to do next? Type them here please.");
            string playerThoughts = Console.ReadLine();
            Console.WriteLine("Your thoughts about " + playerThoughts + " seem good to me.");
        }
    }
}
