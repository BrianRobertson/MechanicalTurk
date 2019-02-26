using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalTurk
{
    class User
    {
        public string name;
        public User()
        {
            //constructor.
        }
        public void SetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", welcome to the session.");
        }
    }
}
