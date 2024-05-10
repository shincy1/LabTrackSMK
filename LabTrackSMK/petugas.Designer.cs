namespace LabTrackSMK
{
    partial class petugas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.masterSiswa1 = new LabTrackSMK.Petugas_Master.MasterSiswa();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1002, 39);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sintony", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "PETUGAS - PAGE";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Black;
            this.panelContainer.Controls.Add(this.masterSiswa1);
            this.panelContainer.Location = new System.Drawing.Point(160, 36);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(839, 564);
            this.panelContainer.TabIndex = 8;
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::LabTrackSMK.Properties.Resources.nav_v3;
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Controls.Add(this.nickname);
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(0, 37);
            this.sidebar.MaximumSize = new System.Drawing.Size(160, 564);
            this.sidebar.MinimumSize = new System.Drawing.Size(40, 564);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(160, 564);
            this.sidebar.TabIndex = 0;
            this.sidebar.Click += new System.EventHandler(this.sidebar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(3, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 35);
            this.panel2.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Sintony", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::LabTrackSMK.Properties.Resources.Laporan;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-4, 484);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "           Pengaturan";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Jura", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::LabTrackSMK.Properties.Resources.Inventaris_1_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-4, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 41);
            this.button6.TabIndex = 10;
            this.button6.Text = "         Inventaris";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Jura", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::LabTrackSMK.Properties.Resources.Lab_2_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-4, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "         Master Lab";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Jura", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::LabTrackSMK.Properties.Resources.lab_1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-4, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 41);
            this.button4.TabIndex = 8;
            this.button4.Text = "            Master Komputer";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Jura", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::LabTrackSMK.Properties.Resources.kelas;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-4, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "         Master Kelas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Jura", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::LabTrackSMK.Properties.Resources.petugas;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-4, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "            Master Petugas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::LabTrackSMK.Properties.Resources.shade;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Jura", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::LabTrackSMK.Properties.Resources.siswa_1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-4, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "         Master Siswa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sintony", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Petugas";
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.BackColor = System.Drawing.Color.Transparent;
            this.nickname.Font = new System.Drawing.Font("Sintony", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname.Location = new System.Drawing.Point(44, 522);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(50, 17);
            this.nickname.TabIndex = 4;
            this.nickname.Text = "Agung";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::LabTrackSMK.Properties.Resources.Close_1_;
            this.panel4.Location = new System.Drawing.Point(964, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 36);
            this.panel4.TabIndex = 9;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::LabTrackSMK.Properties.Resources.Minimize;
            this.panel5.Location = new System.Drawing.Point(926, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 36);
            this.panel5.TabIndex = 10;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // masterSiswa1
            // 
            this.masterSiswa1.AnimationEnabled = false;
            this.masterSiswa1.BackColor = System.Drawing.Color.White;
            this.masterSiswa1.Location = new System.Drawing.Point(0, 0);
            this.masterSiswa1.Name = "masterSiswa1";
            this.masterSiswa1.Size = new System.Drawing.Size(840, 564);
            this.masterSiswa1.TabIndex = 0;
            // 
            // petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "petugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "petugas";
            this.Load += new System.EventHandler(this.petugas_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Petugas_Master.MasterSiswa masterSiswa1;
    }
}