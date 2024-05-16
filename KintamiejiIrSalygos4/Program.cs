using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos4
    {
        public static void Main(string[] args)
        {
            //Įvedami skaičiai - a, b, c – kraštinių ilgiai, trys kintamieji
            //(naudojame int) (naudokite new Random() funkcija nuo 1 iki 10).
            //Parašykite C# programą, kuri nustatytų, ar galima sudaryti trikampį ir atsakymą atspausdintų.

            Random random = new Random();

            int firstNumber = random.Next(0, 10);
            int secondNumber = random.Next(0, 10);
            int thirdNumber = random.Next(0, 10);

            if (firstNumber + secondNumber > thirdNumber && firstNumber + thirdNumber > secondNumber && secondNumber + thirdNumber > firstNumber)
            {
                Console.WriteLine($"Jusu skaiciai: {firstNumber}, {secondNumber}, {thirdNumber}. Iš šių kraštinių galima sudaryti trikampį.");
            }
            else
            {
                Console.WriteLine($"Jusu skaiciai: {firstNumber}, {secondNumber}, {thirdNumber}. Iš šių kraštinių negalima sudaryti trikampio.");
            }

        }
    }
}