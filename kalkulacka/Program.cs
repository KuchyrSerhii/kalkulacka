using System;

namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj jsem tvoje kalkulačka");
            Console.WriteLine("Zadejte první číslo");
            double prvni_cislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte druhý číslo");
            double druhy_cislo = Convert.ToDouble(Console.ReadLine());
            double suma = prvni_cislo + druhy_cislo;
            double rozdil = prvni_cislo - druhy_cislo;
            double kraceni = prvni_cislo * druhy_cislo;
            double deleni =  prvni_cislo / druhy_cislo;
            Console.WriteLine(suma + " suma");
            Console.WriteLine(rozdil + " rozdíl");
            Console.WriteLine(kraceni + " kracení");
            Console.WriteLine(deleni + " dělení");
            Console.ReadKey();
            
        }
    }
}
