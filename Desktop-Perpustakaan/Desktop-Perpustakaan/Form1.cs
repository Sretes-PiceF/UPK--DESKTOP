using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Perpustakaan
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tMasuk_Click(object sender, EventArgs e)
        {

            connection.Open();

            string username = tUsername.Text;
            string password = tPassword.Text;

            string sql = "SELECT * FROM [user] WHERE username = '" + username + "' AND PASSWORD = '" + password + "'";

            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                foreach (DataRow row in tabel.Rows)
                {
                    if (row["role"].ToString() == "admin")
                    {

                        this.Hide();
                        Form2 window = new Form2();
                        window.Show();
                    }
                    else if (row["role"].ToString() == "siswa")
                    {
                        this.Hide();
                        FormSiswa windows = new FormSiswa();
                        windows.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }
    }
}
