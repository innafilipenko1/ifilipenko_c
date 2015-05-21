using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Realization
{
    using System.Text.RegularExpressions;

    class EncupsulationProgramm
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine("Please type your name:");
            string typedName = Console.ReadLine();
            if (Regex.IsMatch(typedName, @"^[a-zA-Z0-9]+$"))
            {
                this.Name = typedName;
                Console.WriteLine("Hello, my friend " + this.Name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your name is invalid.");
                Console.ReadLine();
            }
            
         }
   }
}
