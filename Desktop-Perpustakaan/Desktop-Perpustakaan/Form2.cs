using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void data_Pengembalian1_Load(object sender, EventArgs e)
        {

        }

        private void tKeluar_Click(object sender, EventArgs e)
        {
            Login window = new Login();
            this.Close();
            window.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 window = new Form2();
            window.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            data_Buku1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            data_Peminjaman1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            data_Pengembalian1.BringToFront();
        }
    }
}
