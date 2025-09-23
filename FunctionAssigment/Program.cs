using System.Reflection;
using System.Xml.Linq;

namespace FunctionAssigment
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /// <summary>
            /// Käyttäjältä kysytään nimeä ja ikää. Tiedot tulostetaan konsoliin.
            /// </summary>
            /// <returns>Palauttaa validin syötteen</returns>
            string name = getname();
            int age = getage();

            /// Funktio tarkistaa onko käyttäjä täysi-ikäinen (18v) ja tulostaa asian konsoliin.
            bool adult = isadult(age);
            printinfo(name, age);

            if (adult)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");

            }
            
            comparename(name, "Jorma");

        }


        static string getname()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }
        static int getage()
        {

            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }

        }
        static void printinfo(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");

        }
        static bool isadult(int age)
        {
            return age >= 18;
        }
        static void comparename(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
            }
            if (name.Equals(compareTo))
            {
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
            }










        }
    }
}
