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
    public partial class Data_Pengembalian : UserControl
    {
        public Data_Pengembalian()
        {
            InitializeComponent();
        }

        private void Data_Pengembalian_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tKeluar_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.FindForm().Close();
        }
    }
}
