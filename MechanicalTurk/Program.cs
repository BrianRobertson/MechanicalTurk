using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalTurk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Session session = new Session();
            session.SetUpSession();
            session.RunSession();
            Console.Read();
        }
    }
}
