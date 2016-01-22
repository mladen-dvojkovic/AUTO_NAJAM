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
    public partial class frmPovratAutomobila : Form
    {
        public frmPovratAutomobila()
        {
            InitializeComponent();
        }

        private void btnPovrat_Click(object sender, EventArgs e)
        {
            if (ddNajam.SelectedValue != null && !String.IsNullOrWhiteSpace(ddNajam.SelectedValue.ToString()))
            {
                int IdNajam = Convert.ToInt32(ddNajam.SelectedValue);
                cNajam.VratiAuto(IdNajam);

                this.Close();
            }
        }

        private void frmPovratAutomobila_Load(object sender, EventArgs e)
        {
            ddNajam.DataSource = cAutomobil.GetZaPovrat();
            ddNajam.ValueMember = "IdNajam";
            ddNajam.DisplayMember = "Najam";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
