using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Interfejsy
{
    internal class Program
    {
        private class Krzeslo : IComparable
        {
            public int Wysokosc;
            public int Waga;
            public string Producent;

            public int CompareTo(object obj)
            {
                int naszaliczbaZnakow = Producent.Length;

                int inneKrzeslo = ((Krzeslo)obj).Producent.Length;

                return naszaliczbaZnakow - inneKrzeslo;
            }
        }

        private static void Main(string[] args)
        {
            int[] liczby = { 4, 7, 3, 1, 9, 5 };
            Array.Sort(liczby);

            string napis = string.Join(" ", liczby);
            Console.WriteLine(napis);

            Krzeslo[] krzesla = new Krzeslo[3]
            {
                new Krzeslo(){ Waga=30,Wysokosc=50,Producent="xx"},
                new Krzeslo(){ Waga=20,Wysokosc=40,Producent="yyyy"},
                new Krzeslo(){ Waga=40,Wysokosc=20,Producent="z"},
            };

            Array.Sort(krzesla);

            foreach (var k in krzesla)
            {
                Console.WriteLine(k.Producent);
            }

            Console.ReadKey();
        }
    }
}