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
    public partial class frmIzbrisiNajam : Form
    {
        public frmIzbrisiNajam()
        {
            InitializeComponent();
        }

        private void frmIzbrisiNajam_Load(object sender, EventArgs e)
        {
            listaNajam.DataSource = cAutomobil.GetZaIzbrisati();
            listaNajam.ValueMember = "IdNajam";
            listaNajam.DisplayMember = "Najam";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaNajam.SelectedValue != null && !String.IsNullOrWhiteSpace(listaNajam.SelectedValue.ToString()))
            {
                int IdNajam = Convert.ToInt32(listaNajam.SelectedValue);
                cNajam.IzbrisiNajam(IdNajam);

                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
