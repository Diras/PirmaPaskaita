using System;

namespace PirmaPaskaita
{
    public class KetvirtaUzduotis
    {
        public static void Main(string[] args)
        {
            //Sukurkite programą, kuri leistų vartotojui įvesti temperatūrą Farenheito skalėje
            //ir paskaičiuotų bei atspausdintų temperatūrą Celsijaus skalėje.

            Console.WriteLine("Įveskite temperatūrą Farenheito skalėje... ");
            float fahrenheit = int.Parse(Console.ReadLine());

            float celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatūrą Celsijaus skalėje = {celsius:F2} laipsniu");
        }
    }
}