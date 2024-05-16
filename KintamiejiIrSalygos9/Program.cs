using System;
using System.Collections.Generic;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos9
    {
        public static void Main(string[] args)
        {

            //Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes.
            //Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
            //Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės.
            //Skaičių pridėkite prie jau sugeneruoto laiko.
            //Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.


            Random random = new Random();

            int hours = random.Next(0, 24);
            int minutes = random.Next(0, 60);
            int seconds = random.Next(0, 60);

            int randomSeconds = random.Next(0, 301);

            Console.WriteLine($"Laikas prieš pridėjimą: {hours:00}:{minutes:00}:{seconds:00}");

            seconds += randomSeconds;

            if (seconds >= 60)
            {
                int additionalMinutes = seconds / 60;
                seconds %= 60;
                minutes += additionalMinutes;

                if (minutes >= 60)
                {
                    int additionalHours = minutes / 60;
                    minutes %= 60;
                    hours = (hours + additionalHours) % 24;
                }
            }

            Console.WriteLine($"Laikas po pridėjimo: {hours:00}:{minutes:00}:{seconds:00}");
            Console.WriteLine($"Pridėtos sekundės: {randomSeconds}");
        }

    }

}
