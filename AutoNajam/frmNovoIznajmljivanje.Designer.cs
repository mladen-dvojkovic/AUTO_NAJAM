namespace AutoNajam
{
    partial class frmNovoIznajmljivanje
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddAutomobil = new System.Windows.Forms.ComboBox();
            this.ddOsoba = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijemeOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijemeDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(135, 160);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(216, 160);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Automobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osoba";
            // 
            // ddAutomobil
            // 
            this.ddAutomobil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAutomobil.FormattingEnabled = true;
            this.ddAutomobil.Location = new System.Drawing.Point(92, 12);
            this.ddAutomobil.Name = "ddAutomobil";
            this.ddAutomobil.Size = new System.Drawing.Size(199, 21);
            this.ddAutomobil.TabIndex = 4;
            // 
            // ddOsoba
            // 
            this.ddOsoba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddOsoba.FormattingEnabled = true;
            this.ddOsoba.Location = new System.Drawing.Point(92, 39);
            this.ddOsoba.Name = "ddOsoba";
            this.ddOsoba.Size = new System.Drawing.Size(199, 21);
            this.ddOsoba.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrijeme od";
            // 
            // dtpVrijemeOd
            // 
            this.dtpVrijemeOd.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpVrijemeOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVrijemeOd.Location = new System.Drawing.Point(91, 66);
            this.dtpVrijemeOd.Name = "dtpVrijemeOd";
            this.dtpVrijemeOd.Size = new System.Drawing.Size(200, 20);
            this.dtpVrijemeOd.TabIndex = 8;
            this.dtpVrijemeOd.ValueChanged += new System.EventHandler(this.VrijemeChanged);
            // 
            // dtpVrijemeDo
            // 
            this.dtpVrijemeDo.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpVrijemeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVrijemeDo.Location = new System.Drawing.Point(92, 93);
            this.dtpVrijemeDo.Name = "dtpVrijemeDo";
            this.dtpVrijemeDo.Size = new System.Drawing.Size(199, 20);
            this.dtpVrijemeDo.TabIndex = 9;
            this.dtpVrijemeDo.ValueChanged += new System.EventHandler(this.VrijemeChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vrijeme do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cijena (HRK)";
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.SystemColors.Control;
            this.txtCijena.Enabled = false;
            this.txtCijena.Location = new System.Drawing.Point(92, 125);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 12;
            this.txtCijena.Text = "0,00";
            this.txtCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmNovoIznajmljivanje
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(304, 194);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVrijemeDo);
            this.Controls.Add(this.dtpVrijemeOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddOsoba);
            this.Controls.Add(this.ddAutomobil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovoIznajmljivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo iznajmljivanje";
            this.Load += new System.EventHandler(this.frmNovoIznajmljivanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddAutomobil;
        private System.Windows.Forms.ComboBox ddOsoba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijemeOd;
        private System.Windows.Forms.DateTimePicker dtpVrijemeDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCijena;
    }
}