using System;
using System.Collections.Generic;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos11
    {
        public static void Main(string[] args)
        {

            //Savaitės dienų atvaizdavimas.
            //Sukurkite programą, kuri paprašytų vartotojo įvesti savaitės dienos numerį(1 iki 7)
            //ir pagal tai atspausdintų dienos pavadinimą naudojant switch sakinį.

            Console.WriteLine("Įveskite savaitės dienos numerį (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Pirmadienis";
                    break;
                case 2:
                    dayName = "Antradienis";
                    break;
                case 3:
                    dayName = "Trečiadienis";
                    break;
                case 4:
                    dayName = "Ketvirtadienis";
                    break;
                case 5:
                    dayName = "Penktadienis";
                    break;
                case 6:
                    dayName = "Šeštadienis";
                    break;
                case 7:
                    dayName = "Sekmadienis";
                    break;
                default:
                    dayName = "Neteisingas dienos numeris";
                    break;
            }

            Console.WriteLine($"Jūsų pasirinkta savaitės diena: {dayName}");
        }

    }

}
