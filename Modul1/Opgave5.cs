using System;
namespace Modul1
{
    public class Opgave5
    {
        public void Run() {
            CaseC();
            /*
             for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            } */
        }

        void CaseA() {
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10-i; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(output);
            }
        }

        void CaseB()
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

        void CaseC()
        {
            for (int i = 0; i < 10; i++)
            {
                string output = "";
                for (int j = 0; j < 10; j++)
                {
                    if (j < 9 - i)
                        output += " ";
                    else
                        output += "*";
                }
                Console.WriteLine(output);
            }
        }
    }
}

