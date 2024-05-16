using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos3
    {
        public static void Main(string[] args)
        {
            //Naudokite funkcija new Random(). Sukurkite tris kintamuosius ir
            //naudodamiesi funkcija new Random() jiems priskirkite atsitiktines
            //reikšmes nuo 0 iki 25. Raskite ir atspausdinkite kintąmąjį turintį vidurinę reikšmę.

            Random random = new Random();

            int firstNumber = random.Next(0, 26);
            int secondNumber = random.Next(0, 26);
            int thirdNumber = random.Next(0, 26);

            int vidurineReiksme;

            // Tikriname sąlygas, kad nustatytume vidurinę reikšmę
            if ((firstNumber <= secondNumber && secondNumber <= thirdNumber) || (thirdNumber <= secondNumber && secondNumber <= firstNumber))
            {
                vidurineReiksme = secondNumber;
            }
            else if ((secondNumber <= firstNumber && firstNumber <= thirdNumber) || (thirdNumber <= firstNumber && firstNumber <= secondNumber))
            {
                vidurineReiksme = firstNumber;
            }
            else
            {
                vidurineReiksme = thirdNumber;
            }

            Console.WriteLine($"Jusu skaiciai: {firstNumber}, {secondNumber}, {thirdNumber}. Vidurinė reikšmė: {vidurineReiksme}");

        }
    }
}