namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box box = new Box();
            Box box = new Box(5,7,5);
            //box.length = 3;
            //box.SetLength(-4);
            //box.width = 5;
            box.Height = 4;
            box.Width = 5;
            Console.WriteLine($"Box's width is {box.Width}");
            Console.WriteLine($"Box's volume is {box.Volume}");
            box.DisplayInfo();
            box.Width = 4;

            Console.WriteLine($"Box length is {box.GetLength()}");
            Console.WriteLine($"Front surface of the box is {box.FrontSurface}");
        }


    }
}