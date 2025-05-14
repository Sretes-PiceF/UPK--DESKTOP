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
            Form2 windoww = new Form2();
            windoww.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
