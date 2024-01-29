namespace ConsoleApp29Gennaio
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete1 = new Athlete();
            athlete1.name = "Federica";
            athlete1.surname = "Pellegrini";
            athlete1.age = 30;
            athlete1.sport = "Swimming";
            Console.WriteLine(athlete1.name +" "+ athlete1.surname);
        }
    }
}



