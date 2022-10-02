namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine($"Element at index {i} is : {nums[i]}");
            }

            var counter = 0;
            foreach (int item in nums)
            {
                Console.WriteLine($"Element at index {counter} is : {item}");
                counter++;  
            }

            string[] friends = new string[5] {"Filip", "Blagica", "Marijana", "Peter", "Marcus   "};

            int count = 0;

            foreach (string friend in friends)
            {
                Console.WriteLine($"Friend at index {count} is : {friend}");
                count++;    
            }
          
        }
    }
}