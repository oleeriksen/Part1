namespace Modul7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        playWithSort();
    }

    static void playWithSort() {
        List<Dice> mDices = new List<Dice>();
        for (int i = 0; i < 10; i++)
            mDices.Add(new Dice());
        foreach (Dice d in mDices) d.Roll();

        mDices.Sort();

        foreach (Dice d in mDices)
            Console.WriteLine(d.Eyes);
    }


}

