namespace ForeachAndSwitch_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inpValType = string.Empty;

            Console.Write("Enter a value : ");
            string inpVal = Console.ReadLine();

            Console.WriteLine("Selecte the data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter  : ");
            int inputType = Convert.ToInt32(Console.ReadLine());
            switch (inputType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inpVal);
                    inpValType = "String";
                    break;
                case 2:
                   int returnVal =0;
                    //check for int
                    valid = int.TryParse(inpVal, out returnVal);
                    inpValType = "Integer";
                    break;
                case 3:
                    bool returnFlag = false;
                    //check for boolean
                    valid = bool.TryParse(inpVal, out returnFlag);
                    inpValType = "Boolean";
                    break;
                    default:
                    inpValType = "unknown";
                    Console.WriteLine("Not able to detect the input tye ");
                    break;
            }
            Console.WriteLine($"You have entered a value {inpVal}");
            if (valid)
            {
                Console.WriteLine($"It's valid : {inpValType}");
            }
            else
            {
                Console.WriteLine($"It's invalid : {inpValType}");
            }

        }
        /// <summary>
        /// function to check if the input string is valid string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value) 
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                    
            }
            return true;
        }
    }
}