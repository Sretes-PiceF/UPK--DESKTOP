namespace Desktop_Perpustakaan
{
    partial class Data_Siswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Siswa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tKeluar = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bTambah = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.absen = new System.Windows.Forms.TextBox();
            this.kelas = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.nis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.notlpn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(400, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(479, 156);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tKeluar
            // 
            this.tKeluar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tKeluar.Location = new System.Drawing.Point(746, 286);
            this.tKeluar.Name = "tKeluar";
            this.tKeluar.Size = new System.Drawing.Size(76, 34);
            this.tKeluar.TabIndex = 104;
            this.tKeluar.Text = "Keluar";
            this.tKeluar.UseVisualStyleBackColor = false;
            this.tKeluar.Click += new System.EventHandler(this.tKeluar_Click);
            // 
            // bHapus
            // 
            this.bHapus.BackColor = System.Drawing.Color.Red;
            this.bHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bHapus.Location = new System.Drawing.Point(462, 285);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(76, 34);
            this.bHapus.TabIndex = 103;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = false;
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.bUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bUpdate.Location = new System.Drawing.Point(155, 285);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(76, 34);
            this.bUpdate.TabIndex = 102;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            // 
            // bTambah
            // 
            this.bTambah.BackColor = System.Drawing.Color.Gold;
            this.bTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bTambah.Location = new System.Drawing.Point(66, 285);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(76, 34);
            this.bTambah.TabIndex = 101;
            this.bTambah.Text = "Tambah";
            this.bTambah.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "No Absen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Kelas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "NIS";
            // 
            // absen
            // 
            this.absen.Location = new System.Drawing.Point(11, 191);
            this.absen.Name = "absen";
            this.absen.Size = new System.Drawing.Size(167, 20);
            this.absen.TabIndex = 96;
            // 
            // kelas
            // 
            this.kelas.Location = new System.Drawing.Point(11, 137);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(167, 20);
            this.kelas.TabIndex = 95;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(11, 89);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(167, 20);
            this.nama.TabIndex = 94;
            // 
            // nis
            // 
            this.nis.Location = new System.Drawing.Point(11, 38);
            this.nis.Name = "nis";
            this.nis.Size = new System.Drawing.Size(167, 20);
            this.nis.TabIndex = 93;
            this.nis.TextChanged += new System.EventHandler(this.nis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Username";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 117;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "No Telepon";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(208, 190);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 20);
            this.password.TabIndex = 115;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(208, 136);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(167, 20);
            this.username.TabIndex = 114;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(208, 88);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 113;
            // 
            // notlpn
            // 
            this.notlpn.Location = new System.Drawing.Point(208, 37);
            this.notlpn.Name = "notlpn";
            this.notlpn.Size = new System.Drawing.Size(167, 20);
            this.notlpn.TabIndex = 112;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "Pencarian:";
            // 
            // Data_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.email);
            this.Controls.Add(this.notlpn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tKeluar);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.absen);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nis);
            this.Name = "Data_Siswa";
            this.Size = new System.Drawing.Size(882, 331);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tKeluar;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bTambah;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox absen;
        private System.Windows.Forms.TextBox kelas;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox nis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox notlpn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
