using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varijable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli broj i jedan decimalni broj, odvojeni ramakom");

            string unos = Console.ReadLine();

            string[] razmak = unos.Split(' ');

            int a = int.Parse(razmak[0]);
            double b = double.Parse(razmak[1]);

            int x = a * 2;
            double y = b * 2;

            Console.WriteLine($"Dvostruka vrijednost prvog(cijelog) broja je: {x}");
            Console.WriteLine($"Dvostruka vrijednost drugog(decimalnog) broja je: {y}");

            Console.ReadKey();
        }
    }
}
