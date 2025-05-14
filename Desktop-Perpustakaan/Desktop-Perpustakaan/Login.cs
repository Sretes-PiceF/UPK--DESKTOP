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

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

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
                    
                        this.Hide();
                        Form2 window = new Form2();
                        window.Show();
                    }
                    else if (row["role"].ToString() == "siswa")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();

                        this.Hide();
                        FormSiswa windows = new FormSiswa();
                        windows.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username salah atau Password Salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void tMasuk_Click(object sender, EventArgs e)
        {

        }
    }
}
