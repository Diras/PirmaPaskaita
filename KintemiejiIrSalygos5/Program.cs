using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos5
    {
        public static void Main(string[] args)
        {
            //Sukurkite keturis kintamuosius ir new Random() funkcija sugeneruokite jiems
            //reikšmes nuo 0 iki 2.Suskaičiuokite kiek yra nulių, vienetų ir dvejetų.
            //(sprendimui masyvo nenaudoti).

            Random random = new Random();

            int firstNumber = random.Next(0, 3);
            int secondNumber = random.Next(0, 3);
            int thirdNumber = random.Next(0, 3);
            int forthNumber = random.Next(0, 3);

            Console.WriteLine($"Sugeneruoti skaičiai: {firstNumber}, {secondNumber}, {thirdNumber}, {forthNumber}");

            int countZeroes = 0;
            int countOnes = 0;
            int countTwos = 0;

            switch (firstNumber)
            {
                case 0:
                    countZeroes++;
                    break;
                case 1:
                    countOnes++;
                    break;
                case 2:
                    countTwos++;
                    break;
            }

            switch (secondNumber)
            {
                case 0:
                    countZeroes++;
                    break;
                case 1:
                    countOnes++;
                    break;
                case 2:
                    countTwos++;
                    break;
            }

            switch (thirdNumber)
            {
                case 0:
                    countZeroes++;
                    break;
                case 1:
                    countOnes++;
                    break;
                case 2:
                    countTwos++;
                    break;
            }

            switch (forthNumber)
            {
                case 0:
                    countZeroes++;
                    break;
                case 1:
                    countOnes++;
                    break;
                case 2:
                    countTwos++;
                    break;
            }

            Console.WriteLine($"Nulių: {countZeroes}");
            Console.WriteLine($"Vienetų: {countOnes}");
            Console.WriteLine($"Dvejetų: {countTwos}");
        }
    }
}