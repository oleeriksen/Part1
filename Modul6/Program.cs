namespace Modul6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello - Modul 6");


        List<int> liste = new();

        liste.RemoveAll((e) => e < 4);
        new Opgave6_2().Run();
    }
}

