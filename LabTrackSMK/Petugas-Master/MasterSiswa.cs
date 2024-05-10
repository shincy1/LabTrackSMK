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
using LabTrackSMK.Properties;

namespace LabTrackSMK.Petugas_Master
{
    public partial class MasterSiswa : UserControl
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UTSEEDN\\SQLEXPRESS;Initial Catalog=labDB;Integrated Security=True;");
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public int id_siswa;
        public int id_login;

        // Variabel untuk mengontrol apakah animasi apel jatuh aktif atau tidak
        private bool animationEnabled = false;
        private Timer buttonTimer;

        // Properti publik untuk mengakses variabel animationEnabled
        public bool AnimationEnabled
        {
            get { return animationEnabled; }
            set
            {
                animationEnabled = value;
            }
        }
        /// <Background>
        private Timer timer;
        private Random random;
        private int fallSpeed = 1; // Kecepatan jatuh yang lebih lambat
        private int maxHeight; // Batas maksimum tinggi jatuh
        private int leafCount = 20; // Jumlah daun
        private PictureBox[] leafPictureBoxes; // Array untuk menyimpan PictureBoxes daun
        private double[] rotationAngles; // Array untuk menyimpan sudut rotasi awal
        /// </Backround>
        public MasterSiswa()
        {
            AnimationEnabled = false;
            InitializeComponent();
            kelas_cm.Text = "Pilih--";
            showData();
            //LoadClassNames();
            FillClassComboBox();

            /// <Background>
            random = new Random();


            /// </Background>
        }

        public void showData()
        {
            try
            {
                connection.Close();


                string sql = "SELECT siswa.nis, siswa.nama, siswa.jk, kelas.nama_kelas AS Kelas, Login.id_login, Login.username, Login.password, Login.status " +
                             "FROM siswa " +
                             "INNER JOIN Login ON siswa.id_login = login.id_login " +
                             "INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas " +
                             "WHERE Login.status = 'Aktif'";

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tabel = new DataTable();
                connection.Open();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.Columns[0].HeaderText = "Nis";
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
                dataGridView1.Columns[3].HeaderText = "Kelas";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Username";
                dataGridView1.Columns[6].HeaderText = "Password";
                dataGridView1.Columns[7].HeaderText = "Status";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Show Siswa: " + ex.Message);
            }
        }
        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            // Panggil metode atau jalankan kode yang ingin dijalankan secara teratur di sini
            //button1.PerformClick(); // Memanggil event Click dari tombol 1
        }


        public void clear()
        {
            nis_bx.Text = "";
            nama_bx.Text = "";
            laki_rd.Checked = false;
            perempuan_rd.Checked = false;
            kelas_cm.Text = "Pilih--";
        }




        private void FillClassComboBox()
        {
            try
            {

                connection.Open();
                string sql = "SELECT nama_kelas FROM kelas";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string namaKelas = reader["nama_kelas"].ToString();
                    kelas_cm.Items.Add(namaKelas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching classes Siswa: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string GetSelectedClassId()
        {
            string selectedClassName = kelas_cm.SelectedItem.ToString();
            string selectedClassId = ""; // Here you'll retrieve the id_kelas based on the selected nama_kelas
            try
            {
                connection.Close();
                connection.Open();
                string sql = "SELECT id_kelas FROM kelas WHERE nama_kelas = @nama_kelas";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nama_kelas", selectedClassName);
                selectedClassId = command.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching class Siswa ID 2: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return selectedClassId;
        }



        public void insertData()
        {
            if (string.IsNullOrEmpty(nis_bx.Text) ||
                string.IsNullOrEmpty(nama_bx.Text) ||
                string.IsNullOrEmpty(kelas_cm.Text) || kelas_cm.Text == "Pilih--" ||
                (laki_rd.Checked == false && perempuan_rd.Checked == false) ||
                string.IsNullOrEmpty(username_bx.Text) ||
                string.IsNullOrEmpty(password_bx.Text))
            {
                MessageBox.Show("Please fill all data before insert!");
            }
            else
            {
                try
                {
                    connection.Open();

                    // Periksa apakah username sudah ada di database
                    string checkUsernameSql = "SELECT COUNT(*) FROM Login WHERE username = @username";
                    SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameSql, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@username", username_bx.Text);
                    int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username Sudah Dipakai! Tolong pakai Username Lain " +
                            "(jika tidak ada di list kemungkinan Username telah digunakan oleh akun yang nonaktif).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the process if username exists
                    }

                    // Insert data login
                    string insertLoginSql = "INSERT INTO Login (username, password, level, status) " +
                        "VALUES (@username, @password, @level, @status)";
                    SqlCommand insertLoginCommand = new SqlCommand(insertLoginSql, connection);
                    insertLoginCommand.Parameters.AddWithValue("@username", username_bx.Text);
                    insertLoginCommand.Parameters.AddWithValue("@password", password_bx.Text);
                    insertLoginCommand.Parameters.AddWithValue("@level", "siswa");
                    insertLoginCommand.Parameters.AddWithValue("@status", "Aktif");
                    insertLoginCommand.ExecuteNonQuery();

                    // Mendapatkan id_login baru
                    string selectLoginIdSql = "SELECT id_login FROM Login WHERE username = @username " +
                        "AND password = @password";
                    SqlCommand selectLoginIdCommand = new SqlCommand(selectLoginIdSql, connection);
                    selectLoginIdCommand.Parameters.AddWithValue("@username", username_bx.Text);
                    selectLoginIdCommand.Parameters.AddWithValue("@password", password_bx.Text);
                    int idLogin = Convert.ToInt32(selectLoginIdCommand.ExecuteScalar());

                    // Mendapatkan id_kelas dari nama kelas yang dipilih di combobox
                    string selectKelasIdSql = "SELECT id_kelas FROM kelas WHERE nama_kelas = @kelas";
                    SqlCommand selectKelasIdCommand = new SqlCommand(selectKelasIdSql, connection);
                    selectKelasIdCommand.Parameters.AddWithValue("@kelas", kelas_cm.SelectedItem.ToString());
                    int idKelas = Convert.ToInt32(selectKelasIdCommand.ExecuteScalar());

                    // Insert data siswa dengan id_login dan id_kelas yang didapatkan
                    string insertSiswaSql = "INSERT INTO siswa (nis, nama, jk, id_kelas, id_login) " +
                        "VALUES (@nis, @nama, @jk, @id_kelas, @id_login)";
                    SqlCommand insertSiswaCommand = new SqlCommand(insertSiswaSql, connection);
                    insertSiswaCommand.Parameters.AddWithValue("@nis", nis_bx.Text);
                    insertSiswaCommand.Parameters.AddWithValue("@nama", nama_bx.Text);
                    insertSiswaCommand.Parameters.AddWithValue("@jk", laki_rd.Checked ? "Laki-laki" : "Perempuan");
                    insertSiswaCommand.Parameters.AddWithValue("@id_kelas", idKelas);
                    insertSiswaCommand.Parameters.AddWithValue("@id_login", idLogin);
                    insertSiswaCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at Insert Siswa:" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void editData()
        {
            if (!string.IsNullOrEmpty(nis_bx.Text) &&
                !string.IsNullOrEmpty(kelas_cm.Text) && kelas_cm.Text != "Pilih Kelas" &&
                (laki_rd.Checked || perempuan_rd.Checked))
            {
                DialogResult result = MessageBox.Show("Apakah kamu yakin mau Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perbarui data siswa
                        string sql = "UPDATE siswa SET nama = @nama, jk = @jk, id_kelas = @id_kelas WHERE nis = @nis";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@nama", nama_bx.Text);
                        command.Parameters.AddWithValue("@jk", laki_rd.Checked ? "Laki-laki" : "Perempuan");

                        // Mendapatkan id_kelas dari nama kelas yang dipilih di combobox
                        string selectedClassId = GetSelectedClassId();
                        command.Parameters.AddWithValue("@id_kelas", selectedClassId);
                        command.Parameters.AddWithValue("@nis", nis_bx.Text);

                        connection.Open();
                        command.ExecuteNonQuery();

                        // Perbarui data login hanya jika username diubah dan username baru belum ada di database
                        if (!string.IsNullOrEmpty(username_bx.Text) && username_bx.Text != dataGridView1.CurrentRow.Cells["username"].Value.ToString())
                        {
                            // Periksa apakah username baru sudah ada di database
                            string checkUsernameSql = "SELECT COUNT(*) FROM Login WHERE username = @username";
                            SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameSql, connection);
                            checkUsernameCommand.Parameters.AddWithValue("@username", username_bx.Text);
                            int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                            if (usernameCount > 0)
                            {
                                MessageBox.Show("Username Sudah Dipakai! Tolong pakai Username Lain " +
                            "(jika tidak ada di list kemungkinan Username telah digunakan oleh akun yang nonaktif).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Stop the process if username exists
                            }

                            // Update data login
                            string updateLoginSql = "UPDATE Login SET username = @username, password = @password WHERE id_login = @id_login";
                            SqlCommand updateLoginCommand = new SqlCommand(updateLoginSql, connection);
                            updateLoginCommand.Parameters.AddWithValue("@username", username_bx.Text);
                            updateLoginCommand.Parameters.AddWithValue("@password", password_bx.Text);
                            updateLoginCommand.Parameters.AddWithValue("@id_login", id_login);
                            updateLoginCommand.ExecuteNonQuery();


                        }

                        MessageBox.Show("Berhasil di Update!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();
                        showData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error at Update Siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tolong isi semua data!!");
            }
        }






        public void deleteData()
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        connection.Open();

                        string sql = "DELETE FROM siswa WHERE nis = @nis";

                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@nis", nis_bx.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Berhasil di hapus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();
                        showData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sepertinya terjadi kesalahan, Kamu tidak bisa menghapus Siswa yang memiliki Riwayat. Gunakan tombol 'Nonaktif' untuk menonaktifkan akun siswa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ///MessageBox.Show("Error at: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih data dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void searchData()
        {
            if (!string.IsNullOrEmpty(search_bx.Text))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT siswa.nis, siswa.nama, siswa.jk, kelas.nama_kelas AS Kelas, Login.id_login, Login.username, Login.password, Login.status " +
                                 "FROM siswa " +
                                 "INNER JOIN Login ON siswa.id_login = login.id_login " +
                                 "INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas " +
                                 "WHERE (siswa.nama LIKE '%' + @search + '%' OR " +
                                 "siswa.nis LIKE '%' + @search + '%' OR " +
                                 "kelas.nama_kelas LIKE '%' + @search + '%')" +
                                 "AND Login.status = 'Aktif'"; // Hanya akun dengan status 'Aktif'
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@search", search_bx.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].HeaderText = "Nis";
                        dataGridView1.Columns[1].HeaderText = "Nama";
                        dataGridView1.Columns[2].HeaderText = "Jenis Kelamin";
                        dataGridView1.Columns[3].HeaderText = "Kelas";
                        dataGridView1.Columns[4].Visible = false;
                        dataGridView1.Columns[5].HeaderText = "Username";
                        dataGridView1.Columns[6].HeaderText = "Password";
                        dataGridView1.Columns[7].HeaderText = "Status";
                    }
                    else
                    {
                        // Tampilkan pesan jika tidak ada hasil
                        //MessageBox.Show("No data found matching the search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error at Search Siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                showData();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MasterSiswa_Load(object sender, EventArgs e)
        {

        }

        /// <Background>
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 350; // Interval timer (ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gerakkan setiap daun
            for (int i = 0; i < leafCount; i++)
            {
                PictureBox leafPictureBox = leafPictureBoxes[i];
                double rotationAngle = rotationAngles[i];

                // Atur posisi jatuh
                if (leafPictureBox.Top < maxHeight)
                {
                    // Gerakan vertikal ke bawah
                    leafPictureBox.Top += fallSpeed;

                    // Rotasi daun
                    leafPictureBox.Image = RotateImage(Properties.Resources.apple, rotationAngle);

                    // Perbarui sudut rotasi untuk gerakan berayun-ayun
                    rotationAngle += 0.5; // Nilai kecil untuk memperlambat rotasi

                    // Perbarui tampilan PictureBox
                    leafPictureBox.Invalidate();
                }
                else
                {
                    // Spawn ulang daun di posisi acak di atas layar
                    leafPictureBox.Left = random.Next(this.ClientSize.Width - leafPictureBox.Width);
                    leafPictureBox.Top = -random.Next(50, 500); // Random posisi awal tinggi

                    // Random kembali kecepatan jatuh
                    fallSpeed = random.Next(1, 4);

                    // Reset sudut rotasi
                    rotationAngle = random.NextDouble() * 360; // Random sudut rotasi awal
                }

                // Simpan kembali sudut rotasi
                rotationAngles[i] = rotationAngle;
            }
        }

        private Bitmap RotateImage(Image image, double angle)
        {
            // Hitung ukuran gambar yang diputar
            int newSize = (int)Math.Sqrt(image.Width * image.Width + image.Height * image.Height);
            Bitmap rotatedImage = new Bitmap(newSize, newSize);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Pusat rotasi
                g.TranslateTransform(newSize / 2, newSize / 2);
                // Rotasi gambar
                g.RotateTransform((float)angle);
                // Gambar rotasi
                g.DrawImage(image, new Point(-image.Width / 2, -image.Height / 2));
            }
            return rotatedImage;
        }

        private void InitializeLeaves()
        {
            leafPictureBoxes = new PictureBox[leafCount]; // Inisialisasi array
            rotationAngles = new double[leafCount]; // Inisialisasi array

            for (int i = 0; i < leafCount; i++)
            {
                // Gambar daun
                PictureBox leafPictureBox = new PictureBox();
                leafPictureBox.Size = new Size(50, 50); // Sesuaikan ukuran daun
                leafPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                leafPictureBox.BackColor = Color.Transparent; // Setel latar belakang menjadi transparan

                // Tambahkan gambar daun ke dalam PictureBox
                leafPictureBox.Image = Properties.Resources.apple; // Pastikan gambar daun tersedia di folder Resources

                // Letakkan daun di posisi awal yang acak di atas layar dengan memastikan jarak minimal 10 piksel dari daun sebelumnya
                int newX, newY;
                bool isOverlapping;
                do
                {
                    newX = random.Next(this.ClientSize.Width - leafPictureBox.Width);
                    newY = random.Next(0, this.ClientSize.Height - leafPictureBox.Height);
                    isOverlapping = false;

                    // Periksa jarak dengan semua daun sebelumnya
                    foreach (PictureBox existingLeaf in leafPictureBoxes)
                    {
                        if (existingLeaf != null && Math.Abs(newX - existingLeaf.Left) < 20 && Math.Abs(newY - existingLeaf.Top) < 20)
                        {
                            isOverlapping = true;
                            break;
                        }
                    }
                } while (isOverlapping);

                leafPictureBox.Left = newX;
                leafPictureBox.Top = newY;
                maxHeight = this.ClientSize.Height; // Batas maksimum tinggi jatuh

                // Tambahkan daun ke array
                leafPictureBoxes[i] = leafPictureBox;

                // Random sudut rotasi awal
                rotationAngles[i] = random.NextDouble() * 360;

                // Tambahkan daun ke Form
                this.Controls.Add(leafPictureBox);
            }
        }

        public delegate void ButtonClickEventHandler(object sender, EventArgs e);

        // Buat event menggunakan delegate
        public event ButtonClickEventHandler SettingsButtonClicked;

        // Metode untuk menangani event dari settings1
        public void HandleSettingsButtonClicked(object sender, EventArgs e)
        {
            if (animationEnabled == false)
            {
                AnimationEnabled = true;
                InitializeLeaves(); // Tambahkan inisialisasi daun di sini
                InitializeTimer();
            }
            else
            {
                AnimationEnabled = false;

                // Menghapus semua PictureBoxes daun
                foreach (PictureBox leafPictureBox in leafPictureBoxes)
                {
                    this.Controls.Remove(leafPictureBox);
                    leafPictureBox.Dispose();
                }
                // Membersihkan array PictureBoxes daun
                Array.Clear(leafPictureBoxes, 0, leafPictureBoxes.Length);

                // Memberhentikan dan membuang timer
                timer.Stop();
                timer.Dispose();

            }
        }
        /// </Backround>

        private void search_bx_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void kelas_cm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kelas_cm.SelectedItem != null)
            {
                string selectedClassId = GetSelectedClassId();
                string selectedClassName = kelas_cm.SelectedItem.ToString();
                //MessageBox.Show("Selected class ID: " + selectedClassId);
            }
        }

        public class KelasInfo
        {
            public string Id { get; set; }
            public string Nama { get; set; }

            public KelasInfo(string id, string nama)
            {
                Id = id;
                Nama = nama;
            }

            public override string ToString()
            {
                return Nama;
            }
        }

       
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && e.RowIndex != -1)
            {
                // Retrieve values from the selected row
                nis_bx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nama_bx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kelas_cm.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                // Handling radio buttons for gender
                string jenisKelamin = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (jenisKelamin == "Laki-laki")
                {
                    laki_rd.Checked = true;
                }
                else if (jenisKelamin == "Perempuan")
                {
                    perempuan_rd.Checked = true;
                }

                // Handle id_login, ensure it's valid before attempting conversion
                if (int.TryParse(dataGridView1.CurrentRow.Cells[4].Value.ToString(), out int idLogin))
                {
                    id_login = idLogin;
                }
                else
                {
                    id_login = -1; // Or any default value that fits
                }

                // Retrieve username and password
                username_bx.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                password_bx.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
            }
        }

        private void nonaktifkanAkunSiswa(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah kamu yakin ingin menonaktifkan akun ini? kamu tidak dapat mengaktifkannya kembali!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sql = "UPDATE Login SET status = 'Nonaktif' WHERE id_login = @id_login";

                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UTSEEDN\\SQLEXPRESS;Initial Catalog=labDB;Integrated Security=True;"))
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id_login", id_login);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Akun berhasil dinonaktifkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih data dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}