using System;
using System.Collections.Generic;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos8
    {
        public static void Main(string[] args)
        {

            //Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes.
            //Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
            //Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės.
            //Skaičių pridėkite prie jau sugeneruoto laiko.
            //Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.


            Random random = new Random();
            
            int number1 = random.Next(0, 101);
            int number2 = random.Next(0, 101);
            int number3 = random.Next(0, 101);

            float averageAll = (number1 + number2 + number3) / 3.0f;

            int numbersAfterCheck = 0;
            float sumAferCheck = 0;
            float averageAfterCheck = 0;

            if (number1 >= 10 && number1 <= 90)
            {
                numbersAfterCheck++;
                sumAferCheck += number1;
            }

            if (number2 >= 10 && number2 <= 90)
            {
                numbersAfterCheck++;
                sumAferCheck += number2;
            }

            if (number3 >= 10 && number3 <= 90)
            {
                numbersAfterCheck++;
                sumAferCheck += number3;
            }

            if(sumAferCheck != 0)
            {
                averageAfterCheck = sumAferCheck / numbersAfterCheck;
            }


            Console.WriteLine($"Jusu skaiciai: {number1}, {number2}, {number3}");
            Console.WriteLine($"Visų skaičių aritmetinis vidurkis: {Math.Round(averageAll)}");
            Console.WriteLine($"Filtruotų skaičių aritmetinis vidurkis: {Math.Round(averageAfterCheck)}");
        }

    }

}
