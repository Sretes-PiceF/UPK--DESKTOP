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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            label3.Text = Model.name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            data_Siswa1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            data_Buku1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            data_Peminjaman1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            data_Pengembalian1.BringToFront();
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
