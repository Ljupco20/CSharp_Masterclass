namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //an instance of Human
            Human ljupco = new Human("Ljupco", "Trajanovski", "brown", 36);

            // call methods of the class
            ljupco.introduceMyself();

            Human mia = new Human("Mia", "Bean", "blue", 1);
            mia.introduceMyself();

            Human tom = new Human("Tom", "Bean", "blue");
            tom.introduceMyself();

            Human marcus = new Human("Marcus", "Rashford");
            marcus.introduceMyself();

            Human peter = new Human("Peter");
            peter.introduceMyself();

            Human basicHuman = new Human();
            basicHuman.introduceMyself();

            
        }
    }
}