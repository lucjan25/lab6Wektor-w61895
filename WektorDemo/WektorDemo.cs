using System;
using WektorBiblioteka;
using System.Collections.Generic;

namespace WektorDemo
{
    class WektorDemo
    {
        static void Main(string[] args)
        {
            Wektor w1 = new Wektor(1, 2, 3);
            Wektor w2 = new Wektor(5, 1, 6);

            Console.WriteLine(w1.Dlugosc);
            Console.WriteLine(w1.WX);
            Console.WriteLine(w1.WY);
            Console.WriteLine(w1.WZ);
            Console.WriteLine(w2.Dlugosc);
            Console.WriteLine(w2.WX);
            Console.WriteLine(w2.WY);
            Console.WriteLine(w2.WZ);
            Console.WriteLine(-w1);
            var lw = new List<(double, Wektor)>
            {
                (5, new Wektor(7,2,12)),
                (2, new Wektor(4,8,2)),
                (9, new Wektor(75,42,52))
            };
            Wektor Wynik = Wektor.Srodek(lw);
            Console.WriteLine(w2.WX);
            Console.WriteLine(w2.WY);
            Console.WriteLine(w2.WZ);
        }
    }
}
