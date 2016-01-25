namespace AutoNajam
{
    partial class frmPregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIznajmljeno = new System.Windows.Forms.TabPage();
            this.btnIzbrisiNajam = new System.Windows.Forms.Button();
            this.btn_Zatvori = new System.Windows.Forms.Button();
            this.dgvIznajmljeno = new System.Windows.Forms.DataGridView();
            this.btnPovratAutomobila = new System.Windows.Forms.Button();
            this.btnNovoIznajmljivanje = new System.Windows.Forms.Button();
            this.tabOsobe = new System.Windows.Forms.TabPage();
            this.btnNovaOsoba = new System.Windows.Forms.Button();
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.tabAutomobili = new System.Windows.Forms.TabPage();
            this.btnIzbrisiAutomobil = new System.Windows.Forms.Button();
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.btnNoviAutomobil = new System.Windows.Forms.Button();
            this.btn_zatvori2 = new System.Windows.Forms.Button();
            this.btn_zatvori3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabIznajmljeno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljeno)).BeginInit();
            this.tabOsobe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            this.tabAutomobili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabIznajmljeno);
            this.tabControl1.Controls.Add(this.tabOsobe);
            this.tabControl1.Controls.Add(this.tabAutomobili);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 654);
            this.tabControl1.TabIndex = 1;
            // 
            // tabIznajmljeno
            // 
            this.tabIznajmljeno.Controls.Add(this.btnIzbrisiNajam);
            this.tabIznajmljeno.Controls.Add(this.btn_Zatvori);
            this.tabIznajmljeno.Controls.Add(this.dgvIznajmljeno);
            this.tabIznajmljeno.Controls.Add(this.btnPovratAutomobila);
            this.tabIznajmljeno.Controls.Add(this.btnNovoIznajmljivanje);
            this.tabIznajmljeno.Location = new System.Drawing.Point(4, 22);
            this.tabIznajmljeno.Name = "tabIznajmljeno";
            this.tabIznajmljeno.Padding = new System.Windows.Forms.Padding(3);
            this.tabIznajmljeno.Size = new System.Drawing.Size(938, 628);
            this.tabIznajmljeno.TabIndex = 0;
            this.tabIznajmljeno.Text = "Iznajmljeno";
            this.tabIznajmljeno.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiNajam
            // 
            this.btnIzbrisiNajam.Location = new System.Drawing.Point(234, 7);
            this.btnIzbrisiNajam.Name = "btnIzbrisiNajam";
            this.btnIzbrisiNajam.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiNajam.TabIndex = 2;
            this.btnIzbrisiNajam.Text = "Izbriši";
            this.btnIzbrisiNajam.UseVisualStyleBackColor = true;
            this.btnIzbrisiNajam.Click += new System.EventHandler(this.btnIzbrisiNajam_Click);
            // 
            // btn_Zatvori
            // 
            this.btn_Zatvori.Location = new System.Drawing.Point(850, 7);
            this.btn_Zatvori.Name = "btn_Zatvori";
            this.btn_Zatvori.Size = new System.Drawing.Size(75, 23);
            this.btn_Zatvori.TabIndex = 3;
            this.btn_Zatvori.Text = "Zatvori";
            this.btn_Zatvori.UseVisualStyleBackColor = true;
            this.btn_Zatvori.Click += new System.EventHandler(this.btn_Zatvori_Click);
            // 
            // dgvIznajmljeno
            // 
            this.dgvIznajmljeno.AllowUserToAddRows = false;
            this.dgvIznajmljeno.AllowUserToDeleteRows = false;
            this.dgvIznajmljeno.AllowUserToOrderColumns = true;
            this.dgvIznajmljeno.AllowUserToResizeRows = false;
            this.dgvIznajmljeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIznajmljeno.BackgroundColor = System.Drawing.Color.White;
            this.dgvIznajmljeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIznajmljeno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIznajmljeno.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvIznajmljeno.Location = new System.Drawing.Point(7, 36);
            this.dgvIznajmljeno.Name = "dgvIznajmljeno";
            this.dgvIznajmljeno.Size = new System.Drawing.Size(925, 586);
            this.dgvIznajmljeno.TabIndex = 4;
            // 
            // btnPovratAutomobila
            // 
            this.btnPovratAutomobila.Location = new System.Drawing.Point(121, 7);
            this.btnPovratAutomobila.Name = "btnPovratAutomobila";
            this.btnPovratAutomobila.Size = new System.Drawing.Size(106, 23);
            this.btnPovratAutomobila.TabIndex = 1;
            this.btnPovratAutomobila.Text = "Povrat automobila";
            this.btnPovratAutomobila.UseVisualStyleBackColor = true;
            this.btnPovratAutomobila.Click += new System.EventHandler(this.btnPovratAutomobila_Click);
            // 
            // btnNovoIznajmljivanje
            // 
            this.btnNovoIznajmljivanje.Location = new System.Drawing.Point(7, 7);
            this.btnNovoIznajmljivanje.Name = "btnNovoIznajmljivanje";
            this.btnNovoIznajmljivanje.Size = new System.Drawing.Size(108, 23);
            this.btnNovoIznajmljivanje.TabIndex = 0;
            this.btnNovoIznajmljivanje.Text = "Novo iznajmljivanje";
            this.btnNovoIznajmljivanje.UseVisualStyleBackColor = true;
            this.btnNovoIznajmljivanje.Click += new System.EventHandler(this.btnNovoIznajmljivanje_Click);
            // 
            // tabOsobe
            // 
            this.tabOsobe.Controls.Add(this.btn_zatvori2);
            this.tabOsobe.Controls.Add(this.btnNovaOsoba);
            this.tabOsobe.Controls.Add(this.dgvOsobe);
            this.tabOsobe.Location = new System.Drawing.Point(4, 22);
            this.tabOsobe.Name = "tabOsobe";
            this.tabOsobe.Padding = new System.Windows.Forms.Padding(3);
            this.tabOsobe.Size = new System.Drawing.Size(938, 628);
            this.tabOsobe.TabIndex = 1;
            this.tabOsobe.Text = "Osobe";
            this.tabOsobe.UseVisualStyleBackColor = true;
            // 
            // btnNovaOsoba
            // 
            this.btnNovaOsoba.Location = new System.Drawing.Point(7, 7);
            this.btnNovaOsoba.Name = "btnNovaOsoba";
            this.btnNovaOsoba.Size = new System.Drawing.Size(79, 23);
            this.btnNovaOsoba.TabIndex = 2;
            this.btnNovaOsoba.Text = "Nova osoba";
            this.btnNovaOsoba.UseVisualStyleBackColor = true;
            this.btnNovaOsoba.Click += new System.EventHandler(this.btnNovaOsoba_Click);
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.AllowUserToAddRows = false;
            this.dgvOsobe.AllowUserToDeleteRows = false;
            this.dgvOsobe.AllowUserToOrderColumns = true;
            this.dgvOsobe.AllowUserToResizeRows = false;
            this.dgvOsobe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOsobe.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOsobe.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOsobe.Location = new System.Drawing.Point(7, 36);
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.ShowEditingIcon = false;
            this.dgvOsobe.Size = new System.Drawing.Size(925, 586);
            this.dgvOsobe.TabIndex = 3;
            // 
            // tabAutomobili
            // 
            this.tabAutomobili.Controls.Add(this.btn_zatvori3);
            this.tabAutomobili.Controls.Add(this.btnIzbrisiAutomobil);
            this.tabAutomobili.Controls.Add(this.dgvAutomobili);
            this.tabAutomobili.Controls.Add(this.btnNoviAutomobil);
            this.tabAutomobili.Location = new System.Drawing.Point(4, 22);
            this.tabAutomobili.Name = "tabAutomobili";
            this.tabAutomobili.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomobili.Size = new System.Drawing.Size(938, 628);
            this.tabAutomobili.TabIndex = 2;
            this.tabAutomobili.Text = "Automobili";
            this.tabAutomobili.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiAutomobil
            // 
            this.btnIzbrisiAutomobil.Location = new System.Drawing.Point(102, 6);
            this.btnIzbrisiAutomobil.Name = "btnIzbrisiAutomobil";
            this.btnIzbrisiAutomobil.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiAutomobil.TabIndex = 3;
            this.btnIzbrisiAutomobil.Text = "Izbriši";
            this.btnIzbrisiAutomobil.UseVisualStyleBackColor = true;
            this.btnIzbrisiAutomobil.Click += new System.EventHandler(this.btnIzbrisiAutomobil_Click);
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToAddRows = false;
            this.dgvAutomobili.AllowUserToDeleteRows = false;
            this.dgvAutomobili.AllowUserToOrderColumns = true;
            this.dgvAutomobili.AllowUserToResizeRows = false;
            this.dgvAutomobili.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutomobili.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAutomobili.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAutomobili.Location = new System.Drawing.Point(7, 36);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.Size = new System.Drawing.Size(925, 586);
            this.dgvAutomobili.TabIndex = 6;
            // 
            // btnNoviAutomobil
            // 
            this.btnNoviAutomobil.Location = new System.Drawing.Point(7, 7);
            this.btnNoviAutomobil.Name = "btnNoviAutomobil";
            this.btnNoviAutomobil.Size = new System.Drawing.Size(89, 23);
            this.btnNoviAutomobil.TabIndex = 2;
            this.btnNoviAutomobil.Text = "Novi automobil";
            this.btnNoviAutomobil.UseVisualStyleBackColor = true;
            this.btnNoviAutomobil.Click += new System.EventHandler(this.btnNoviAutomobil_Click);
            // 
            // btn_zatvori2
            // 
            this.btn_zatvori2.Location = new System.Drawing.Point(851, 6);
            this.btn_zatvori2.Name = "btn_zatvori2";
            this.btn_zatvori2.Size = new System.Drawing.Size(75, 23);
            this.btn_zatvori2.TabIndex = 4;
            this.btn_zatvori2.Text = "Zatvori";
            this.btn_zatvori2.UseVisualStyleBackColor = true;
            this.btn_zatvori2.Click += new System.EventHandler(this.btn_zatvori2_Click);
            // 
            // btn_zatvori3
            // 
            this.btn_zatvori3.Location = new System.Drawing.Point(857, 6);
            this.btn_zatvori3.Name = "btn_zatvori3";
            this.btn_zatvori3.Size = new System.Drawing.Size(75, 23);
            this.btn_zatvori3.TabIndex = 7;
            this.btn_zatvori3.Text = "Zatvori";
            this.btn_zatvori3.UseVisualStyleBackColor = true;
            this.btn_zatvori3.Click += new System.EventHandler(this.btn_zatvori3_Click);
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 678);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPregled";
            this.Text = "Auto najam";
            this.Load += new System.EventHandler(this.frmPregled_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabIznajmljeno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIznajmljeno)).EndInit();
            this.tabOsobe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            this.tabAutomobili.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIznajmljeno;
        private System.Windows.Forms.DataGridView dgvIznajmljeno;
        private System.Windows.Forms.Button btnPovratAutomobila;
        private System.Windows.Forms.Button btnNovoIznajmljivanje;
        private System.Windows.Forms.TabPage tabOsobe;
        private System.Windows.Forms.TabPage tabAutomobili;
        private System.Windows.Forms.Button btnNovaOsoba;
        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Button btnNoviAutomobil;
        private System.Windows.Forms.Button btn_Zatvori;
        private System.Windows.Forms.Button btnIzbrisiNajam;
        private System.Windows.Forms.Button btnIzbrisiAutomobil;
        private System.Windows.Forms.Button btn_zatvori2;
        private System.Windows.Forms.Button btn_zatvori3;
    }
}

