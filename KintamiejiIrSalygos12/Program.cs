using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite reikšmę (int arba string): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int result = number * 11;
                Console.WriteLine($"Gautas rezultatas: {result}");
            }
            else if (input.GetType() == typeof(string))
            {
                string modifiedString = $"#{input}#";
                Console.WriteLine($"Gautas rezultatas: {modifiedString}");
            }
            else
            {
                Console.WriteLine("Netinkamas duomenų tipas. Įveskite int arba string.");
            }
        }
    }
}
