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
    public partial class frmNovaOsoba : Form
    {
        public frmNovaOsoba()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string adresa = txtAdresa.Text.Trim();
            string email = txtEmail.Text.Trim();
            string napomena = txtNapomena.Text.Trim();

            if (String.IsNullOrWhiteSpace(ime) || String.IsNullOrWhiteSpace(prezime))
            {
                MessageBox.Show("Ime i prezime su obavezna polja.", "POGREŠKA!");
                return;
            }

            if (cOsoba.OsobaPostoji(ime, prezime))
            {
                MessageBox.Show("Osoba sa ovim imenom i prezimenom već postoji.");
                return;
            }

            cOsoba.DodajOsobu(ime, prezime, adresa, email, napomena);

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
