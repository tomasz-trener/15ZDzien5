using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02KomunikacjaPomiedzyFormularzami
{
    public partial class FrmStartowy : Form
    {
        private FrmSzczegoly fs;

        // skrótowy sposób tworzenia GET
        public TextBox TxtDane => this.txtDane;

        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            fs = new FrmSzczegoly(this);
            fs.Show();
        }

        private void FrmStartowy_Load(object sender, EventArgs e)
        {
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            fs.TxtDane.Text = txtDane.Text;
        }
    }
}