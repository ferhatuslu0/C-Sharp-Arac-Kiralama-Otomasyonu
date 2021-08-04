namespace _33RENTACAR
{
    partial class frm_Aracİslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Aracİslemler));
            this.dgv_aracİslemleri = new System.Windows.Forms.DataGridView();
            this.grpbx_AracEkleme = new System.Windows.Forms.GroupBox();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.cmb_garanti = new System.Windows.Forms.ComboBox();
            this.cmb_Yil = new System.Windows.Forms.ComboBox();
            this.cmb_Renk = new System.Windows.Forms.ComboBox();
            this.lbl_Yil = new System.Windows.Forms.Label();
            this.txt_AracPlaka = new System.Windows.Forms.TextBox();
            this.lbl_AracRenk = new System.Windows.Forms.Label();
            this.lbl_AracModel = new System.Windows.Forms.Label();
            this.lbl_Seri = new System.Windows.Forms.Label();
            this.lbl_AracMarka = new System.Windows.Forms.Label();
            this.lbl_AracPlaka = new System.Windows.Forms.Label();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.ilistaracİslem = new System.Windows.Forms.ImageList(this.components);
            this.btn_temizle = new System.Windows.Forms.Button();
            this.cmb_MotorGucu = new System.Windows.Forms.ComboBox();
            this.cmb_MotorHacmi = new System.Windows.Forms.ComboBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_AracGuncelle = new System.Windows.Forms.Button();
            this.btn_AracEkle = new System.Windows.Forms.Button();
            this.lbl_Klima = new System.Windows.Forms.Label();
            this.lbl_MotorGücü = new System.Windows.Forms.Label();
            this.lbl_mHacmi = new System.Windows.Forms.Label();
            this.llb_km = new System.Windows.Forms.Label();
            this.lbl_vites = new System.Windows.Forms.Label();
            this.lbl_Yakit = new System.Windows.Forms.Label();
            this.cmb_Klima = new System.Windows.Forms.ComboBox();
            this.cmb_vitesTipi = new System.Windows.Forms.ComboBox();
            this.cmb_yakit = new System.Windows.Forms.ComboBox();
            this.txt_Km = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracİslemleri)).BeginInit();
            this.grpbx_AracEkleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_aracİslemleri
            // 
            this.dgv_aracİslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aracİslemleri.Location = new System.Drawing.Point(800, 437);
            this.dgv_aracİslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_aracİslemleri.Name = "dgv_aracİslemleri";
            this.dgv_aracİslemleri.Size = new System.Drawing.Size(989, 426);
            this.dgv_aracİslemleri.TabIndex = 0;
            this.dgv_aracİslemleri.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_aracİslemleri_CellFormatting);
            this.dgv_aracİslemleri.Click += new System.EventHandler(this.dgv_aracİslemleri_Click);
            // 
            // grpbx_AracEkleme
            // 
            this.grpbx_AracEkleme.BackColor = System.Drawing.Color.DarkRed;
            this.grpbx_AracEkleme.Controls.Add(this.cmb_Marka);
            this.grpbx_AracEkleme.Controls.Add(this.cmb_Model);
            this.grpbx_AracEkleme.Controls.Add(this.cmb_garanti);
            this.grpbx_AracEkleme.Controls.Add(this.cmb_Yil);
            this.grpbx_AracEkleme.Controls.Add(this.cmb_Renk);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_Yil);
            this.grpbx_AracEkleme.Controls.Add(this.txt_AracPlaka);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_AracRenk);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_AracModel);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_Seri);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_AracMarka);
            this.grpbx_AracEkleme.Controls.Add(this.lbl_AracPlaka);
            this.grpbx_AracEkleme.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbx_AracEkleme.ForeColor = System.Drawing.Color.White;
            this.grpbx_AracEkleme.Location = new System.Drawing.Point(364, 46);
            this.grpbx_AracEkleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbx_AracEkleme.Name = "grpbx_AracEkleme";
            this.grpbx_AracEkleme.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbx_AracEkleme.Size = new System.Drawing.Size(428, 386);
            this.grpbx_AracEkleme.TabIndex = 12;
            this.grpbx_AracEkleme.TabStop = false;
            this.grpbx_AracEkleme.Text = "Araç Bilgileri";
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Location = new System.Drawing.Point(201, 101);
            this.cmb_Marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(184, 30);
            this.cmb_Marka.TabIndex = 2;
            this.cmb_Marka.SelectedIndexChanged += new System.EventHandler(this.cmb_Marka_SelectedIndexChanged);
            // 
            // cmb_Model
            // 
            this.cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.Location = new System.Drawing.Point(201, 154);
            this.cmb_Model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(184, 30);
            this.cmb_Model.TabIndex = 3;
            // 
            // cmb_garanti
            // 
            this.cmb_garanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_garanti.FormattingEnabled = true;
            this.cmb_garanti.Items.AddRange(new object[] {
            "Seçiniz ..",
            "Evet",
            "Hayır"});
            this.cmb_garanti.Location = new System.Drawing.Point(201, 201);
            this.cmb_garanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_garanti.Name = "cmb_garanti";
            this.cmb_garanti.Size = new System.Drawing.Size(184, 30);
            this.cmb_garanti.TabIndex = 4;
            // 
            // cmb_Yil
            // 
            this.cmb_Yil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Yil.FormattingEnabled = true;
            this.cmb_Yil.Items.AddRange(new object[] {
            "Seçiniz ..",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cmb_Yil.Location = new System.Drawing.Point(201, 252);
            this.cmb_Yil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Yil.Name = "cmb_Yil";
            this.cmb_Yil.Size = new System.Drawing.Size(184, 30);
            this.cmb_Yil.TabIndex = 5;
            // 
            // cmb_Renk
            // 
            this.cmb_Renk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Renk.FormattingEnabled = true;
            this.cmb_Renk.Items.AddRange(new object[] {
            "Seçiniz ..",
            "Beyaz",
            "Siyah",
            "Gri",
            "Mavi",
            "Sarı",
            "Kırmızı",
            "Kahverengi",
            "Bordo",
            "Yeşil",
            "Turuncu",
            "Krem ",
            "Lacivert"});
            this.cmb_Renk.Location = new System.Drawing.Point(201, 305);
            this.cmb_Renk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Renk.Name = "cmb_Renk";
            this.cmb_Renk.Size = new System.Drawing.Size(184, 30);
            this.cmb_Renk.TabIndex = 6;
            // 
            // lbl_Yil
            // 
            this.lbl_Yil.AutoSize = true;
            this.lbl_Yil.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yil.ForeColor = System.Drawing.Color.White;
            this.lbl_Yil.Location = new System.Drawing.Point(133, 261);
            this.lbl_Yil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Yil.Name = "lbl_Yil";
            this.lbl_Yil.Size = new System.Drawing.Size(41, 24);
            this.lbl_Yil.TabIndex = 29;
            this.lbl_Yil.Text = "Yıl:";
            // 
            // txt_AracPlaka
            // 
            this.txt_AracPlaka.Location = new System.Drawing.Point(201, 49);
            this.txt_AracPlaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_AracPlaka.Name = "txt_AracPlaka";
            this.txt_AracPlaka.Size = new System.Drawing.Size(184, 29);
            this.txt_AracPlaka.TabIndex = 1;
            // 
            // lbl_AracRenk
            // 
            this.lbl_AracRenk.AutoSize = true;
            this.lbl_AracRenk.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AracRenk.ForeColor = System.Drawing.Color.White;
            this.lbl_AracRenk.Location = new System.Drawing.Point(113, 313);
            this.lbl_AracRenk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AracRenk.Name = "lbl_AracRenk";
            this.lbl_AracRenk.Size = new System.Drawing.Size(62, 24);
            this.lbl_AracRenk.TabIndex = 10;
            this.lbl_AracRenk.Text = "Renk:";
            // 
            // lbl_AracModel
            // 
            this.lbl_AracModel.AutoSize = true;
            this.lbl_AracModel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AracModel.ForeColor = System.Drawing.Color.White;
            this.lbl_AracModel.Location = new System.Drawing.Point(99, 164);
            this.lbl_AracModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AracModel.Name = "lbl_AracModel";
            this.lbl_AracModel.Size = new System.Drawing.Size(71, 24);
            this.lbl_AracModel.TabIndex = 9;
            this.lbl_AracModel.Text = "Model:";
            // 
            // lbl_Seri
            // 
            this.lbl_Seri.AutoSize = true;
            this.lbl_Seri.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Seri.ForeColor = System.Drawing.Color.White;
            this.lbl_Seri.Location = new System.Drawing.Point(89, 208);
            this.lbl_Seri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seri.Name = "lbl_Seri";
            this.lbl_Seri.Size = new System.Drawing.Size(85, 24);
            this.lbl_Seri.TabIndex = 8;
            this.lbl_Seri.Text = "Garanti:";
            // 
            // lbl_AracMarka
            // 
            this.lbl_AracMarka.AutoSize = true;
            this.lbl_AracMarka.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AracMarka.ForeColor = System.Drawing.Color.White;
            this.lbl_AracMarka.Location = new System.Drawing.Point(44, 107);
            this.lbl_AracMarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AracMarka.Name = "lbl_AracMarka";
            this.lbl_AracMarka.Size = new System.Drawing.Size(139, 24);
            this.lbl_AracMarka.TabIndex = 7;
            this.lbl_AracMarka.Text = "Araç Markası:";
            // 
            // lbl_AracPlaka
            // 
            this.lbl_AracPlaka.AutoSize = true;
            this.lbl_AracPlaka.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AracPlaka.ForeColor = System.Drawing.Color.White;
            this.lbl_AracPlaka.Location = new System.Drawing.Point(44, 53);
            this.lbl_AracPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AracPlaka.Name = "lbl_AracPlaka";
            this.lbl_AracPlaka.Size = new System.Drawing.Size(132, 24);
            this.lbl_AracPlaka.TabIndex = 6;
            this.lbl_AracPlaka.Text = "Araç Plakası:";
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kapat.ForeColor = System.Drawing.Color.Black;
            this.Btn_Kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Kapat.ImageKey = "kapat.png";
            this.Btn_Kapat.ImageList = this.ilistaracİslem;
            this.Btn_Kapat.Location = new System.Drawing.Point(1624, 361);
            this.Btn_Kapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(165, 64);
            this.Btn_Kapat.TabIndex = 17;
            this.Btn_Kapat.Text = "Kapat";
            this.Btn_Kapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Kapat.UseVisualStyleBackColor = true;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // ilistaracİslem
            // 
            this.ilistaracİslem.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistaracİslem.ImageStream")));
            this.ilistaracİslem.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistaracİslem.Images.SetKeyName(0, "aracEkle.png");
            this.ilistaracİslem.Images.SetKeyName(1, "sil.png");
            this.ilistaracİslem.Images.SetKeyName(2, "guncelle.png");
            this.ilistaracİslem.Images.SetKeyName(3, "temizle.png");
            this.ilistaracİslem.Images.SetKeyName(4, "kapat.png");
            this.ilistaracİslem.Images.SetKeyName(5, "mercek.png");
            // 
            // btn_temizle
            // 
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_temizle.ImageIndex = 3;
            this.btn_temizle.ImageList = this.ilistaracİslem;
            this.btn_temizle.Location = new System.Drawing.Point(1414, 361);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(165, 64);
            this.btn_temizle.TabIndex = 16;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // cmb_MotorGucu
            // 
            this.cmb_MotorGucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MotorGucu.FormattingEnabled = true;
            this.cmb_MotorGucu.Items.AddRange(new object[] {
            "Seçiniz ..",
            "50 HP\'ye kadar",
            "51 - 75 HP",
            "76 - 100 HP",
            "101 - 125 HP",
            "126 - 150 HP",
            "151 - 175 HP",
            "176 - 200 HP",
            "201 - 225 HP",
            "226 - 250 HP",
            "251 - 275 HP",
            "276 - 300 HP",
            "301 - 325 HP",
            "326 - 350 HP",
            "351 - 375 HP",
            "376 - 400 HP",
            "401 - 425 HP",
            "426 - 450 HP",
            "451 - 475 HP",
            "476 - 500 HP",
            "501 - 525 HP",
            "526 - 550 HP",
            "551 - 575 HP",
            "576 - 600 HP",
            "601 HP ve üzeri .."});
            this.cmb_MotorGucu.Location = new System.Drawing.Point(201, 262);
            this.cmb_MotorGucu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_MotorGucu.Name = "cmb_MotorGucu";
            this.cmb_MotorGucu.Size = new System.Drawing.Size(184, 30);
            this.cmb_MotorGucu.TabIndex = 11;
            // 
            // cmb_MotorHacmi
            // 
            this.cmb_MotorHacmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MotorHacmi.FormattingEnabled = true;
            this.cmb_MotorHacmi.Items.AddRange(new object[] {
            "Seçiniz ..",
            "1200 cm3\'e kadar",
            "1201 - 1400 cm3",
            "1401 - 1600 cm3",
            "1601 - 1800 cm3",
            "1801 - 2000 cm3",
            "2001 - 2500 cm3",
            "2501 - 3000 cm3",
            "3001 - 3500 cm3",
            "3501 - 4000 cm3",
            "4001 - 4500 cm3",
            "5001 - 5500 cm3",
            "5501 - 6000 cm3",
            "6001 cm3 ve üzeri .."});
            this.cmb_MotorHacmi.Location = new System.Drawing.Point(201, 210);
            this.cmb_MotorHacmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_MotorHacmi.Name = "cmb_MotorHacmi";
            this.cmb_MotorHacmi.Size = new System.Drawing.Size(184, 30);
            this.cmb_MotorHacmi.TabIndex = 10;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.ImageIndex = 1;
            this.btn_Sil.ImageList = this.ilistaracİslem;
            this.btn_Sil.Location = new System.Drawing.Point(1211, 361);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(165, 64);
            this.btn_Sil.TabIndex = 14;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_AracGuncelle
            // 
            this.btn_AracGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AracGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AracGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_AracGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AracGuncelle.ImageIndex = 2;
            this.btn_AracGuncelle.ImageList = this.ilistaracİslem;
            this.btn_AracGuncelle.Location = new System.Drawing.Point(1008, 361);
            this.btn_AracGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AracGuncelle.Name = "btn_AracGuncelle";
            this.btn_AracGuncelle.Size = new System.Drawing.Size(165, 64);
            this.btn_AracGuncelle.TabIndex = 15;
            this.btn_AracGuncelle.Text = "Güncelle";
            this.btn_AracGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AracGuncelle.UseVisualStyleBackColor = true;
            this.btn_AracGuncelle.Click += new System.EventHandler(this.btn_AracGuncelle_Click);
            // 
            // btn_AracEkle
            // 
            this.btn_AracEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AracEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_AracEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AracEkle.ImageKey = "aracEkle.png";
            this.btn_AracEkle.ImageList = this.ilistaracİslem;
            this.btn_AracEkle.Location = new System.Drawing.Point(802, 361);
            this.btn_AracEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AracEkle.Name = "btn_AracEkle";
            this.btn_AracEkle.Size = new System.Drawing.Size(165, 64);
            this.btn_AracEkle.TabIndex = 13;
            this.btn_AracEkle.Text = "Arac Ekle";
            this.btn_AracEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AracEkle.UseVisualStyleBackColor = true;
            this.btn_AracEkle.Click += new System.EventHandler(this.btn_AracEkle_Click);
            // 
            // lbl_Klima
            // 
            this.lbl_Klima.AutoSize = true;
            this.lbl_Klima.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Klima.ForeColor = System.Drawing.Color.White;
            this.lbl_Klima.Location = new System.Drawing.Point(88, 329);
            this.lbl_Klima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Klima.Name = "lbl_Klima";
            this.lbl_Klima.Size = new System.Drawing.Size(70, 24);
            this.lbl_Klima.TabIndex = 27;
            this.lbl_Klima.Text = "Klima:";
            // 
            // lbl_MotorGücü
            // 
            this.lbl_MotorGücü.AutoSize = true;
            this.lbl_MotorGücü.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MotorGücü.ForeColor = System.Drawing.Color.White;
            this.lbl_MotorGücü.Location = new System.Drawing.Point(40, 271);
            this.lbl_MotorGücü.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MotorGücü.Name = "lbl_MotorGücü";
            this.lbl_MotorGücü.Size = new System.Drawing.Size(123, 24);
            this.lbl_MotorGücü.TabIndex = 26;
            this.lbl_MotorGücü.Text = "Motor Gücü:";
            // 
            // lbl_mHacmi
            // 
            this.lbl_mHacmi.AutoSize = true;
            this.lbl_mHacmi.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mHacmi.ForeColor = System.Drawing.Color.White;
            this.lbl_mHacmi.Location = new System.Drawing.Point(31, 217);
            this.lbl_mHacmi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mHacmi.Name = "lbl_mHacmi";
            this.lbl_mHacmi.Size = new System.Drawing.Size(135, 24);
            this.lbl_mHacmi.TabIndex = 25;
            this.lbl_mHacmi.Text = "Motor Hacmi:";
            // 
            // llb_km
            // 
            this.llb_km.AutoSize = true;
            this.llb_km.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llb_km.ForeColor = System.Drawing.Color.White;
            this.llb_km.Location = new System.Drawing.Point(111, 165);
            this.llb_km.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_km.Name = "llb_km";
            this.llb_km.Size = new System.Drawing.Size(46, 24);
            this.llb_km.TabIndex = 24;
            this.llb_km.Text = "KM:";
            // 
            // lbl_vites
            // 
            this.lbl_vites.AutoSize = true;
            this.lbl_vites.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vites.ForeColor = System.Drawing.Color.White;
            this.lbl_vites.Location = new System.Drawing.Point(59, 108);
            this.lbl_vites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vites.Name = "lbl_vites";
            this.lbl_vites.Size = new System.Drawing.Size(105, 24);
            this.lbl_vites.TabIndex = 23;
            this.lbl_vites.Text = "Vites Tipi:";
            // 
            // lbl_Yakit
            // 
            this.lbl_Yakit.AutoSize = true;
            this.lbl_Yakit.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yakit.ForeColor = System.Drawing.Color.White;
            this.lbl_Yakit.Location = new System.Drawing.Point(95, 54);
            this.lbl_Yakit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Yakit.Name = "lbl_Yakit";
            this.lbl_Yakit.Size = new System.Drawing.Size(64, 24);
            this.lbl_Yakit.TabIndex = 22;
            this.lbl_Yakit.Text = "Yakıt:";
            // 
            // cmb_Klima
            // 
            this.cmb_Klima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Klima.FormattingEnabled = true;
            this.cmb_Klima.Items.AddRange(new object[] {
            "Seçiniz ..",
            "Var",
            "Yok"});
            this.cmb_Klima.Location = new System.Drawing.Point(201, 321);
            this.cmb_Klima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Klima.Name = "cmb_Klima";
            this.cmb_Klima.Size = new System.Drawing.Size(184, 30);
            this.cmb_Klima.TabIndex = 12;
            // 
            // cmb_vitesTipi
            // 
            this.cmb_vitesTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vitesTipi.FormattingEnabled = true;
            this.cmb_vitesTipi.Items.AddRange(new object[] {
            "Seçiniz ..",
            "Manuel",
            "Otomatik"});
            this.cmb_vitesTipi.Location = new System.Drawing.Point(201, 102);
            this.cmb_vitesTipi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_vitesTipi.Name = "cmb_vitesTipi";
            this.cmb_vitesTipi.Size = new System.Drawing.Size(184, 30);
            this.cmb_vitesTipi.TabIndex = 8;
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yakit.FormattingEnabled = true;
            this.cmb_yakit.Items.AddRange(new object[] {
            "Seçiniz ..",
            "Benzin",
            "LPG",
            "Dizel"});
            this.cmb_yakit.Location = new System.Drawing.Point(201, 47);
            this.cmb_yakit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Size = new System.Drawing.Size(184, 30);
            this.cmb_yakit.TabIndex = 7;
            // 
            // txt_Km
            // 
            this.txt_Km.Location = new System.Drawing.Point(201, 158);
            this.txt_Km.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Km.Name = "txt_Km";
            this.txt_Km.Size = new System.Drawing.Size(184, 29);
            this.txt_Km.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.cmb_yakit);
            this.groupBox1.Controls.Add(this.txt_Km);
            this.groupBox1.Controls.Add(this.cmb_vitesTipi);
            this.groupBox1.Controls.Add(this.cmb_MotorGucu);
            this.groupBox1.Controls.Add(this.cmb_Klima);
            this.groupBox1.Controls.Add(this.lbl_Yakit);
            this.groupBox1.Controls.Add(this.cmb_MotorHacmi);
            this.groupBox1.Controls.Add(this.lbl_vites);
            this.groupBox1.Controls.Add(this.llb_km);
            this.groupBox1.Controls.Add(this.lbl_mHacmi);
            this.groupBox1.Controls.Add(this.lbl_Klima);
            this.groupBox1.Controls.Add(this.lbl_MotorGücü);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(364, 436);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(428, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Motor Bilgileri";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Azure;
            this.btnAra.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.ImageIndex = 5;
            this.btnAra.ImageList = this.ilistaracİslem;
            this.btnAra.Location = new System.Drawing.Point(1467, 114);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(167, 66);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "ARA";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(1163, 138);
            this.txt_ara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(273, 22);
            this.txt_ara.TabIndex = 20;
            this.txt_ara.Text = "Giriniz..";
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1014, 143);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Araç Plakası";
            // 
            // frm_Aracİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1861, 880);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbx_AracEkleme);
            this.Controls.Add(this.Btn_Kapat);
            this.Controls.Add(this.dgv_aracİslemleri);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_AracEkle);
            this.Controls.Add(this.btn_AracGuncelle);
            this.Controls.Add(this.btn_Sil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frm_Aracİslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Aracİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracİslemleri)).EndInit();
            this.grpbx_AracEkleme.ResumeLayout(false);
            this.grpbx_AracEkleme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aracİslemleri;
        private System.Windows.Forms.GroupBox grpbx_AracEkleme;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.ComboBox cmb_Model;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ComboBox cmb_garanti;
        private System.Windows.Forms.ComboBox cmb_MotorGucu;
        private System.Windows.Forms.ComboBox cmb_Yil;
        private System.Windows.Forms.ComboBox cmb_MotorHacmi;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_AracGuncelle;
        private System.Windows.Forms.ComboBox cmb_Renk;
        private System.Windows.Forms.Label lbl_Yil;
        private System.Windows.Forms.Button btn_AracEkle;
        private System.Windows.Forms.Label lbl_Klima;
        private System.Windows.Forms.Label lbl_MotorGücü;
        private System.Windows.Forms.Label lbl_mHacmi;
        private System.Windows.Forms.Label llb_km;
        private System.Windows.Forms.Label lbl_vites;
        private System.Windows.Forms.Label lbl_Yakit;
        private System.Windows.Forms.ComboBox cmb_Klima;
        private System.Windows.Forms.ComboBox cmb_vitesTipi;
        private System.Windows.Forms.ComboBox cmb_yakit;
        private System.Windows.Forms.TextBox txt_Km;
        private System.Windows.Forms.TextBox txt_AracPlaka;
        private System.Windows.Forms.Label lbl_AracRenk;
        private System.Windows.Forms.Label lbl_AracModel;
        private System.Windows.Forms.Label lbl_Seri;
        private System.Windows.Forms.Label lbl_AracMarka;
        private System.Windows.Forms.Label lbl_AracPlaka;
        private System.Windows.Forms.ImageList ilistaracİslem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label15;
    }
}