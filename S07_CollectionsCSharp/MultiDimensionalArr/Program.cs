namespace MultiDimensionalArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D Array
            string[,] matrix;

            //declare 3D Array
            int[,,] threeD;

            //two dimensional Array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            Console.WriteLine($"Central value is {array2D[1,1]}");
            Console.WriteLine($"Central value is {array2D[2,0]}");

            string[,,] array3D = new string[,,]
            {
                {
                {"000","001" },
                {"010","011" },
                {"Hi there","What's up" }
                },

                {
                {"000","001" },
                {"010","011" },
                {"Another one","Last one" }
                }

            };

            Console.WriteLine($" value is {array3D[0, 2, 0]}");
            Console.WriteLine($" value is {array3D[1, 2, 0]}");

            string[,] array2DString = new string[3, 2]
            {
                {"one","two" },
                {"three","four" },
                {"five","six" }
            };
            array2DString[1, 1] = "chicken";
            Console.WriteLine($"Changed value is {array2DString[1, 1]}");

            //Raank returns the amount of dimensions
            int dimesions = array2DString.Rank;
            Console.WriteLine($"The array has {dimesions} dimesions");
            int[,] arr2D = { { 1, 2 }, { 3, 4 } };
        }
    }
}