using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos2
    {
        public static void Main(string[] args)
        {
            //Sukurkite du kintamuosius ir naudodamiesi funkcija new Random()
            //jiems priskirkite atsitiktines reikšmes nuo 0 iki 4. Didesnę reikšmę
            //padalinkite iš mažesnės. Atspausdinkite rezultatą jį suapvalinę iki 2 skaičių po kablelio.

            Random random = new Random();

            int firstNumber = random.Next(0, 5);
            int secondNumber = random.Next(0, 5);

            int bigerNumber = Math.Max(firstNumber, secondNumber);
            int smalerNumer = Math.Min(firstNumber, secondNumber);

            if (smalerNumer != 0)  
            {
                float result = (float)bigerNumber / smalerNumer;
                Console.WriteLine($"Jusu skaiciai: {firstNumber}, {secondNumber}. Didesnis skaicius padalintas iš mažesnio: {result:F2}");
            }
            else
            {
                Console.WriteLine("Dalyba iš nulio negalima.");
            }
            
        }
    }
}