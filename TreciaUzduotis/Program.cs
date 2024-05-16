using System;

namespace PirmaPaskaita
{
    public class TreciaUzduotis
    {
        public static void Main(string[] args)
        {
            //Sukurkite programą, kuri paprašytų vartotojo įvesti savo gimimo metus
            //ir apskaičiuotų bei atspausdintų vartotojo amžių.

            Console.WriteLine("Įveskite gimimo metus... ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"Jūsų amžius = {DateTime.Now.Year - birthYear} metai");
        }
    }
}