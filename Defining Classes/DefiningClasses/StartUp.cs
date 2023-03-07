using DefiningClasses;

    public class StartUp
    {
    private static void Main(string[] args)
    {
       Person person= new Person();

        person.Name = "Misho";
        person.Age = 12;
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
    }

