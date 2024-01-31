using System;
namespace Modul1
{
    public class Opgave5
    {
        public void Run()
        {
            Opgaveb(); 
        }

        void Opgavea() {
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
    }
}

