namespace PerpustakaanAppMVC.View
{
    partial class FrmEntryMahasiswa
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
            this.txtNpm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.Label();
            this.txtAngkatan = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNpm
            // 
            this.txtNpm.AutoSize = true;
            this.txtNpm.Location = new System.Drawing.Point(20, 18);
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.Size = new System.Drawing.Size(43, 20);
            this.txtNpm.TabIndex = 0;
            this.txtNpm.Text = "NPM";
            this.txtNpm.Click += new System.EventHandler(this.txtNpm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(20, 58);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(51, 20);
            this.txtNama.TabIndex = 2;
            this.txtNama.Text = "Nama";
            this.txtNama.Click += new System.EventHandler(this.txtNama_Click);
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.AutoSize = true;
            this.txtAngkatan.Location = new System.Drawing.Point(20, 105);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.Size = new System.Drawing.Size(78, 20);
            this.txtAngkatan.TabIndex = 3;
            this.txtAngkatan.Text = "Angkatan";
            this.txtAngkatan.Click += new System.EventHandler(this.txtAngkatan_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(496, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 26);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(401, 153);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(103, 34);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(510, 153);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(103, 34);
            this.btnSelesai.TabIndex = 7;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // FrmEntryMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 199);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAngkatan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNpm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntryMahasiswa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntryMahasiswa";
            this.Load += new System.EventHandler(this.FrmEntryMahasiswa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNpm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtAngkatan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnSelesai;
    }
}