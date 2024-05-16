using System;

namespace PirmaPaskaita
{
    public class KintamiejiIrSalygos1
    {
        public static void Main(string[] args)
        {
            //Sukurkite 4 kintamuosius, kurie saugotų jūsų vardą, pavardę, gimimo metus
            //ir šiuos metus (nebūtinai tikrus). Parašykite kodą, kuris pagal gimimo metus
            //paskaičiuotų jūsų amžių ir naudodamas vardo ir pavardės kintamuosius atspausdintų tokį sakinį :
            //"Aš esu Vardenis Pavardenis. Man yra XX metai(ų)".

            string name = "Ernestas";
            string surname = "Rachmangulovas";
            int birthYear = 1990;
            int year = 2024;

            Console.WriteLine($"Aš esu {name} {surname}. Man yra {year - birthYear} metai(ų)");
        }
    }
}