using System.Windows.Forms;

namespace LabTrackSMK.Petugas_Master
{
    partial class MasterSiswa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kelas_cm = new System.Windows.Forms.ComboBox();
            this.password_bx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.username_bx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.perempuan_rd = new System.Windows.Forms.RadioButton();
            this.laki_rd = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.search_bx = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nis_bx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nama_bx = new System.Windows.Forms.TextBox();
            this.csPanel1 = new LabTrackSMK.Custom_Component.csPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ban = new LabTrackSMK.Custom_Component.CSbutton();
            this.delete = new LabTrackSMK.Custom_Component.CSbutton();
            this.update = new LabTrackSMK.Custom_Component.CSbutton();
            this.Insert = new LabTrackSMK.Custom_Component.CSbutton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.csPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kelas_cm
            // 
            this.kelas_cm.FormattingEnabled = true;
            this.kelas_cm.Location = new System.Drawing.Point(32, 356);
            this.kelas_cm.Name = "kelas_cm";
            this.kelas_cm.Size = new System.Drawing.Size(245, 21);
            this.kelas_cm.TabIndex = 12;
            this.kelas_cm.SelectedIndexChanged += new System.EventHandler(this.kelas_cm_SelectedIndexChanged);
            // 
            // password_bx
            // 
            this.password_bx.Location = new System.Drawing.Point(32, 469);
            this.password_bx.Name = "password_bx";
            this.password_bx.Size = new System.Drawing.Size(245, 20);
            this.password_bx.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Password";
            // 
            // username_bx
            // 
            this.username_bx.Location = new System.Drawing.Point(32, 412);
            this.username_bx.Name = "username_bx";
            this.username_bx.Size = new System.Drawing.Size(245, 20);
            this.username_bx.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Kelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Jenis Kelamin";
            // 
            // perempuan_rd
            // 
            this.perempuan_rd.AutoSize = true;
            this.perempuan_rd.BackColor = System.Drawing.Color.Transparent;
            this.perempuan_rd.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perempuan_rd.Location = new System.Drawing.Point(108, 301);
            this.perempuan_rd.Name = "perempuan_rd";
            this.perempuan_rd.Size = new System.Drawing.Size(86, 16);
            this.perempuan_rd.TabIndex = 50;
            this.perempuan_rd.TabStop = true;
            this.perempuan_rd.Text = "Perempuan";
            this.perempuan_rd.UseVisualStyleBackColor = false;
            // 
            // laki_rd
            // 
            this.laki_rd.AutoSize = true;
            this.laki_rd.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laki_rd.Location = new System.Drawing.Point(32, 301);
            this.laki_rd.Name = "laki_rd";
            this.laki_rd.Size = new System.Drawing.Size(68, 16);
            this.laki_rd.TabIndex = 49;
            this.laki_rd.TabStop = true;
            this.laki_rd.Text = "Laki-laki";
            this.laki_rd.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.search_bx);
            this.panel6.Location = new System.Drawing.Point(316, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 35);
            this.panel6.TabIndex = 48;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(18, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(85, 20);
            this.panel8.TabIndex = 20;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jura", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "search";
            // 
            // search_bx
            // 
            this.search_bx.Location = new System.Drawing.Point(103, 7);
            this.search_bx.Name = "search_bx";
            this.search_bx.Size = new System.Drawing.Size(375, 20);
            this.search_bx.TabIndex = 20;
            this.search_bx.TextChanged += new System.EventHandler(this.search_bx_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel5.Controls.Add(this.ban);
            this.panel5.Controls.Add(this.delete);
            this.panel5.Controls.Add(this.update);
            this.panel5.Controls.Add(this.Insert);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(0, 518);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(840, 45);
            this.panel5.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Location = new System.Drawing.Point(307, -32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 100);
            this.panel7.TabIndex = 22;
            // 
            // nis_bx
            // 
            this.nis_bx.Location = new System.Drawing.Point(32, 183);
            this.nis_bx.Name = "nis_bx";
            this.nis_bx.Size = new System.Drawing.Size(245, 20);
            this.nis_bx.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "NIS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.panel3.Location = new System.Drawing.Point(155, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 30);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 30);
            this.panel2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jura", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detail Petugas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::LabTrackSMK.Properties.Resources.kelas;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(7, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jura", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Master Siswa";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.panel9.Location = new System.Drawing.Point(316, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 30);
            this.panel9.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jura", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nama";
            // 
            // nama_bx
            // 
            this.nama_bx.Location = new System.Drawing.Point(32, 243);
            this.nama_bx.Name = "nama_bx";
            this.nama_bx.Size = new System.Drawing.Size(245, 20);
            this.nama_bx.TabIndex = 53;
            // 
            // csPanel1
            // 
            this.csPanel1.BackColor = System.Drawing.Color.White;
            this.csPanel1.BorderRadius = 30;
            this.csPanel1.Controls.Add(this.dataGridView1);
            this.csPanel1.ForeColor = System.Drawing.Color.Black;
            this.csPanel1.GradientAngle = 90F;
            this.csPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.csPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.csPanel1.Location = new System.Drawing.Point(316, 60);
            this.csPanel1.Name = "csPanel1";
            this.csPanel1.Size = new System.Drawing.Size(500, 441);
            this.csPanel1.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Sintony", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(500, 420);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ban
            // 
            this.ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ban.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ban.BorderRadius = 10;
            this.ban.BorderSize = 1;
            this.ban.FlatAppearance.BorderSize = 0;
            this.ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ban.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ban.Image = global::LabTrackSMK.Properties.Resources.Ban_user;
            this.ban.Location = new System.Drawing.Point(265, 8);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(30, 30);
            this.ban.TabIndex = 63;
            this.ban.UseVisualStyleBackColor = false;
            this.ban.Click += new System.EventHandler(this.nonaktifkanAkunSiswa);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.delete.BorderRadius = 10;
            this.delete.BorderSize = 1;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.delete.Image = global::LabTrackSMK.Properties.Resources.delete_dark;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(179, 8);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 30);
            this.delete.TabIndex = 62;
            this.delete.Text = "     delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.update.BorderRadius = 10;
            this.update.BorderSize = 0;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = global::LabTrackSMK.Properties.Resources.edit_light;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(94, 8);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(82, 30);
            this.update.TabIndex = 61;
            this.update.Text = "     update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.Insert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(156)))));
            this.Insert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Insert.BorderRadius = 10;
            this.Insert.BorderSize = 0;
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Jura", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Image = global::LabTrackSMK.Properties.Resources.insert_light;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Insert.Location = new System.Drawing.Point(9, 8);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(82, 30);
            this.Insert.TabIndex = 60;
            this.Insert.Text = "     Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 61;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 21);
            this.button3.TabIndex = 63;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // masterSiswaReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csPanel1);
            this.Controls.Add(this.password_bx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.username_bx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nama_bx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.perempuan_rd);
            this.Controls.Add(this.laki_rd);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.nis_bx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.kelas_cm);
            this.Name = "MasterSiswa";
            this.Size = new System.Drawing.Size(840, 564);
            this.Load += new System.EventHandler(this.MasterSiswa_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.csPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kelas_cm;
        private System.Windows.Forms.TextBox password_bx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox username_bx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton perempuan_rd;
        private System.Windows.Forms.RadioButton laki_rd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_bx;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox nis_bx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama_bx;
        private LabTrackSMK.Custom_Component.CSbutton Insert;
        private LabTrackSMK.Custom_Component.CSbutton delete;
        private LabTrackSMK.Custom_Component.CSbutton update;
        private LabTrackSMK.Custom_Component.CSbutton ban;
        private LabTrackSMK.Custom_Component.csPanel csPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button button1;
        private Button button3;
    }
}
