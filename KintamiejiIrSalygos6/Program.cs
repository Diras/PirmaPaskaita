using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos6
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int firstNumber = random.Next(-10, 11);
            int secondNumber = random.Next(-10, 11);
            int thirdNumber = random.Next(-10, 11);

            string numbersLessThan0 = "";
            string numbersIs0 = "";
            string numbersMoreThan0 = "";

            if (firstNumber < 0)
            {
                numbersLessThan0 += firstNumber.ToString();
                numbersLessThan0 += ", ";
            }
            else if (firstNumber == 0)
            {
                numbersIs0 += firstNumber.ToString();
                numbersIs0 += ", ";
            }
            else
            {
                numbersMoreThan0 += firstNumber.ToString();
                numbersMoreThan0 += ", ";
            }

            if (secondNumber < 0)
            {
                numbersLessThan0 += secondNumber.ToString();
                numbersLessThan0 += ", ";
            }
            else if (secondNumber == 0)
            {
                numbersIs0 += secondNumber.ToString();
                numbersIs0 += ", ";
            }
            else
            {
                numbersMoreThan0 += secondNumber.ToString();
                numbersMoreThan0 += ", ";
            }

            if (thirdNumber < 0)
            {
                numbersLessThan0 += thirdNumber.ToString();
                numbersLessThan0 += ", ";
            }
            else if (thirdNumber == 0)
            {
                numbersIs0 += thirdNumber.ToString();
                numbersIs0 += ", ";
            }
            else
            {
                numbersMoreThan0 += thirdNumber.ToString();
                numbersMoreThan0 += ", ";
            }

            if(numbersLessThan0 != "")
                numbersLessThan0 = numbersLessThan0.Remove(numbersLessThan0.Length - 2);
            if (numbersIs0 != "")
                numbersIs0 = numbersIs0.Remove(numbersIs0.Length - 2);
            if (numbersMoreThan0 != "")
                numbersMoreThan0 = numbersMoreThan0.Remove(numbersMoreThan0.Length - 2);

            Console.WriteLine($"[{numbersLessThan0}], ({numbersIs0}), {{{numbersMoreThan0}}}");
        }
    }
}
