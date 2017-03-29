using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Robot
    {
        public void StartUp()
        {
            Console.WriteLine("Started");
            IsAsleep = false;
        }

        public void ShutDown()
        {
            Console.WriteLine("Shutdown");
            IsAsleep = true;
        }

        public void Terminator()
        {
            IsTerminator = true;
        }

        public void Terminator1()
        {
            IsTerminator = false;
        }


        public bool IsTerminator { get; set; }
        public bool IsAsleep { get; set; }

        
    }
}
