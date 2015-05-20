using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Realization
{
   public class CanYouDrinkAlcohol
    {
        private string name;
        private int age;

       public void StartProgram()
       {
           this.AskName();
           this.AskAge();
           this.CheckAge();

       }

       public void AskName()
        {
            Console.WriteLine("Hello! What is your name? Please type your name below.");
            this.name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + this.name);
        }

        public void AskAge()
        {
            Console.WriteLine("Please type your age below.");
            try
            {
                this.age = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("You have typed something else, not your age.");
                this.AskAge();
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("You have typed too many characters. Try again, please!");
                this.AskAge();
            }
        }

       public void CheckAge()
       {
           if (this.age == 18 || this.age > 18) 
           { 
               Console.WriteLine("You are old enough! Get drunk, but don't do this often!");
           }
           else if (this.age < 18 && this.age >= 0)
           {
                Console.WriteLine("Sorry, You are too young! Go and do your homework!");
           }
           else
           {
               Console.WriteLine("Please enter correct age!");
               this.AskAge();
               this.CheckAge();
           }
           
       }



    }
}
