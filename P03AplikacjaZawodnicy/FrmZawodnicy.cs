using System;
using System.IO;
using System.Windows.Forms;

namespace P03AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dane = File.ReadAllLines(ofd.FileName);

                //lbDane.Items.Clear();
                //foreach (var w in dane)
                //    lbDane.Items.Add(w);

                ManagerZawodnikow mz = new ManagerZawodnikow(txtKraj.Text);
                Zawodnik[] zawodnicy = mz.Wczytaj(dane);

                lbDane.DataSource = zawodnicy;
                lbDane.DisplayMember = "WidoczneDane";

                lblLicznaZaimportowanychDanych.Text = Convert.ToString(zawodnicy.Length);
            }
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczone = (Zawodnik)lbDane.SelectedItem;
        }
    }
}