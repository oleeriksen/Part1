namespace Modul4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Modul 4");
        new Opgave4_2().Run();
    }

    static void f() {

        string[] a = {"danske kroner", "euro", "pund(engelske"};


        foreach (string valuta in a)
        {
            Console.WriteLine(valuta);
        }

    }

    static void g() {

        string[] a = new string[3];
        a[0] = "danske kroner";
        a[1] = "euro";
        a[2] = "pund(engelske)";


        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }


    }
}

