using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop_Perpustakaan
{

    public partial class Data_Siswa : UserControl
    {

        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Data_Siswa()
        {
            InitializeComponent();

            // Panel Container
            Panel roundedPanel = new Panel();
            roundedPanel.Size = new Size(300, 20);
            roundedPanel.Location = new Point(20, 20);
            roundedPanel.BackColor = Color.LightGray;
            roundedPanel.Region = CreateRoundedRegion(roundedPanel.Width, roundedPanel.Height, 20);

            // TextBox Custom
            PaddedTextBox paddedTextBox = new PaddedTextBox();
            paddedTextBox.BorderStyle = BorderStyle.None;
            paddedTextBox.BackColor = Color.LightGray;
            paddedTextBox.Font = new Font("Segoe UI", 10);
            paddedTextBox.Location = new Point(12, 2); // posisikan agar sejajar vertikal
            paddedTextBox.Width = roundedPanel.Width - 20;

            // Tambahkan ke form
            roundedPanel.Controls.Add(paddedTextBox);
            this.Controls.Add(roundedPanel);

            roundedPanel.Location = new Point(428, 20); // Geser ke kanan sejauh 200px dari kiri form


            // Responsive saat resize panel
            roundedPanel.SizeChanged += (s, e) =>
            {
                roundedPanel.Region = CreateRoundedRegion(roundedPanel.Width, roundedPanel.Height, 20);
            };
            showData();
        }

        private void tKeluar_Click(object sender, EventArgs e)
        {
            Login Form = new Login();
            Form.Show();
            this.FindForm().Close();
        }

        private void nis_TextChanged(object sender, EventArgs e)
        {

        }
        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "SELECT * FROM [siswa] " +
                    "INNER JOIN [user] ON [siswa].id_user = [user].id_user";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns[0].Visible = false; // id_siswa
                dataGridView1.Columns[1].Visible = false; // id_user pertama
                dataGridView1.Columns[5].Visible = false; // id_user kedua
                dataGridView1.Columns[7].Visible = false; // role

                dataGridView1.Columns[2].HeaderText = "NIS";
                dataGridView1.Columns[6].HeaderText = "Nama";
                dataGridView1.Columns[3].HeaderText = "Kelas";
                dataGridView1.Columns[4].HeaderText = "Absen";
                dataGridView1.Columns[8].HeaderText = "Email";
                dataGridView1.Columns[9].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[10].HeaderText = "Username";
                dataGridView1.Columns[11].HeaderText = "Password";


                dataGridView1.Columns[2].DisplayIndex = 0;  // NIS
                dataGridView1.Columns[6].DisplayIndex = 1;  // Nama
                dataGridView1.Columns[3].DisplayIndex = 2;  // Kelas
                dataGridView1.Columns[4].DisplayIndex = 3;  // Absen ✅ <-- ini kunci!
                dataGridView1.Columns[8].DisplayIndex = 4;  // Email
                dataGridView1.Columns[9].DisplayIndex = 5;  // No Telp
                dataGridView1.Columns[10].DisplayIndex = 6; // Username
                dataGridView1.Columns[11].DisplayIndex = 7; // Password
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hanya garis horizontal pada sel
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Hilangkan garis vertikal pada header
            dataGridView1.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            // Atur gaya tampilan header
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private Region CreateRoundedRegion(int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(width - radius, 0, radius, radius, 270, 90);
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            path.AddArc(0, height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return new Region(path);
        }

        public class PaddedTextBox : TextBox
        {
            private const int paddingLeft = 20; // ← Geser teks 20px dari kiri

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == 0x0201) // WM_LBUTTONDOWN
                {
                    this.Select(this.Text.Length, 0);
                }
            }

            protected override void OnCreateControl()
            {
                base.OnCreateControl();
                SendMessage(this.Handle, 0x00D3, (IntPtr)paddingLeft, IntPtr.Zero); // EM_SETMARGINS
            }

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        }

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);

        //    var parentForm = this.FindForm();
        //    if (parentForm != null)
        //    {
        //        parentForm.StartPosition = FormStartPosition.Manual;
        //        parentForm.Location = new Point(500, parentForm.Location.Y);
        //    }
        //}

    }
}