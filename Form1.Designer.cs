namespace VTYS_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDataCtrl = new System.Windows.Forms.Button();
            this.btnUserCtrl = new System.Windows.Forms.Button();
            this.btnRobotCtrl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lbYanlis = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.RobotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRobotBaslat = new System.Windows.Forms.Button();
            this.btnRobotDurdur = new System.Windows.Forms.Button();
            this.btnRobotCikar = new System.Windows.Forms.Button();
            this.btnYeniRobot = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbSutunlardanOku = new System.Windows.Forms.Label();
            this.lbTekParcadanOku = new System.Windows.Forms.Label();
            this.btnSutunlardanOku = new System.Windows.Forms.Button();
            this.btnTekParcadanOku = new System.Windows.Forms.Button();
            this.btnAyri = new System.Windows.Forms.Button();
            this.btnTekParca = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TekParcaEkleSure = new System.Windows.Forms.Label();
            this.SutunlaraAyirEkleSure = new System.Windows.Forms.Label();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnDataCtrl);
            this.panel1.Controls.Add(this.btnUserCtrl);
            this.panel1.Controls.Add(this.btnRobotCtrl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 121);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 95);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "          ANA SAYFA";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDataCtrl
            // 
            this.btnDataCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDataCtrl.Image = ((System.Drawing.Image)(resources.GetObject("btnDataCtrl.Image")));
            this.btnDataCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataCtrl.Location = new System.Drawing.Point(3, 424);
            this.btnDataCtrl.Name = "btnDataCtrl";
            this.btnDataCtrl.Size = new System.Drawing.Size(186, 95);
            this.btnDataCtrl.TabIndex = 1;
            this.btnDataCtrl.Text = "       ROBOT\r\n        VERİ";
            this.btnDataCtrl.UseVisualStyleBackColor = true;
            this.btnDataCtrl.Click += new System.EventHandler(this.btnDataCtrl_Click);
            // 
            // btnUserCtrl
            // 
            this.btnUserCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserCtrl.Image = ((System.Drawing.Image)(resources.GetObject("btnUserCtrl.Image")));
            this.btnUserCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCtrl.Location = new System.Drawing.Point(4, 323);
            this.btnUserCtrl.Name = "btnUserCtrl";
            this.btnUserCtrl.Size = new System.Drawing.Size(185, 95);
            this.btnUserCtrl.TabIndex = 1;
            this.btnUserCtrl.Text = "    KULLANICI\r\n    BİLGİSİ";
            this.btnUserCtrl.UseVisualStyleBackColor = true;
            this.btnUserCtrl.Click += new System.EventHandler(this.btnUserCtrl_Click);
            // 
            // btnRobotCtrl
            // 
            this.btnRobotCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobotCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRobotCtrl.Image = ((System.Drawing.Image)(resources.GetObject("btnRobotCtrl.Image")));
            this.btnRobotCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotCtrl.Location = new System.Drawing.Point(3, 222);
            this.btnRobotCtrl.Name = "btnRobotCtrl";
            this.btnRobotCtrl.Size = new System.Drawing.Size(186, 95);
            this.btnRobotCtrl.TabIndex = 1;
            this.btnRobotCtrl.Text = "    ROBOT\r\n    KONTROL";
            this.btnRobotCtrl.UseVisualStyleBackColor = true;
            this.btnRobotCtrl.Click += new System.EventHandler(this.btnRobotCtrl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 97);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 97);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(196, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 574);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pnlLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lbYanlis);
            this.pnlLogin.Controls.Add(this.btnGiris);
            this.pnlLogin.Controls.Add(this.tbPass);
            this.pnlLogin.Controls.Add(this.tbUsername);
            this.pnlLogin.Controls.Add(this.label21);
            this.pnlLogin.Controls.Add(this.label20);
            this.pnlLogin.Location = new System.Drawing.Point(766, 503);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1003, 680);
            this.pnlLogin.TabIndex = 6;
            // 
            // lbYanlis
            // 
            this.lbYanlis.AutoSize = true;
            this.lbYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYanlis.ForeColor = System.Drawing.Color.Red;
            this.lbYanlis.Location = new System.Drawing.Point(388, 519);
            this.lbYanlis.Name = "lbYanlis";
            this.lbYanlis.Size = new System.Drawing.Size(205, 24);
            this.lbYanlis.TabIndex = 4;
            this.lbYanlis.Text = "Girilen bilgiler yanlış.";
            this.lbYanlis.Visible = false;
            // 
            // btnGiris
            // 
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(404, 395);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(186, 55);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPass.Location = new System.Drawing.Point(463, 332);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(165, 22);
            this.tbPass.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUsername.Location = new System.Drawing.Point(463, 279);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(165, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(359, 332);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Şifre:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(282, 277);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(311, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoş geldiniz ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.btnRobotBaslat);
            this.tabPage2.Controls.Add(this.btnRobotDurdur);
            this.tabPage2.Controls.Add(this.btnRobotCikar);
            this.tabPage2.Controls.Add(this.btnYeniRobot);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotID,
            this.Durum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(298, 34);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(443, 459);
            this.dgv.TabIndex = 5;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // RobotID
            // 
            this.RobotID.HeaderText = "Robot ID";
            this.RobotID.Name = "RobotID";
            this.RobotID.ReadOnly = true;
            this.RobotID.Width = 200;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 200;
            // 
            // btnRobotBaslat
            // 
            this.btnRobotBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobotBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRobotBaslat.Image = ((System.Drawing.Image)(resources.GetObject("btnRobotBaslat.Image")));
            this.btnRobotBaslat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotBaslat.Location = new System.Drawing.Point(37, 106);
            this.btnRobotBaslat.Name = "btnRobotBaslat";
            this.btnRobotBaslat.Size = new System.Drawing.Size(156, 66);
            this.btnRobotBaslat.TabIndex = 3;
            this.btnRobotBaslat.Text = "Çalıştır";
            this.btnRobotBaslat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRobotBaslat.UseVisualStyleBackColor = true;
            this.btnRobotBaslat.Click += new System.EventHandler(this.btnRobotBaslat_Click);
            // 
            // btnRobotDurdur
            // 
            this.btnRobotDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobotDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRobotDurdur.Image = ((System.Drawing.Image)(resources.GetObject("btnRobotDurdur.Image")));
            this.btnRobotDurdur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotDurdur.Location = new System.Drawing.Point(37, 178);
            this.btnRobotDurdur.Name = "btnRobotDurdur";
            this.btnRobotDurdur.Size = new System.Drawing.Size(156, 66);
            this.btnRobotDurdur.TabIndex = 4;
            this.btnRobotDurdur.Text = "Durdur";
            this.btnRobotDurdur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRobotDurdur.UseVisualStyleBackColor = true;
            this.btnRobotDurdur.Click += new System.EventHandler(this.btnRobotDurdur_Click);
            // 
            // btnRobotCikar
            // 
            this.btnRobotCikar.Enabled = false;
            this.btnRobotCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobotCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRobotCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnRobotCikar.Image")));
            this.btnRobotCikar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotCikar.Location = new System.Drawing.Point(37, 351);
            this.btnRobotCikar.Name = "btnRobotCikar";
            this.btnRobotCikar.Size = new System.Drawing.Size(156, 66);
            this.btnRobotCikar.TabIndex = 3;
            this.btnRobotCikar.Text = "Robot Çıkar";
            this.btnRobotCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRobotCikar.UseVisualStyleBackColor = true;
            // 
            // btnYeniRobot
            // 
            this.btnYeniRobot.Enabled = false;
            this.btnYeniRobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnYeniRobot.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRobot.Image")));
            this.btnYeniRobot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniRobot.Location = new System.Drawing.Point(37, 279);
            this.btnYeniRobot.Name = "btnYeniRobot";
            this.btnYeniRobot.Size = new System.Drawing.Size(156, 66);
            this.btnYeniRobot.TabIndex = 2;
            this.btnYeniRobot.Text = "Yeni Robot";
            this.btnYeniRobot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniRobot.UseVisualStyleBackColor = true;
            this.btnYeniRobot.Click += new System.EventHandler(this.btnRobotEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(803, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label22.Location = new System.Drawing.Point(248, 185);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 29);
            this.label22.TabIndex = 0;
            this.label22.Text = "Yönetici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(68, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetki düzeyi:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage4.Controls.Add(this.lbSutunlardanOku);
            this.tabPage4.Controls.Add(this.lbTekParcadanOku);
            this.tabPage4.Controls.Add(this.btnSutunlardanOku);
            this.tabPage4.Controls.Add(this.btnTekParcadanOku);
            this.tabPage4.Controls.Add(this.btnAyri);
            this.tabPage4.Controls.Add(this.btnTekParca);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.TekParcaEkleSure);
            this.tabPage4.Controls.Add(this.SutunlaraAyirEkleSure);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 548);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // lbSutunlardanOku
            // 
            this.lbSutunlardanOku.AutoSize = true;
            this.lbSutunlardanOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSutunlardanOku.Location = new System.Drawing.Point(252, 207);
            this.lbSutunlardanOku.Name = "lbSutunlardanOku";
            this.lbSutunlardanOku.Size = new System.Drawing.Size(47, 20);
            this.lbSutunlardanOku.TabIndex = 12;
            this.lbSutunlardanOku.Text = "Süre:";
            // 
            // lbTekParcadanOku
            // 
            this.lbTekParcadanOku.AutoSize = true;
            this.lbTekParcadanOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTekParcadanOku.Location = new System.Drawing.Point(252, 152);
            this.lbTekParcadanOku.Name = "lbTekParcadanOku";
            this.lbTekParcadanOku.Size = new System.Drawing.Size(47, 20);
            this.lbTekParcadanOku.TabIndex = 11;
            this.lbTekParcadanOku.Text = "Süre:";
            // 
            // btnSutunlardanOku
            // 
            this.btnSutunlardanOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSutunlardanOku.ForeColor = System.Drawing.Color.Black;
            this.btnSutunlardanOku.Location = new System.Drawing.Point(58, 193);
            this.btnSutunlardanOku.Name = "btnSutunlardanOku";
            this.btnSutunlardanOku.Size = new System.Drawing.Size(187, 40);
            this.btnSutunlardanOku.TabIndex = 10;
            this.btnSutunlardanOku.Text = "Tablodan Oku";
            this.btnSutunlardanOku.UseVisualStyleBackColor = true;
            this.btnSutunlardanOku.Click += new System.EventHandler(this.btnSutunlardanOku_Click);
            // 
            // btnTekParcadanOku
            // 
            this.btnTekParcadanOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekParcadanOku.ForeColor = System.Drawing.Color.Black;
            this.btnTekParcadanOku.Location = new System.Drawing.Point(58, 140);
            this.btnTekParcadanOku.Name = "btnTekParcadanOku";
            this.btnTekParcadanOku.Size = new System.Drawing.Size(187, 36);
            this.btnTekParcadanOku.TabIndex = 9;
            this.btnTekParcadanOku.Text = "Tek Parça Olarak Oku";
            this.btnTekParcadanOku.UseVisualStyleBackColor = true;
            this.btnTekParcadanOku.Click += new System.EventHandler(this.btnTekParcadanOku_Click);
            // 
            // btnAyri
            // 
            this.btnAyri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyri.ForeColor = System.Drawing.Color.Black;
            this.btnAyri.Location = new System.Drawing.Point(58, 88);
            this.btnAyri.Name = "btnAyri";
            this.btnAyri.Size = new System.Drawing.Size(187, 40);
            this.btnAyri.TabIndex = 8;
            this.btnAyri.Text = "Sütunlara Ayırarak Ekle";
            this.btnAyri.UseVisualStyleBackColor = true;
            this.btnAyri.Click += new System.EventHandler(this.btnAyri_Click);
            // 
            // btnTekParca
            // 
            this.btnTekParca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekParca.ForeColor = System.Drawing.Color.Black;
            this.btnTekParca.Location = new System.Drawing.Point(58, 38);
            this.btnTekParca.Name = "btnTekParca";
            this.btnTekParca.Size = new System.Drawing.Size(187, 36);
            this.btnTekParca.TabIndex = 7;
            this.btnTekParca.Text = "Tek Parça Olarak Ekle";
            this.btnTekParca.UseVisualStyleBackColor = true;
            this.btnTekParca.Click += new System.EventHandler(this.btnTekParca_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-4, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 3);
            this.panel3.TabIndex = 6;
            // 
            // TekParcaEkleSure
            // 
            this.TekParcaEkleSure.AutoSize = true;
            this.TekParcaEkleSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekParcaEkleSure.Location = new System.Drawing.Point(251, 46);
            this.TekParcaEkleSure.Name = "TekParcaEkleSure";
            this.TekParcaEkleSure.Size = new System.Drawing.Size(47, 20);
            this.TekParcaEkleSure.TabIndex = 2;
            this.TekParcaEkleSure.Text = "Süre:";
            // 
            // SutunlaraAyirEkleSure
            // 
            this.SutunlaraAyirEkleSure.AutoSize = true;
            this.SutunlaraAyirEkleSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SutunlaraAyirEkleSure.Location = new System.Drawing.Point(251, 98);
            this.SutunlaraAyirEkleSure.Name = "SutunlaraAyirEkleSure";
            this.SutunlaraAyirEkleSure.Size = new System.Drawing.Size(47, 20);
            this.SutunlaraAyirEkleSure.TabIndex = 2;
            this.SutunlaraAyirEkleSure.Text = "Süre:";
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(231)))), ((int)(((byte)(22)))));
            this.panelSelect.Location = new System.Drawing.Point(190, 119);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(10, 91);
            this.panelSelect.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(967, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(200, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 38);
            this.panel4.TabIndex = 4;
            // 
            // btnYok
            // 
            this.btnYok.Location = new System.Drawing.Point(736, -86);
            this.btnYok.Name = "btnYok";
            this.btnYok.Size = new System.Drawing.Size(75, 23);
            this.btnYok.TabIndex = 5;
            this.btnYok.Text = "button3";
            this.btnYok.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnYok);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDataCtrl;
        private System.Windows.Forms.Button btnUserCtrl;
        private System.Windows.Forms.Button btnRobotCtrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniRobot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRobotBaslat;
        private System.Windows.Forms.Button btnRobotDurdur;
        private System.Windows.Forms.Button btnRobotCikar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SutunlaraAyirEkleSure;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnYok;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbYanlis;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.Button btnAyri;
        private System.Windows.Forms.Button btnTekParca;
        private System.Windows.Forms.Label TekParcaEkleSure;
        private System.Windows.Forms.Label lbSutunlardanOku;
        private System.Windows.Forms.Label lbTekParcadanOku;
        private System.Windows.Forms.Button btnSutunlardanOku;
        private System.Windows.Forms.Button btnTekParcadanOku;
    }
}

