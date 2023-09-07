namespace Modul4;

class Program
{
    static void Main(string[] args)
    {
        new Opgave4_1().Run();
    }

    void playWithDice() {
        Console.WriteLine("Hello, World!");
        Dice d = new Dice();
        for (int i = 0; i < 10; i++)
        {
            d.Roll();
            int eyes = d.Eyes;
            Console.WriteLine($"{eyes}");

        }
    }

   
}

