using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Program
    {
        static void Main(string[] args)
        {
            Human JamesCarter = new Human { Name = "JamesCarter" };

            JamesCarter.GoToSleep();
            Console.WriteLine($"{JamesCarter.IsAsleep}");
            Console.ReadLine();

            JamesCarter.WakeUp();
            Console.WriteLine($"{JamesCarter.IsAsleep}");
            Console.ReadLine();

            JamesCarter.DisplayGreetings();
            Console.ReadLine();

            JamesCarter.Displayname();
            Console.ReadLine();

            Panada Hairold = new Panada { Name = "Hairold" };

        }
    }
}
