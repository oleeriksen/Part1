namespace Modul5;

class Program
{
    static void Main(string[] args)
    {
        TryPlayWithList();

    }

    static void TryPlayWithList() {
        Console.WriteLine("Hello, World!");
        List<string> names = new List<string>
        {
            "Bruce",
            "Alfred",
            "Tim",
            "Richard"
        };
        
        names.ForEach(name => Console.WriteLine(name));

        names.Add("Peter");
        names.Add("Jens");

        Console.WriteLine("[" + string.Join(",", names) + "]");

        Console.WriteLine("Og dem med et e i og som ender på d");
        names = names.FindAll(name => name.Contains('e') && name.EndsWith('d')); 
        names.ForEach(name => Console.WriteLine(name));

        //Console.WriteLine(names.Aggregate((x, y) => x + ", " + y));
    }
}

