using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Realization
{
    class MyDogs
    {

        public static void main(string[] args)
        {

            /* 1. creation of new instance of an object
                   2. two objects are independent from each other
                */
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            //each dog has unique values and represent value data type
            dog1.age = 1;
            dog1.name = "Pushok";
            dog2.age = 2;

            //It appears my dog is a girl not a boy, so I need to change the name.  dog3 is a reference to my dog1 and represent reference data type
            Dog dog3 = dog1;
            dog3.name = "Pushynka";
        }

    }
}
