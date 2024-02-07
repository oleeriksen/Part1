using System;
namespace Modul1
{
    public class Opgave5
    {
        public void Run()
        {
            Opgavea();
            Opgaveb();
            Opgavec();
            Opgaved();
        }

        void Opgavea() {
            Console.WriteLine("Opgave 5a");
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = i; j < 10; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }
        }

        void Opgaveb()
        {
            Console.WriteLine("Opgave 5b");

            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < i+1; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }
        }

        void Opgavec()
        {
            Console.WriteLine("Opgave 5c");

            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10; j++)
                {
                    if (j >= 9-i)
                        output += "*";
                    else
                        output += " ";
                }
                Console.WriteLine(output);
            }
        }
        void Opgaved()
        {
            Console.WriteLine("Opgave 5d");

            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10; j++)
                {
                    if (j >= i)
                        output += "*";
                    else
                        output += " ";
                }
                Console.WriteLine(output);
            }
        }
    }
}

