﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Perpustakaan
{
    public partial class Data_Peminjaman : UserControl
    {
        public Data_Peminjaman()
        {
            InitializeComponent();
        }

        private void tKeluar_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.FindForm().Close();
        }
    }
}
