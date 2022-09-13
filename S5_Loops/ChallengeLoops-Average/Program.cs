namespace ChallengeLoops_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            double averageScore = 0, score = 0, sum= 0, counter =0;

            while(input != "-1")
            {
                Console.WriteLine("Please enter a score between 0 and 20");
                Console.WriteLine("Or enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                score = double.Parse(input);

                if (input != "-1")
                {
                    averageScore = sum / counter;
                }
                if (score >= 0 && score <= 20 && double.TryParse(input, out score))
                {
                    sum += score;              
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("You've entered incorrect number, please enter a score between 0 and 20");
                    }
                   
                    continue;
                }
                counter++;
                Console.WriteLine($"The counter is {counter}");
            }

            Console.WriteLine($"the average sscore is {averageScore}");
        }
    }
}