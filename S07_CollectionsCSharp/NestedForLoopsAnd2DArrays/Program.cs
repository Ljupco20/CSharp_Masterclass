namespace NestedForLoopsAnd2DArrays
{
     class Program
    {
        static int[,] matrix =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
        static void Main(string[] args)
        {
            

            foreach (var item in matrix)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            // outer loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

            }

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.Write("\n" + matrix[i, j] + " ");
            }

         
            


        }
    }
}