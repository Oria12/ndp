
/********************************************************    
**              SAKARYA ÜNİVERSİTESİ
**     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**          NESNEYE DAYALI PROGRAMLAMA DERSİ 
**               2019-2020 BAHAR DÖNEMİ 
**
**                  ÖDEV NUMARASI: 1 
**             ÖĞRENCİ ADI: ORÇUN HOLTA
**            ÖĞRENCİ NUMARASI: B191200300
**               DERSİN ALINDIĞI GRUP: 
*********************************************************/





namespace ndpv1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.karakter = new System.Windows.Forms.PictureBox();
            this.sagd2 = new System.Windows.Forms.PictureBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.sold1 = new System.Windows.Forms.PictureBox();
            this.sagd1 = new System.Windows.Forms.PictureBox();
            this.ustd1 = new System.Windows.Forms.PictureBox();
            this.altd1 = new System.Windows.Forms.PictureBox();
            this.ustd2 = new System.Windows.Forms.PictureBox();
            this.sold2 = new System.Windows.Forms.PictureBox();
            this.altd2 = new System.Windows.Forms.PictureBox();
            this.kronometre = new System.Windows.Forms.Timer(this.components);
            this.survive = new System.Windows.Forms.Label();
            this.kolonya = new System.Windows.Forms.PictureBox();
            this.kolonyaresim = new System.Windows.Forms.PictureBox();
            this.kolonyasayisi = new System.Windows.Forms.Label();
            this.dezenfektan = new System.Windows.Forms.PictureBox();
            this.kolonyapanel = new System.Windows.Forms.Panel();
            this.oyna = new System.Windows.Forms.Button();
            this.nasiloynanir = new System.Windows.Forms.Button();
            this.nasiloynanirpanel = new System.Windows.Forms.Panel();
            this.dezenfektanlabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.amac = new System.Windows.Forms.Label();
            this.ayrac2 = new System.Windows.Forms.Label();
            this.ayrac3 = new System.Windows.Forms.Label();
            this.ayrac1 = new System.Windows.Forms.Label();
            this.dezenfektanlabel = new System.Windows.Forms.Label();
            this.kolonyalabel = new System.Windows.Forms.Label();
            this.virüslabel = new System.Windows.Forms.Label();
            this.karakterlabel = new System.Windows.Forms.Label();
            this.nasiloynanirvirus = new System.Windows.Forms.PictureBox();
            this.nasiloynanirdezenfektan = new System.Windows.Forms.PictureBox();
            this.nasiloynanirkolonya = new System.Windows.Forms.PictureBox();
            this.wasdlabel = new System.Windows.Forms.Label();
            this.nasiloynanirwasd = new System.Windows.Forms.PictureBox();
            this.anamenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonyaresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dezenfektan)).BeginInit();
            this.kolonyapanel.SuspendLayout();
            this.nasiloynanirpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirvirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirdezenfektan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirkolonya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirwasd)).BeginInit();
            this.anamenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // karakter
            // 
            this.karakter.BackColor = System.Drawing.Color.Transparent;
            this.karakter.Image = ((System.Drawing.Image)(resources.GetObject("karakter.Image")));
            this.karakter.Location = new System.Drawing.Point(316, 347);
            this.karakter.Name = "karakter";
            this.karakter.Size = new System.Drawing.Size(65, 50);
            this.karakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.karakter.TabIndex = 0;
            this.karakter.TabStop = false;
            // 
            // sagd2
            // 
            this.sagd2.BackColor = System.Drawing.Color.Transparent;
            this.sagd2.Image = ((System.Drawing.Image)(resources.GetObject("sagd2.Image")));
            this.sagd2.Location = new System.Drawing.Point(627, 199);
            this.sagd2.Name = "sagd2";
            this.sagd2.Size = new System.Drawing.Size(65, 65);
            this.sagd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sagd2.TabIndex = 1;
            this.sagd2.TabStop = false;
            this.sagd2.Tag = "Dusmansag";
            // 
            // zaman
            // 
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // sold1
            // 
            this.sold1.BackColor = System.Drawing.Color.Transparent;
            this.sold1.Image = ((System.Drawing.Image)(resources.GetObject("sold1.Image")));
            this.sold1.Location = new System.Drawing.Point(12, 259);
            this.sold1.Name = "sold1";
            this.sold1.Size = new System.Drawing.Size(65, 65);
            this.sold1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sold1.TabIndex = 3;
            this.sold1.TabStop = false;
            this.sold1.Tag = "Dusmansol";
            // 
            // sagd1
            // 
            this.sagd1.BackColor = System.Drawing.Color.Transparent;
            this.sagd1.Image = ((System.Drawing.Image)(resources.GetObject("sagd1.Image")));
            this.sagd1.Location = new System.Drawing.Point(627, 495);
            this.sagd1.Name = "sagd1";
            this.sagd1.Size = new System.Drawing.Size(65, 65);
            this.sagd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sagd1.TabIndex = 4;
            this.sagd1.TabStop = false;
            this.sagd1.Tag = "Dusmansag";
            // 
            // ustd1
            // 
            this.ustd1.BackColor = System.Drawing.Color.Transparent;
            this.ustd1.Image = ((System.Drawing.Image)(resources.GetObject("ustd1.Image")));
            this.ustd1.Location = new System.Drawing.Point(101, 36);
            this.ustd1.Name = "ustd1";
            this.ustd1.Size = new System.Drawing.Size(65, 65);
            this.ustd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustd1.TabIndex = 5;
            this.ustd1.TabStop = false;
            this.ustd1.Tag = "Dusmanust";
            this.ustd1.Click += new System.EventHandler(this.ustd1_Click);
            // 
            // altd1
            // 
            this.altd1.BackColor = System.Drawing.Color.Transparent;
            this.altd1.Image = ((System.Drawing.Image)(resources.GetObject("altd1.Image")));
            this.altd1.Location = new System.Drawing.Point(174, 604);
            this.altd1.Name = "altd1";
            this.altd1.Size = new System.Drawing.Size(65, 65);
            this.altd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altd1.TabIndex = 6;
            this.altd1.TabStop = false;
            this.altd1.Tag = "Dusmanalt";
            // 
            // ustd2
            // 
            this.ustd2.BackColor = System.Drawing.Color.Transparent;
            this.ustd2.Image = ((System.Drawing.Image)(resources.GetObject("ustd2.Image")));
            this.ustd2.Location = new System.Drawing.Point(548, 36);
            this.ustd2.Name = "ustd2";
            this.ustd2.Size = new System.Drawing.Size(65, 65);
            this.ustd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustd2.TabIndex = 7;
            this.ustd2.TabStop = false;
            this.ustd2.Tag = "Dusmanust";
            this.ustd2.Click += new System.EventHandler(this.ustd2_Click);
            // 
            // sold2
            // 
            this.sold2.BackColor = System.Drawing.Color.Transparent;
            this.sold2.Image = ((System.Drawing.Image)(resources.GetObject("sold2.Image")));
            this.sold2.Location = new System.Drawing.Point(12, 395);
            this.sold2.Name = "sold2";
            this.sold2.Size = new System.Drawing.Size(65, 65);
            this.sold2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sold2.TabIndex = 8;
            this.sold2.TabStop = false;
            this.sold2.Tag = "Dusmansol";
            // 
            // altd2
            // 
            this.altd2.BackColor = System.Drawing.Color.Transparent;
            this.altd2.Image = ((System.Drawing.Image)(resources.GetObject("altd2.Image")));
            this.altd2.Location = new System.Drawing.Point(348, 604);
            this.altd2.Name = "altd2";
            this.altd2.Size = new System.Drawing.Size(65, 65);
            this.altd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altd2.TabIndex = 9;
            this.altd2.TabStop = false;
            this.altd2.Tag = "Dusmanalt";
            // 
            // kronometre
            // 
            this.kronometre.Enabled = true;
            this.kronometre.Interval = 1000;
            this.kronometre.Tick += new System.EventHandler(this.kronometre_Tick);
            // 
            // survive
            // 
            this.survive.AutoSize = true;
            this.survive.BackColor = System.Drawing.Color.Transparent;
            this.survive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.survive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.survive.Location = new System.Drawing.Point(341, 22);
            this.survive.Name = "survive";
            this.survive.Size = new System.Drawing.Size(23, 25);
            this.survive.TabIndex = 10;
            this.survive.Text = "0";
            // 
            // kolonya
            // 
            this.kolonya.BackColor = System.Drawing.Color.Transparent;
            this.kolonya.Image = ((System.Drawing.Image)(resources.GetObject("kolonya.Image")));
            this.kolonya.Location = new System.Drawing.Point(348, 199);
            this.kolonya.Name = "kolonya";
            this.kolonya.Size = new System.Drawing.Size(48, 65);
            this.kolonya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kolonya.TabIndex = 12;
            this.kolonya.TabStop = false;
            // 
            // kolonyaresim
            // 
            this.kolonyaresim.BackColor = System.Drawing.Color.Transparent;
            this.kolonyaresim.Image = ((System.Drawing.Image)(resources.GetObject("kolonyaresim.Image")));
            this.kolonyaresim.Location = new System.Drawing.Point(8, 6);
            this.kolonyaresim.Name = "kolonyaresim";
            this.kolonyaresim.Size = new System.Drawing.Size(32, 42);
            this.kolonyaresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kolonyaresim.TabIndex = 13;
            this.kolonyaresim.TabStop = false;
            // 
            // kolonyasayisi
            // 
            this.kolonyasayisi.AutoSize = true;
            this.kolonyasayisi.BackColor = System.Drawing.Color.Transparent;
            this.kolonyasayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolonyasayisi.ForeColor = System.Drawing.Color.Yellow;
            this.kolonyasayisi.Location = new System.Drawing.Point(43, 15);
            this.kolonyasayisi.Name = "kolonyasayisi";
            this.kolonyasayisi.Size = new System.Drawing.Size(20, 24);
            this.kolonyasayisi.TabIndex = 14;
            this.kolonyasayisi.Text = "0";
            // 
            // dezenfektan
            // 
            this.dezenfektan.BackColor = System.Drawing.Color.Transparent;
            this.dezenfektan.Image = ((System.Drawing.Image)(resources.GetObject("dezenfektan.Image")));
            this.dezenfektan.Location = new System.Drawing.Point(281, 198);
            this.dezenfektan.Name = "dezenfektan";
            this.dezenfektan.Size = new System.Drawing.Size(54, 66);
            this.dezenfektan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dezenfektan.TabIndex = 16;
            this.dezenfektan.TabStop = false;
            // 
            // kolonyapanel
            // 
            this.kolonyapanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.kolonyapanel.Controls.Add(this.kolonyaresim);
            this.kolonyapanel.Controls.Add(this.kolonyasayisi);
            this.kolonyapanel.Location = new System.Drawing.Point(12, 13);
            this.kolonyapanel.Name = "kolonyapanel";
            this.kolonyapanel.Size = new System.Drawing.Size(75, 53);
            this.kolonyapanel.TabIndex = 19;
            // 
            // oyna
            // 
            this.oyna.BackColor = System.Drawing.Color.SeaShell;
            this.oyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyna.Location = new System.Drawing.Point(289, 199);
            this.oyna.Name = "oyna";
            this.oyna.Size = new System.Drawing.Size(155, 87);
            this.oyna.TabIndex = 11;
            this.oyna.Text = "OYNA";
            this.oyna.UseVisualStyleBackColor = false;
            this.oyna.Click += new System.EventHandler(this.oyna_Click);
            this.oyna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tushareket);
            // 
            // nasiloynanir
            // 
            this.nasiloynanir.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nasiloynanir.Location = new System.Drawing.Point(290, 313);
            this.nasiloynanir.Name = "nasiloynanir";
            this.nasiloynanir.Size = new System.Drawing.Size(151, 83);
            this.nasiloynanir.TabIndex = 12;
            this.nasiloynanir.Text = "NASIL OYNANIR";
            this.nasiloynanir.UseVisualStyleBackColor = true;
            this.nasiloynanir.Click += new System.EventHandler(this.nasiloynanir_Click);
            // 
            // nasiloynanirpanel
            // 
            this.nasiloynanirpanel.BackColor = System.Drawing.Color.White;
            this.nasiloynanirpanel.Controls.Add(this.dezenfektanlabel2);
            this.nasiloynanirpanel.Controls.Add(this.pictureBox1);
            this.nasiloynanirpanel.Controls.Add(this.amac);
            this.nasiloynanirpanel.Controls.Add(this.ayrac2);
            this.nasiloynanirpanel.Controls.Add(this.ayrac3);
            this.nasiloynanirpanel.Controls.Add(this.ayrac1);
            this.nasiloynanirpanel.Controls.Add(this.dezenfektanlabel);
            this.nasiloynanirpanel.Controls.Add(this.kolonyalabel);
            this.nasiloynanirpanel.Controls.Add(this.virüslabel);
            this.nasiloynanirpanel.Controls.Add(this.karakterlabel);
            this.nasiloynanirpanel.Controls.Add(this.nasiloynanirvirus);
            this.nasiloynanirpanel.Controls.Add(this.nasiloynanirdezenfektan);
            this.nasiloynanirpanel.Controls.Add(this.nasiloynanirkolonya);
            this.nasiloynanirpanel.Controls.Add(this.wasdlabel);
            this.nasiloynanirpanel.Controls.Add(this.nasiloynanirwasd);
            this.nasiloynanirpanel.Location = new System.Drawing.Point(35, 308);
            this.nasiloynanirpanel.Name = "nasiloynanirpanel";
            this.nasiloynanirpanel.Size = new System.Drawing.Size(653, 339);
            this.nasiloynanirpanel.TabIndex = 14;
            this.nasiloynanirpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nasiloynanirpanel_Paint);
            // 
            // dezenfektanlabel2
            // 
            this.dezenfektanlabel2.AutoSize = true;
            this.dezenfektanlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dezenfektanlabel2.Location = new System.Drawing.Point(326, 314);
            this.dezenfektanlabel2.Name = "dezenfektanlabel2";
            this.dezenfektanlabel2.Size = new System.Drawing.Size(318, 16);
            this.dezenfektanlabel2.TabIndex = 30;
            this.dezenfektanlabel2.Text = "Dezenfektana sahipken karakterinin arkası mavi olur\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // amac
            // 
            this.amac.AutoSize = true;
            this.amac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amac.Location = new System.Drawing.Point(90, 10);
            this.amac.Name = "amac";
            this.amac.Size = new System.Drawing.Size(492, 20);
            this.amac.TabIndex = 28;
            this.amac.Text = "Amaç: Virüslere yakalanmadan olabildiğince fazla süre yaşayabilmek ";
            // 
            // ayrac2
            // 
            this.ayrac2.BackColor = System.Drawing.Color.Gainsboro;
            this.ayrac2.Location = new System.Drawing.Point(3, 136);
            this.ayrac2.Name = "ayrac2";
            this.ayrac2.Size = new System.Drawing.Size(653, 4);
            this.ayrac2.TabIndex = 27;
            // 
            // ayrac3
            // 
            this.ayrac3.BackColor = System.Drawing.Color.Gainsboro;
            this.ayrac3.Location = new System.Drawing.Point(-2, 228);
            this.ayrac3.Name = "ayrac3";
            this.ayrac3.Size = new System.Drawing.Size(653, 4);
            this.ayrac3.TabIndex = 26;
            // 
            // ayrac1
            // 
            this.ayrac1.BackColor = System.Drawing.Color.Gainsboro;
            this.ayrac1.Location = new System.Drawing.Point(0, 36);
            this.ayrac1.Name = "ayrac1";
            this.ayrac1.Size = new System.Drawing.Size(653, 4);
            this.ayrac1.TabIndex = 25;
            // 
            // dezenfektanlabel
            // 
            this.dezenfektanlabel.AutoSize = true;
            this.dezenfektanlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dezenfektanlabel.Location = new System.Drawing.Point(416, 253);
            this.dezenfektanlabel.Name = "dezenfektanlabel";
            this.dezenfektanlabel.Size = new System.Drawing.Size(221, 48);
            this.dezenfektanlabel.TabIndex = 24;
            this.dezenfektanlabel.Text = "Dezenfektan ise süper gücün. \r\nDezenfektanı aldığında \" Q \" tuşu ile \r\nbütün düşm" +
    "anları uzaklaştırabilirsin\r\n";
            // 
            // kolonyalabel
            // 
            this.kolonyalabel.AutoSize = true;
            this.kolonyalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolonyalabel.Location = new System.Drawing.Point(90, 265);
            this.kolonyalabel.Name = "kolonyalabel";
            this.kolonyalabel.Size = new System.Drawing.Size(237, 32);
            this.kolonyalabel.TabIndex = 23;
            this.kolonyalabel.Text = "Kolonyaları topladıkça puan kazanırsın\r\nHer bir kolonya 5 puandır";
            // 
            // virüslabel
            // 
            this.virüslabel.AutoSize = true;
            this.virüslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.virüslabel.Location = new System.Drawing.Point(116, 162);
            this.virüslabel.Name = "virüslabel";
            this.virüslabel.Size = new System.Drawing.Size(373, 48);
            this.virüslabel.TabIndex = 22;
            this.virüslabel.Text = "Virüsler \r\nOnlar senin düşmanların    \r\nDikkat et: Renkleri farklı olanlar rastge" +
    "le yerlerden gelecekler!\r\n";
            // 
            // karakterlabel
            // 
            this.karakterlabel.AutoSize = true;
            this.karakterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karakterlabel.Location = new System.Drawing.Point(116, 78);
            this.karakterlabel.Name = "karakterlabel";
            this.karakterlabel.Size = new System.Drawing.Size(68, 16);
            this.karakterlabel.TabIndex = 21;
            this.karakterlabel.Text = "Karakterin";
            // 
            // nasiloynanirvirus
            // 
            this.nasiloynanirvirus.BackColor = System.Drawing.Color.Transparent;
            this.nasiloynanirvirus.Image = ((System.Drawing.Image)(resources.GetObject("nasiloynanirvirus.Image")));
            this.nasiloynanirvirus.Location = new System.Drawing.Point(30, 151);
            this.nasiloynanirvirus.Name = "nasiloynanirvirus";
            this.nasiloynanirvirus.Size = new System.Drawing.Size(65, 65);
            this.nasiloynanirvirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nasiloynanirvirus.TabIndex = 20;
            this.nasiloynanirvirus.TabStop = false;
            this.nasiloynanirvirus.Tag = "Dusmanust";
            // 
            // nasiloynanirdezenfektan
            // 
            this.nasiloynanirdezenfektan.BackColor = System.Drawing.Color.Transparent;
            this.nasiloynanirdezenfektan.Image = ((System.Drawing.Image)(resources.GetObject("nasiloynanirdezenfektan.Image")));
            this.nasiloynanirdezenfektan.Location = new System.Drawing.Point(349, 243);
            this.nasiloynanirdezenfektan.Name = "nasiloynanirdezenfektan";
            this.nasiloynanirdezenfektan.Size = new System.Drawing.Size(54, 66);
            this.nasiloynanirdezenfektan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nasiloynanirdezenfektan.TabIndex = 20;
            this.nasiloynanirdezenfektan.TabStop = false;
            // 
            // nasiloynanirkolonya
            // 
            this.nasiloynanirkolonya.BackColor = System.Drawing.Color.Transparent;
            this.nasiloynanirkolonya.Image = ((System.Drawing.Image)(resources.GetObject("nasiloynanirkolonya.Image")));
            this.nasiloynanirkolonya.Location = new System.Drawing.Point(35, 248);
            this.nasiloynanirkolonya.Name = "nasiloynanirkolonya";
            this.nasiloynanirkolonya.Size = new System.Drawing.Size(48, 65);
            this.nasiloynanirkolonya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nasiloynanirkolonya.TabIndex = 15;
            this.nasiloynanirkolonya.TabStop = false;
            // 
            // wasdlabel
            // 
            this.wasdlabel.AutoSize = true;
            this.wasdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wasdlabel.Location = new System.Drawing.Point(418, 74);
            this.wasdlabel.Name = "wasdlabel";
            this.wasdlabel.Size = new System.Drawing.Size(188, 32);
            this.wasdlabel.TabIndex = 1;
            this.wasdlabel.Text = "W A S D tuşları ile \r\nkarakterini hareket ettirebilirsin";
            // 
            // nasiloynanirwasd
            // 
            this.nasiloynanirwasd.Image = ((System.Drawing.Image)(resources.GetObject("nasiloynanirwasd.Image")));
            this.nasiloynanirwasd.Location = new System.Drawing.Point(288, 52);
            this.nasiloynanirwasd.Name = "nasiloynanirwasd";
            this.nasiloynanirwasd.Size = new System.Drawing.Size(111, 74);
            this.nasiloynanirwasd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nasiloynanirwasd.TabIndex = 0;
            this.nasiloynanirwasd.TabStop = false;
            // 
            // anamenu
            // 
            this.anamenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anamenu.BackgroundImage")));
            this.anamenu.Controls.Add(this.nasiloynanirpanel);
            this.anamenu.Controls.Add(this.nasiloynanir);
            this.anamenu.Controls.Add(this.oyna);
            this.anamenu.Location = new System.Drawing.Point(-9, 0);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(714, 683);
            this.anamenu.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.kolonyapanel);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.dezenfektan);
            this.Controls.Add(this.kolonya);
            this.Controls.Add(this.survive);
            this.Controls.Add(this.altd2);
            this.Controls.Add(this.sold2);
            this.Controls.Add(this.ustd2);
            this.Controls.Add(this.altd1);
            this.Controls.Add(this.ustd1);
            this.Controls.Add(this.sagd1);
            this.Controls.Add(this.sold1);
            this.Controls.Add(this.sagd2);
            this.Controls.Add(this.karakter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escape From Corona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tushareket);
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonyaresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dezenfektan)).EndInit();
            this.kolonyapanel.ResumeLayout(false);
            this.kolonyapanel.PerformLayout();
            this.nasiloynanirpanel.ResumeLayout(false);
            this.nasiloynanirpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirvirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirdezenfektan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirkolonya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasiloynanirwasd)).EndInit();
            this.anamenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox karakter;
        private System.Windows.Forms.PictureBox sagd2;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.PictureBox sold1;
        private System.Windows.Forms.PictureBox sagd1;
        private System.Windows.Forms.PictureBox ustd1;
        private System.Windows.Forms.PictureBox altd1;
        private System.Windows.Forms.PictureBox ustd2;
        private System.Windows.Forms.PictureBox sold2;
        private System.Windows.Forms.PictureBox altd2;
        private System.Windows.Forms.Timer kronometre;
        private System.Windows.Forms.Label survive;
        private System.Windows.Forms.PictureBox kolonya;
        private System.Windows.Forms.PictureBox kolonyaresim;
        private System.Windows.Forms.Label kolonyasayisi;
        private System.Windows.Forms.PictureBox dezenfektan;
        private System.Windows.Forms.Panel kolonyapanel;
        private System.Windows.Forms.Button oyna;
        private System.Windows.Forms.Button nasiloynanir;
        private System.Windows.Forms.Panel nasiloynanirpanel;
        private System.Windows.Forms.Label dezenfektanlabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label amac;
        private System.Windows.Forms.Label ayrac2;
        private System.Windows.Forms.Label ayrac3;
        private System.Windows.Forms.Label ayrac1;
        private System.Windows.Forms.Label dezenfektanlabel;
        private System.Windows.Forms.Label kolonyalabel;
        private System.Windows.Forms.Label virüslabel;
        private System.Windows.Forms.Label karakterlabel;
        private System.Windows.Forms.PictureBox nasiloynanirvirus;
        private System.Windows.Forms.PictureBox nasiloynanirdezenfektan;
        private System.Windows.Forms.PictureBox nasiloynanirkolonya;
        private System.Windows.Forms.Label wasdlabel;
        private System.Windows.Forms.PictureBox nasiloynanirwasd;
        private System.Windows.Forms.Panel anamenu;
    }
}

