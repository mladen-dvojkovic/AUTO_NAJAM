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
    public partial class frmNovoIznajmljivanje : Form
    {
        public frmNovoIznajmljivanje()
        {
            InitializeComponent();
        }

        private void frmNovoIznajmljivanje_Load(object sender, EventArgs e)
        {
            ddAutomobil.DataSource = cAutomobil.GetAutomobili();
            ddAutomobil.DisplayMember = "Naziv";
            ddAutomobil.ValueMember = "IdAutomobil";

            ddOsoba.DataSource = cOsoba.GetOsobeForDropdown();
            ddOsoba.DisplayMember = "ImePrezime";
            ddOsoba.ValueMember = "IdOsoba";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (dtpVrijemeOd.Value > dtpVrijemeDo.Value)
            {
                MessageBox.Show("Vrijeme od nemože biti veće od vrijeme do.");
                return;
            }

            if (!cNajam.IsMogucNajam(Convert.ToInt32(ddAutomobil.SelectedValue), dtpVrijemeOd.Value, dtpVrijemeDo.Value))
            {
                MessageBox.Show("Najam odabranog automobila u odabranom periodu nije moguć");
                return;
            }

            decimal cijena = cAutomobil.GetCijena(Convert.ToInt32(ddAutomobil.SelectedValue), dtpVrijemeOd.Value, dtpVrijemeDo.Value);
            cNajam.IznajmiAuto(Convert.ToInt32(ddAutomobil.SelectedValue), Convert.ToInt32(ddOsoba.SelectedValue), dtpVrijemeOd.Value, dtpVrijemeDo.Value, cijena);

            this.Close();
        }

        private void VrijemeChanged(object sender, EventArgs e)
        {
            if (dtpVrijemeOd.Value > dtpVrijemeDo.Value)
            {
                txtCijena.Text = "0,00";
            }
            else
            {
                txtCijena.Text = cAutomobil.GetCijena(Convert.ToInt32(ddAutomobil.SelectedValue), dtpVrijemeOd.Value, dtpVrijemeDo.Value).ToString("N2");
            }
        }
    }
}
