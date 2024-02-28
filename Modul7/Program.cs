namespace Modul7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, modul 7");
        Super[] s = { new SubA(), new SubB(), new Super() };

        foreach (Super anObject in s)
            anObject.F();
    }
}

