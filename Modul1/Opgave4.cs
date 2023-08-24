using System;
namespace Modul1
{
    public class Opgave4
    {
        public void Run() {

            Console.WriteLine("Her kommer en løsning af opgave 4");

            int tal1 = ReadInt("Indtast det første tal:");
            int tal2 = ReadInt("Indtast det andet tal:");
            Console.Write("Indtast operator: ");
            string input = Console.ReadLine();
            char op = char.Parse(input); //operator
            int resultat=0;
            bool error = false;
            string errorMessage = "";
            switch (op) {
                case '+':
                    resultat = tal1 + tal2;
                    break;
                case '-':
                    resultat = tal1 - tal2;
                    break;
                case '*':
                    resultat = tal1 * tal2;
                    break;
                case '/':
                    if (tal2 == 0){
                            error = true;
                            errorMessage = "Du må ikke dividere med 0";
                    }
                    break;
                default:
                    error = true;
                    errorMessage = "Ukendt operator";
                    break;
            }
            if (error)
                Console.WriteLine($"Error: {errorMessage}");
            else
                Console.WriteLine(resultat);

        }

        // Udskriver text og indlæser et tal.
        // Returnerer det indlæste som et tal (int).
        int ReadInt(string text) {
            Console.Write(text);
            string input = Console.ReadLine();
            return int.Parse(input);
        }
    }
}

