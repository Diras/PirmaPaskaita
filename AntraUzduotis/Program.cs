using System;

namespace PirmaPaskaita
{
    public class AntraUzduotis
    {
        public static void Main(string[] args)
        {
            //Sukurkite programą, kuri leistų vartotojui įvesti du skaičius
            //ir atspausdintų jų sumą, skirtumą, sandaugą ir dalmenį.

            Console.WriteLine("Įveskite pirmą skaičių... ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių... ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma = {number1 + number2}");
            Console.WriteLine($"Skirtumas = {number1 - number2}");
            Console.WriteLine($"Sandauga = {number1 * number2}");
            Console.WriteLine($"Dalmuo = {(float)number1 / number2}");
        }
    }
}