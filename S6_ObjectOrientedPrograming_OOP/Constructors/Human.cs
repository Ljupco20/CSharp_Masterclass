using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constractor called. Object created ");
        }

        //parameterized constructor
        public Human(string firstName)
        {
            this.firstName = firstName;
      

        }
        //parameterized constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;  
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method 
        public void introduceMyself()
        {
            if (firstName != null && lastName != null && eyeColor != null && (age != 0 && age != 1))
            {
                Console.WriteLine($"Hi my first name is {firstName} and last name is {lastName}, I'm {age} years old, and have {eyeColor} eyes");
            }
            else if (firstName != null && lastName != null && eyeColor != null && (age == 1))
            {
                Console.WriteLine($"Hi my first name is {firstName} and last name is {lastName}, I'm {age} year old, and have {eyeColor} eyes");
            }
            else if (firstName != null && lastName != null && eyeColor != null && (age == 0))
            {
                Console.WriteLine($"Hi my first name is {firstName}, last name is {lastName} and have {eyeColor} eyes");
            }
            else if (firstName != null && lastName != null && eyeColor == null && (age == 0))
            {
                Console.WriteLine($"Hi my first name is {firstName}, last name is {lastName} ");
            }
            else if (firstName != null && lastName == null && eyeColor == null && (age == 0))
            {
                Console.WriteLine($"Hi my first name is {firstName}");
            } 
            

        }
    }
}
