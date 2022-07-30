using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    public class Zawodnik : IComparable
    {
        //id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga

        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko { get; set; }
        public string Kraj;
        public DateTime DataUr;
        public int Wzrost;
        public int Waga;

        public string WidoczneDane
        {
            get
            {
                return Imie + " " + Nazwisko + " " + Kraj;
            }
        }

        public string Wiersz
        {
            get
            {
                return $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUr.ToString("yyyy-MM-dd")};{Wzrost};{Waga}";
            }
        }

        public Zawodnik()
        {
        }

        public Zawodnik(string[] komorki)
        {
            Id_zawodnika = Convert.ToInt32(komorki[0]);
            Id_trenera = Convert.ToInt32(komorki[1]);
            Imie = komorki[2];
            Nazwisko = komorki[3];
            Kraj = komorki[4];
            DataUr = Convert.ToDateTime(komorki[5]);
            Wzrost = Convert.ToInt32(komorki[6]);
            Waga = Convert.ToInt32(komorki[7]);
        }

        public int CompareTo(object obj)
        {
            Zawodnik z = (Zawodnik)obj;

            return Wzrost - z.Wzrost;
        }
    }
}