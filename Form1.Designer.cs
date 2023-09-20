namespace AplikasiLatihanTiga3
{
    partial class Form1
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
            this.Nama = new System.Windows.Forms.Label();
            this.txtPendidikan = new System.Windows.Forms.Label();
            this.txtpekerjaan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(23, 35);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(35, 13);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            // 
            // txtPendidikan
            // 
            this.txtPendidikan.AutoSize = true;
            this.txtPendidikan.Location = new System.Drawing.Point(22, 76);
            this.txtPendidikan.Name = "txtPendidikan";
            this.txtPendidikan.Size = new System.Drawing.Size(60, 13);
            this.txtPendidikan.TabIndex = 1;
            this.txtPendidikan.Text = "Pendidikan";
            // 
            // txtpekerjaan
            // 
            this.txtpekerjaan.AutoSize = true;
            this.txtpekerjaan.Location = new System.Drawing.Point(23, 129);
            this.txtpekerjaan.Name = "txtpekerjaan";
            this.txtpekerjaan.Size = new System.Drawing.Size(55, 13);
            this.txtpekerjaan.TabIndex = 2;
            this.txtpekerjaan.Text = "Pekerjaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(88, 32);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(256, 20);
            this.txtNama.TabIndex = 3;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(88, 129);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(256, 121);
            this.lstPekerjaan.TabIndex = 4;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "PascaSarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(88, 76);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(256, 21);
            this.cmbPendidikan.TabIndex = 5;
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(26, 277);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(318, 20);
            this.txtPesan1.TabIndex = 6;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(26, 303);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(318, 20);
            this.txtPesan2.TabIndex = 7;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(26, 329);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(318, 20);
            this.txtPesan3.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(26, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(318, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 482);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.txtPesan1);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtpekerjaan);
            this.Controls.Add(this.txtPendidikan);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label txtPendidikan;
        private System.Windows.Forms.Label txtpekerjaan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.Button btnOk;
    }
}

