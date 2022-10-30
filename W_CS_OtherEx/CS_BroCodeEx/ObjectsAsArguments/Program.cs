namespace ObjectsAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");
            ChangeColor(car1, "yellow");
            Console.WriteLine($"The {car1.model} has {car1.color} color");

            Car car2 = Copy(car1);

            Console.WriteLine($"{car1.color} {car1.model}");
        }
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}