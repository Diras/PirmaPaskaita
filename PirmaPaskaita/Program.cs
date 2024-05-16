using System;

namespace PirmaPaskaita
{
    public class PirmaUzduotis
    {
        public static void Main(string[] args)
        {
            //Sukurkite programą, kuri paprašytų vartotojo įvesti savo vardą
            //ir po to pasveikintų jį išvedant tekstą į konsolę.

            Console.WriteLine("Įveskite vardą... ");
            string name = Console.ReadLine();

            Console.WriteLine($"Sveikas {name}");
        }
    }
}