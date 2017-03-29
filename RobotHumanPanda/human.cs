using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Human : Parent
    {  /* // There Names
        public string Name { get; set; }

        public void Displayname()
        {
            Console.WriteLine($"{Name}");
        }

        
        // Eating Habbits
        public void Eat(string food)
        {
            Console.WriteLine($"sweet i ate food{food}");
        }
        // Sleeping
        public bool IsAsleep { get; set; }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
        */

        public Human(): base("Human")
        {
            Console.WriteLine("Making a human");
        }
    }
}
