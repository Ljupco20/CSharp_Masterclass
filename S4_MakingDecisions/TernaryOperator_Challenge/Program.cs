using System;

namespace TernaryOperator_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            //takes input from the user
            Console.WriteLine("What is the temperature outside?");
            inputValue = Console.ReadLine();

            //validate the input integer value
            bool validIntiger = int.TryParse(inputValue, out inputTemperature);

            if(validIntiger)
            {
                temperatureMessage = inputTemperature <=15? "it is too cold here":(inputTemperature >= 16 && inputTemperature <= 28) ? "it is ok" : "it is hot here";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("You didnt entered valid temperature");
            }
        }




        /*
        public static void CheckTemp()
        {
            Console.WriteLine("What is the temperature outside?");
            string userTemp = Console.ReadLine();
            //int temp;
            try
            {
               int temp = int.Parse(userTemp);
                int temperature = temp <= 15 ? "it is too cold here" : (temp >= 16 && temp <= 28) ? "it is ok" : "it is hot here";
            }
            catch (Exception)
            {

                Console.WriteLine("You didnt entered valid temperature");
            }

           


        }
        */
    }
}
