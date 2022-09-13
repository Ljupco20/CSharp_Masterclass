using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    // this class is a blueprint for a datatype
     class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age; 

        }

        //member method 
        public void introduceMyself()
        {
            if (age == 1)
            {
                Console.WriteLine($"Hi my first name is {firstName} and last name is {lastName}, I'm {age} year old, and have {eyeColor} eyes");
            }
            else
            {
                Console.WriteLine($"Hi my first name is {firstName} and last name is {lastName}, I'm {age} years old, and have {eyeColor} eyes");
            }
           
        }

    }
}
