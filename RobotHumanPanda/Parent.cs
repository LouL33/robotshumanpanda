using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Parent
    {// SLeep
        public bool IsAsleep { get; set; }
        public virtual string Name { get; set; }
        public string People { get; set; }
        public string Animal { get; set; }

        public virtual void GoToSleep()
        {
            IsAsleep = true;
        }

        public virtual void WakeUp()
        {
            IsAsleep = false;
        }

        // Name

        public virtual void Displayname()
        {
            Console.WriteLine($"{Name}");
        }
        //Eating Habbits
        public virtual void Eat(string food)
        {

            Console.WriteLine($"yum i ate food {food}");
        }

        //Greetings 
        public virtual void DisplayGreetings()
        {
            Console.WriteLine("Whats up");
        }

        public Parent(string human1)
        {
            Console.WriteLine($"producing an Human{human1}");
            this.People = human1;
        }

        public Parent(string panda1)
        {
            Console.WriteLine($"producing a panda{panda1}");
            this.Animal = panda1
        }


    }   

}
