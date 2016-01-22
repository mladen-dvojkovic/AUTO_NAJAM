using AutoNajam.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNajam
{
    public partial class frmNoviAutomobil : Form
    {
        public frmNoviAutomobil()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text.Trim();

            if (String.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Naziv automobila je obavezno polje.");
                return;
            }

            if (cAutomobil.AutomobilPostoji(naziv))
            {
                MessageBox.Show("Automobil sa ovim nazivom već postoji.");
                return;
            }

            cAutomobil.DodajAutomobil(naziv, Convert.ToDecimal(numCijenaPoSatu.Value));

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
