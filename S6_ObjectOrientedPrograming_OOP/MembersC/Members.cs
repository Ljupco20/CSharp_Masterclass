using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    internal class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;

        // member - properties - exposes jobTitle safety - properties start with capital letter
        public string JobTitle 
        { 
            get 
            { 
                return jobTitle; 
            } 
            set 
            {
                jobTitle = value;
            } 
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName}, and my job title is {jobTitle}, and I'm {age} years old");
            }
            
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is{this.salary}");
        }
        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Ljupco";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine($"Object created");
        }
        // member - finaliazer - destructor
        ~Members()
        {
            // cleans statements
            Console.WriteLine("Deconstruction of members objects");
            Debug.Write("Deconstruction of members objects");
        }
    }
}
