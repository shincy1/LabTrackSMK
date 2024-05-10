using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTrackSMK.Custom_Component;
using LabTrackSMK;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabTrackSMK
{
    //push repo s
    //push repo fg
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UTSEEDN\\SQLEXPRESS;Initial Catalog=labDB;Integrated Security=True;");
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public int id_petugas;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = box_uname;
            box_uname.Focus();

        }

        private void login_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            if (screenWidth < 1024 || screenHeight < 768) // tidak support resolusi di bawah 1024 x 768
            {
                MessageBox.Show("Resolusi layar minimal yang didukung aplikasi ini adalah 1024 x 768. Aplikasi tidak dapat dijalankan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void cSbutton1_Click(object sender, EventArgs e)
        {
            string username = box_uname.Text;
            string password = box_pw.Text;
            if (box_uname.Text == "admin" && box_pw.Text == "admin")// backup
            {
                this.Hide();
                petugas panggilA = new petugas();
                petugas.name = box_uname.Text;
                panggilA.Show();
                MessageBox.Show($"Selamat Datang {box_uname.Text}");
            }
            else
            {
                using (SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-UTSEEDN\\SQLEXPRESS;Initial Catalog=labDB;Integrated Security=True;"))
                {
                    koneksi.Open();

                    // Query untuk mengambil data dari tabel Login
                    string query = "SELECT COUNT(*) , level FROM [Login] WHERE username = @username AND password = @password GROUP BY LEVEL";
                    SqlCommand command = new SqlCommand(query, koneksi);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Jika login berhasil
                        string level = reader["level"].ToString();
                        if (level == "petugas")
                        {
                            MessageBox.Show($"Selamat Datang Petugas {username}");

                            // Menutup pembaca data sebelum membuka yang baru
                            reader.Close();

                            // Mengambil id_petugas dari tabel Petugas
                            string queryPetugas = "SELECT id_petugas FROM petugas WHERE id_login = (SELECT id_login FROM [Login] WHERE username = @username)";
                            SqlCommand commandPetugas = new SqlCommand(queryPetugas, koneksi);
                            commandPetugas.Parameters.AddWithValue("@username", username);

                            object result = commandPetugas.ExecuteScalar();
                            if (result != null)
                            {
                                id_petugas = Convert.ToInt32(result);

                                // Menyembunyikan form login
                                this.Hide();

                                //Membuat objek masterInventaris dan menetapkan id_petugas/////////////////////
                                //masterInventaris formMasterInventaris = new masterInventaris();
                                //masterInventaris.id_petugas = id_petugas;

                                // Membuat objek petugas dan menetapkan name
                                petugas menup = new petugas();
                                petugas.name = box_uname.Text;

                                // Menampilkan form masterInventaris dan petugas
                                //formMasterInventaris.Show();
                                menup.Show();
                            }
                        }
                    }
                    else
                    {
                        // Jika tidak ada data yang sesuai dengan username dan password
                        MessageBox.Show("Username atau Password Anda Salah");
                    }

                    // Pastikan untuk menutup koneksi
                    koneksi.Close();
                }
            }
        }




        private void box_uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //detect posisi control aktif

            {
                e.SuppressKeyPress = true; // biar gk bunyi
                box_pw.Focus(); // ganti control fokus
            }
        }

        private void box_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //detect posisi control aktif

            {
                e.SuppressKeyPress = true; // biar gk bunyi
                cSbutton1.PerformClick(); // trigger butto
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
