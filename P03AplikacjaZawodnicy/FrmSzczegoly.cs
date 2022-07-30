using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        private Zawodnik zawodnik;
        private ManagerZawodnikow mz;
        private FrmZawodnicy frmZawodnicy;

        public FrmSzczegoly(Zawodnik zawodnik, ManagerZawodnikow mz, FrmZawodnicy frmZawodnicy)

        {
            InitializeComponent();

            this.zawodnik = zawodnik;
            this.mz = mz;
            this.frmZawodnicy = frmZawodnicy;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUr;
            numWaga.Value = zawodnik.Waga;
            numWzrost.Value = zawodnik.Wzrost;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUr = dtpDataUr.Value;
            zawodnik.Waga = Convert.ToInt32(numWaga.Value);
            zawodnik.Wzrost = Convert.ToInt32(numWzrost.Value);

            mz.Edytuj(zawodnik);
            mz.Zapisz();

            frmZawodnicy.Odswiez(mz.WczytaniZawodnicy);
        }
    }
}