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
    public partial class frmPregled : Form
    {
        public frmPregled()
        {
            InitializeComponent();
        }

        private void frmPregled_Load(object sender, EventArgs e)
        {
            dgvIznajmljeno.DataSource = cNajam.GetNajam();
            dgvOsobe.DataSource = cOsoba.GetOsobe();
            dgvAutomobili.DataSource = cAutomobil.GetAutomobili();

            btnPovratAutomobila.Enabled = (cNajam.BrojAutomobilaUNajmu() > 0);
        }

        /* Nova osoba */
        private void btnNovaOsoba_Click(object sender, EventArgs e)
        {
            frmNovaOsoba frm = new frmNovaOsoba();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvIznajmljeno.DataSource = cNajam.GetNajam();
            dgvOsobe.DataSource = cOsoba.GetOsobe();
            dgvAutomobili.DataSource = cAutomobil.GetAutomobili();

            btnPovratAutomobila.Enabled = (cNajam.BrojAutomobilaUNajmu() > 0);
        }

        /* Novi automobil */
        private void btnNoviAutomobil_Click(object sender, EventArgs e)
        {
            frmNoviAutomobil frm = new frmNoviAutomobil();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        /* Novo iznajmljivanje */
        private void btnNovoIznajmljivanje_Click(object sender, EventArgs e)
        {
            frmNovoIznajmljivanje frm = new frmNovoIznajmljivanje();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        /* Povratak automobila u stanje najma*/
        private void btnPovratAutomobila_Click(object sender, EventArgs e)
        {
            frmPovratAutomobila frm = new frmPovratAutomobila();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        /* Izbriši najam */
        private void btnIzbrisiNajam_Click(object sender, EventArgs e)
        {
            frmIzbrisiNajam frm = new frmIzbrisiNajam();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        private void btn_Zatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Izbriši automobil */
        private void btnIzbrisiAutomobil_Click(object sender, EventArgs e)
        {
            frmIzbrisiAutomobil frm = new frmIzbrisiAutomobil();
            frm.FormClosing += frm_FormClosing;
            frm.ShowDialog();
        }

        private void btn_zatvori2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_zatvori3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}