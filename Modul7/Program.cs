namespace Modul7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        playWithSort();
    }

    static void playWithSort()
    {
        List<Dice> mDices = new List<Dice>();
        for (int i = 0; i < 12; i++)
            if ( i < 6)
                mDices.Add(new MafiaDice());
            else
                mDices.Add(new Dice());
        foreach (Dice d in mDices) d.Roll();

        mDices.Sort();

        Console.WriteLine($"[ {string.Join(",", mDices.Select(d => d.Eyes.ToString()))} ]");
    }


}

