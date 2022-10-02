namespace DeclaringAndInitializingArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize array
            int[] grades = new int[5];

            grades[0] = 20;
            grades[0] = 25;
            grades[0] = 7;
            grades[0] = 2;
            grades[0] = 4;
            grades[0] = 18;
            Console.WriteLine($"grades at index 0 is {grades[0]}");
            Console.WriteLine($"Please enter a number");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"grades at index 0 is {grades[0]}");

            //another way of initializing array
            int[] gradesOfStudentsA = { 20, 15, 17, 18, 14 };

            //third way of initializing array
            int[] gradesOfStudentsB = new int[] { 20, 15, 17, 19, 16, 11 };
            Console.WriteLine($"Length of gradesOfStudentsA is {gradesOfStudentsA.Length}");
            Console.WriteLine($"Length of gradesOfStudentsB is {gradesOfStudentsB.Length}");
        }
    }
}