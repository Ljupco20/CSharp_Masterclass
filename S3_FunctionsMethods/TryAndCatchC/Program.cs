using System;

namespace TryAndCatchC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Can't divide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exceptio, please enter the correct type next time");
            }
            catch (OverflowException)
            {

                Console.WriteLine("Overflow exceptio, the entered number was either too long or too short for int32");
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            catch (Exception)
            {

                Console.WriteLine("General exceptio, please enter the correct type next time");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }


        }
    }
}
