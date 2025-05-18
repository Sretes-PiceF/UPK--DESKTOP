using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Perpustakaan
{
    public partial class Login : Form
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tMasuk_MouseClick(object sender, MouseEventArgs e)
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
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        App window = new App();
                        window.Show();
                    }
                    else if (row["role"].ToString() == "siswa")
                    {

                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

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

        private void tMasuk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
