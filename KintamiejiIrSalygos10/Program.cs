using System;
using System.Collections.Generic;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos10
    {
        public static void Main(string[] args)
        {

            //Naudokite funkcija new Random(). Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm
            //nuo 1000 iki 9999. Atspausdinkite reikšmes viename stringe, išrūšiuotas
            //nuo didžiausios iki mažiausios, atskirtas tarpais. Naudoti ciklų ir masyvų NEGALIMA.

            Random random = new Random();

            int number1 = random.Next(1000, 10000);
            int number2 = random.Next(1000, 10000);
            int number3 = random.Next(1000, 10000);
            int number4 = random.Next(1000, 10000);
            int number5 = random.Next(1000, 10000);
            int number6 = random.Next(1000, 10000);

            Console.WriteLine($"Sugeneruoti skaičiai: {number1}, {number2}, {number3}, {number4}, {number5}, {number6}");

            int number1Sorted;
            int number2Sorted;
            int number3Sorted;
            int number4Sorted;
            int number5Sorted;
            int number6Sorted;


            number1Sorted = number1;

            if(number2< number1Sorted)
            {
                number1Sorted = number2;
                number2Sorted = number1;
            }
            else
            {
                number2Sorted = number2;
            }

            if(number3 < number1Sorted)
            {
                number3Sorted = number2Sorted;
                number2Sorted = number1Sorted;
                number1Sorted = number3;
            }
            else if (number3 < number2Sorted)
            {
                number3Sorted = number2Sorted;
                number2Sorted = number3;
            }
            else
            {
                number3Sorted = number3;
            }

            if (number4 < number1Sorted)
            {
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number1Sorted;
                number1Sorted = number4;
            }
            else if (number4 < number2Sorted)
            {
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number4;
            }
            else if (number4 < number3Sorted)
            {
                number4Sorted = number3Sorted;
                number3Sorted = number4;
            }
            else
            {
                number4Sorted = number4;
            }

            if(number5 < number1Sorted)
            {
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number1Sorted;
                number1Sorted = number5;
            }
            else if (number5 < number2Sorted)
            {
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number5;
                
            }
            else if (number5 < number3Sorted)
            {
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number5;

            }
            else if (number5 < number4Sorted)
            {
                number5Sorted = number4Sorted;
                number4Sorted = number5;
            }
            else 
            {
                number5Sorted = number5;
            }


            if (number6 < number1Sorted)
            {
                number6Sorted = number5Sorted;
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number1Sorted;
                number1Sorted = number6;
            }
            else if (number6 < number2Sorted)
            {
                number6Sorted = number5Sorted;
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number2Sorted;
                number2Sorted = number6;

            }
            else if (number6 < number3Sorted)
            {
                number6Sorted = number5Sorted;
                number5Sorted = number4Sorted;
                number4Sorted = number3Sorted;
                number3Sorted = number6;

            }
            else if (number6 < number4Sorted)
            {
                number6Sorted = number5Sorted;
                number5Sorted = number4Sorted;
                number4Sorted = number6;

            }
            else if (number6 < number5Sorted)
            {
                number6Sorted = number5Sorted;
                number5Sorted = number6;

            }
            else
            {
                number6Sorted = number6;
            }
            Console.WriteLine($"Surūšiuoti skaičiai: {number6Sorted}, {number5Sorted}, {number4Sorted}, {number3Sorted}, {number2Sorted}, {number1Sorted}");
        }
    }
}
