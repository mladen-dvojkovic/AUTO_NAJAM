namespace AutoNajam
{
    partial class frmPovratAutomobila
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
            this.btnPovrat = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddNajam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPovrat
            // 
            this.btnPovrat.Location = new System.Drawing.Point(272, 43);
            this.btnPovrat.Name = "btnPovrat";
            this.btnPovrat.Size = new System.Drawing.Size(75, 23);
            this.btnPovrat.TabIndex = 0;
            this.btnPovrat.Text = "Izvrši povrat";
            this.btnPovrat.UseVisualStyleBackColor = true;
            this.btnPovrat.Click += new System.EventHandler(this.btnPovrat_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(353, 43);
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
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Najam";
            // 
            // ddNajam
            // 
            this.ddNajam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddNajam.FormattingEnabled = true;
            this.ddNajam.Location = new System.Drawing.Point(55, 16);
            this.ddNajam.Name = "ddNajam";
            this.ddNajam.Size = new System.Drawing.Size(373, 21);
            this.ddNajam.TabIndex = 3;
            // 
            // frmPovratAutomobila
            // 
            this.AcceptButton = this.btnPovrat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(440, 78);
            this.Controls.Add(this.ddNajam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPovrat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPovratAutomobila";
            this.Text = "Povrat automobila";
            this.Load += new System.EventHandler(this.frmPovratAutomobila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovrat;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddNajam;
    }
}