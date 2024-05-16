using System;
using System.Collections.Generic;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos7
    {
        public static void Main(string[] args)
        {

            //Įmonė parduoda žvakes po 1 EUR. Perkant daugiau kaip 1000 vienetų taikoma 3 % nuolaida,
            //daugiau kaip 2000 vienetų- 4 % nuolaida. Parašykite programą, kuri skaičiuos žvakių kainą
            //ir atspausdintų atsakymą kiek žvakių ir kokia kaina perkama.
            //Žvakių kiekį generuokite new Random() funkcija nuo 5 iki 3000.

            Random random = new Random();

            int candlesCount = random.Next(5, 3001);

            float totalCost = candlesCount * 1.0f;  

            float discount = 0;
            if (candlesCount > 1000 && candlesCount <= 2000)
            {
                discount = 0.03f * totalCost;
            }
            else if (candlesCount > 2000)
            {
                discount = 0.04f * totalCost;
            }

            float finalCost = totalCost - discount;

            Console.WriteLine($"Perkama žvakių: {candlesCount} vnt.");
            Console.WriteLine($"Kaina be nuolaidos: {totalCost} EUR");
            Console.WriteLine($"Taikyta nuolaida: {discount} EUR");
            Console.WriteLine($"Galutinė kaina: {finalCost} EUR");
        }

    }
    
}
