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
    public partial class frmIzbrisiAutomobil : Form
    {
        public frmIzbrisiAutomobil()
        {
            InitializeComponent();
        }

        private void frmIzbrisiAutomobil_Load(object sender, EventArgs e)
        {
            listaAutomobili.DataSource = cAutomobil.GetAutomobilZaIzbrisati();
            listaAutomobili.ValueMember = "IdAutomobil";
            listaAutomobili.DisplayMember = "Naziv";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (listaAutomobili.SelectedValue != null && !String.IsNullOrWhiteSpace(listaAutomobili.SelectedValue.ToString()))
            {
                int IdAutomobil = Convert.ToInt32(listaAutomobili.SelectedValue);
                cAutomobil.IzbrisiAutomobil(IdAutomobil);

                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
