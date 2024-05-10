using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTrackSMK
{
    public partial class petugas : Form
    {
        public static string name { get; set; }
        bool sidebarExpand;
        private int sidebarMinimizedWidth = 40;


        public petugas()
        {
            InitializeComponent();
            settings1.ButtonClicked += masterSiswa1.HandleSettingsButtonClicked;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        private void petugas_Load(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterSiswa1.BringToFront();
            button1.BackgroundImage = Properties.Resources.shade;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //masterPetugas1.BringToFront();
            button1.BackgroundImage = null;
            button2.BackgroundImage = Properties.Resources.shade;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //masterKelas2.BringToFront();
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = Properties.Resources.shade;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // masterKomputer1.BringToFront();
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = Properties.Resources.shade;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //masterLab1.BringToFront();
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = Properties.Resources.shade;
            button6.BackgroundImage = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // masterInventaris1.BringToFront();
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = Properties.Resources.shade;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            ToggleSidebar();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void background1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = Properties.Resources.shade;
        }

        private void masterSiswaReal1_Load(object sender, EventArgs e)
        {

        }

        private void masterKelas1_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToggleSidebar()
        {
            if (sidebarExpand)
            {
                sidebarTimer.Tick -= SidebarExpand_Tick; // Ganti event handler
                sidebarTimer.Tick += SidebarCollapse_Tick; // Ganti event handler
            }
            else
            {
                sidebarTimer.Tick -= SidebarCollapse_Tick; // Ganti event handler
                sidebarTimer.Tick += SidebarExpand_Tick; // Ganti event handler
            }

            sidebarTimer.Start();
        }

        private void SidebarExpand_Tick(object sender, EventArgs e)
        {
            sidebar.Width += 10; // Geser ke kanan
            panelContainer.Left += 10; // Geser mainPanel ke kanan
            if (sidebar.Width >= sidebar.MaximumSize.Width)
            {
                sidebar.Width = sidebar.MaximumSize.Width;
                panelContainer.Left = sidebar.Width; // Pastikan mainPanel berada di samping sidebar yang di-expand
                sidebarTimer.Stop();
                sidebarExpand = true;
            }
        }

        // Event handler untuk menggeser sidebar saat di-minimize
        private void SidebarCollapse_Tick(object sender, EventArgs e)
        {
            sidebar.Width -= 10; // Geser ke kiri
            panelContainer.Left -= 10; // Geser mainPanel ke kiri
            if (sidebar.Width <= sidebarMinimizedWidth)
            {
                sidebar.Width = sidebarMinimizedWidth;
                panelContainer.Left = sidebar.Width; // Pastikan mainPanel berada di samping sidebar yang di-minimize
                sidebarTimer.Stop();
                sidebarExpand = false;
            }
        }

        public void SetSidebarMinimizedWidth(int width)
        {
            sidebarMinimizedWidth = width;
        }

        private void nickname_Click(object sender, EventArgs e)
        {

        }

        private void masterSiswaReal1_Load_1(object sender, EventArgs e)
        {

        }

        private void petugas_Load_1(object sender, EventArgs e)
        {
            nickname.Text = name;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void masterSiswa1_Load(object sender, EventArgs e)
        {

        }
    }
}