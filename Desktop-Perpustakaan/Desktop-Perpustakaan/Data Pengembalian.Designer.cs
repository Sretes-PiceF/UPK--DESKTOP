namespace Desktop_Perpustakaan
{
    partial class Data_Pengembalian
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Pengembalian));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tKeluar = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bSimpan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.judul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.NumericUpDown();
            this.idPeminjaman = new System.Windows.Forms.ComboBox();
            this.idBuku = new System.Windows.Forms.ComboBox();
            this.nisSiswa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.namaSiswa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(114, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Judul Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(53, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Peminjam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(19, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 156);
            this.dataGridView1.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(311, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanggal Kembali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(267, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durasi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(436, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 145;
            this.label12.Text = "Search";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Location = new System.Drawing.Point(409, 10);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(344, 27);
            this.search.TabIndex = 144;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(337, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 20);
            this.panel1.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(178, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // tKeluar
            // 
            this.tKeluar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tKeluar.Location = new System.Drawing.Point(746, 286);
            this.tKeluar.Name = "tKeluar";
            this.tKeluar.Size = new System.Drawing.Size(76, 34);
            this.tKeluar.TabIndex = 141;
            this.tKeluar.Text = "Keluar";
            this.tKeluar.UseVisualStyleBackColor = false;
            this.tKeluar.Click += new System.EventHandler(this.tKeluar_Click);
            // 
            // bHapus
            // 
            this.bHapus.BackColor = System.Drawing.Color.Red;
            this.bHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bHapus.Location = new System.Drawing.Point(62, 285);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(76, 34);
            this.bHapus.TabIndex = 140;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = false;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.bEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEdit.Location = new System.Drawing.Point(155, 285);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(76, 34);
            this.bEdit.TabIndex = 139;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            // 
            // bSimpan
            // 
            this.bSimpan.BackColor = System.Drawing.Color.Gold;
            this.bSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSimpan.Location = new System.Drawing.Point(464, 285);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(134, 34);
            this.bSimpan.TabIndex = 138;
            this.bSimpan.Text = "Simpan Peminjaman";
            this.bSimpan.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 137;
            this.label9.Text = "ID Buku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "ID Peminjaman";
            // 
            // judul
            // 
            this.judul.Enabled = false;
            this.judul.Location = new System.Drawing.Point(62, 108);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(167, 20);
            this.judul.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "Jumlah";
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(62, 222);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(77, 20);
            this.jumlah.TabIndex = 151;
            this.jumlah.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // idPeminjaman
            // 
            this.idPeminjaman.FormattingEnabled = true;
            this.idPeminjaman.Location = new System.Drawing.Point(62, 32);
            this.idPeminjaman.Name = "idPeminjaman";
            this.idPeminjaman.Size = new System.Drawing.Size(169, 21);
            this.idPeminjaman.TabIndex = 152;
            this.idPeminjaman.Text = "Pilih ID Peminjaman";
            // 
            // idBuku
            // 
            this.idBuku.FormattingEnabled = true;
            this.idBuku.Location = new System.Drawing.Point(62, 81);
            this.idBuku.Name = "idBuku";
            this.idBuku.Size = new System.Drawing.Size(167, 21);
            this.idBuku.TabIndex = 153;
            this.idBuku.Text = "Pilih ID Buku";
            // 
            // nisSiswa
            // 
            this.nisSiswa.FormattingEnabled = true;
            this.nisSiswa.Location = new System.Drawing.Point(62, 154);
            this.nisSiswa.Name = "nisSiswa";
            this.nisSiswa.Size = new System.Drawing.Size(167, 21);
            this.nisSiswa.TabIndex = 156;
            this.nisSiswa.Text = "Pilih ID Buku";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 155;
            this.label8.Text = "NIS";
            // 
            // namaSiswa
            // 
            this.namaSiswa.Enabled = false;
            this.namaSiswa.Location = new System.Drawing.Point(62, 181);
            this.namaSiswa.Name = "namaSiswa";
            this.namaSiswa.Size = new System.Drawing.Size(167, 20);
            this.namaSiswa.TabIndex = 154;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(403, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Denda";
            // 
            // Data_Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nisSiswa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.namaSiswa);
            this.Controls.Add(this.idBuku);
            this.Controls.Add(this.idPeminjaman);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tKeluar);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pengembalian";
            this.Size = new System.Drawing.Size(882, 331);
            this.Load += new System.EventHandler(this.Data_Pengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tKeluar;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown jumlah;
        private System.Windows.Forms.ComboBox idPeminjaman;
        private System.Windows.Forms.ComboBox idBuku;
        private System.Windows.Forms.ComboBox nisSiswa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namaSiswa;
        private System.Windows.Forms.Label label10;
    }
}
