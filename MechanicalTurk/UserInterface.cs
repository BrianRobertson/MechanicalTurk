using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalTurk
{
    public static class UserInterface
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("Hello World! \nI am Mechanical Turk. \nWelcome one and all!");
        }
        public static void DisplayMainMenu()
        {
            Console.WriteLine("Display the Main Menu here. \nType the one you want here.\n"
                + "1. Option 1.\n"
                + "2. Option 2.\n"
                + "3. Option 3.\n");
        }
    }
}
