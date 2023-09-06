namespace Modul5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<string> names = new List<string>
        {
            "Bruce",
            "Alfred",
            "Tim",
            "Richard"
        };

        names.ForEach(name => Console.WriteLine(name));

        Console.WriteLine("[" + string.Join(",", names) + "]");

        Console.WriteLine("Og dem med et e i...");
        names = names.FindAll(name => name.Contains('e'));
        names.ForEach(name => Console.WriteLine(name));

        Console.WriteLine(names.Aggregate((x, y) => x + ", " + y));

    }
}

