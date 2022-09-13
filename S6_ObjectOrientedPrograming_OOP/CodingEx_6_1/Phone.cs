using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingEx_6_1
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }
        public Phone(string company, string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unknown";
        }
        public Phone(string company, string model, string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

    public class Run
    {
        public static void RunExercise()
        {
            
        }
    }
}
