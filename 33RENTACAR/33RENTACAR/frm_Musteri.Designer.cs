namespace _33RENTACAR
{
    partial class frm_Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Musteri));
            this.btnAra = new System.Windows.Forms.Button();
            this.ilistMusteri = new System.Windows.Forms.ImageList(this.components);
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_EverilisYeri = new System.Windows.Forms.ComboBox();
            this.dtp_EverilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_Eno = new System.Windows.Forms.TextBox();
            this.txt_Etip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.txt_Ev = new System.Windows.Forms.TextBox();
            this.txt_Cep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Dtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.cmb_Dyeri = new System.Windows.Forms.ComboBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_musteri = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Azure;
            this.btnAra.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.ImageKey = "mercek.png";
            this.btnAra.ImageList = this.ilistMusteri;
            this.btnAra.Location = new System.Drawing.Point(1233, 91);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(167, 66);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "ARA";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ilistMusteri
            // 
            this.ilistMusteri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistMusteri.ImageStream")));
            this.ilistMusteri.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistMusteri.Images.SetKeyName(0, "guncelle.png");
            this.ilistMusteri.Images.SetKeyName(1, "kaydet.png");
            this.ilistMusteri.Images.SetKeyName(2, "sil.png");
            this.ilistMusteri.Images.SetKeyName(3, "temizle.png");
            this.ilistMusteri.Images.SetKeyName(4, "kapat.png");
            this.ilistMusteri.Images.SetKeyName(5, "mercek.png");
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(929, 115);
            this.txt_ara.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(273, 22);
            this.txt_ara.TabIndex = 9;
            this.txt_ara.Text = "Giriniz..";
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(669, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "TC Numarası Veya İsim:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Azure;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_Temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Temizle.ImageKey = "temizle.png";
            this.btn_Temizle.ImageList = this.ilistMusteri;
            this.btn_Temizle.Location = new System.Drawing.Point(1260, 473);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(200, 75);
            this.btn_Temizle.TabIndex = 11;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Azure;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.ImageKey = "sil.png";
            this.btn_Sil.ImageList = this.ilistMusteri;
            this.btn_Sil.Location = new System.Drawing.Point(1024, 473);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(200, 75);
            this.btn_Sil.TabIndex = 12;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Azure;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guncelle.ImageKey = "guncelle.png";
            this.btn_Guncelle.ImageList = this.ilistMusteri;
            this.btn_Guncelle.Location = new System.Drawing.Point(796, 473);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(200, 75);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Azure;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_Kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kaydet.ImageKey = "kaydet.png";
            this.btn_Kaydet.ImageList = this.ilistMusteri;
            this.btn_Kaydet.Location = new System.Drawing.Point(561, 473);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(200, 75);
            this.btn_Kaydet.TabIndex = 14;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Controls.Add(this.cmb_EverilisYeri);
            this.groupBox3.Controls.Add(this.dtp_EverilisTarihi);
            this.groupBox3.Controls.Add(this.txt_Eno);
            this.groupBox3.Controls.Add(this.txt_Etip);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1368, 564);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(491, 313);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Ehliyet Bilgileri";
            // 
            // cmb_EverilisYeri
            // 
            this.cmb_EverilisYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EverilisYeri.FormattingEnabled = true;
            this.cmb_EverilisYeri.Items.AddRange(new object[] {
            "Seçiniz.",
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.cmb_EverilisYeri.Location = new System.Drawing.Point(223, 111);
            this.cmb_EverilisYeri.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_EverilisYeri.Name = "cmb_EverilisYeri";
            this.cmb_EverilisYeri.Size = new System.Drawing.Size(244, 26);
            this.cmb_EverilisYeri.TabIndex = 7;
            // 
            // dtp_EverilisTarihi
            // 
            this.dtp_EverilisTarihi.Location = new System.Drawing.Point(223, 146);
            this.dtp_EverilisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_EverilisTarihi.Name = "dtp_EverilisTarihi";
            this.dtp_EverilisTarihi.Size = new System.Drawing.Size(244, 24);
            this.dtp_EverilisTarihi.TabIndex = 6;
            // 
            // txt_Eno
            // 
            this.txt_Eno.Location = new System.Drawing.Point(223, 78);
            this.txt_Eno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Eno.Name = "txt_Eno";
            this.txt_Eno.Size = new System.Drawing.Size(244, 24);
            this.txt_Eno.TabIndex = 4;
            this.txt_Eno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Eno_KeyPress);
            // 
            // txt_Etip
            // 
            this.txt_Etip.Location = new System.Drawing.Point(223, 44);
            this.txt_Etip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Etip.Name = "txt_Etip";
            this.txt_Etip.Size = new System.Drawing.Size(244, 24);
            this.txt_Etip.TabIndex = 3;
            this.txt_Etip.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ehliyet Veriliş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ehliyet Veriliş Yeri:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(96, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ehliyet No:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(87, 49);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ehliyet Tipi:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.txt_Adres);
            this.groupBox2.Controls.Add(this.txt_Eposta);
            this.groupBox2.Controls.Add(this.txt_Ev);
            this.groupBox2.Controls.Add(this.txt_Cep);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(893, 565);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(469, 313);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Adres Bilgileri";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(145, 156);
            this.txt_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(244, 136);
            this.txt_Adres.TabIndex = 4;
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(145, 110);
            this.txt_Eposta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(244, 24);
            this.txt_Eposta.TabIndex = 4;
            // 
            // txt_Ev
            // 
            this.txt_Ev.Location = new System.Drawing.Point(145, 76);
            this.txt_Ev.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ev.Name = "txt_Ev";
            this.txt_Ev.Size = new System.Drawing.Size(244, 24);
            this.txt_Ev.TabIndex = 4;
            this.txt_Ev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ev_KeyPress);
            // 
            // txt_Cep
            // 
            this.txt_Cep.Location = new System.Drawing.Point(145, 43);
            this.txt_Cep.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cep.Name = "txt_Cep";
            this.txt_Cep.Size = new System.Drawing.Size(244, 24);
            this.txt_Cep.TabIndex = 3;
            this.txt_Cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cep_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(32, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "E-Posta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(47, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ev Tel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(32, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cep Tel:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.dtp_Dtarihi);
            this.groupBox1.Controls.Add(this.cmb_cinsiyet);
            this.groupBox1.Controls.Add(this.cmb_ilce);
            this.groupBox1.Controls.Add(this.cmb_Dyeri);
            this.groupBox1.Controls.Add(this.txt_Soyad);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Tc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(420, 566);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 313);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişinin Bilgileri";
            // 
            // dtp_Dtarihi
            // 
            this.dtp_Dtarihi.Location = new System.Drawing.Point(205, 178);
            this.dtp_Dtarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Dtarihi.Name = "dtp_Dtarihi";
            this.dtp_Dtarihi.Size = new System.Drawing.Size(244, 24);
            this.dtp_Dtarihi.TabIndex = 8;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Seçiniz.",
            "Erkek",
            "Bayan"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(205, 143);
            this.cmb_cinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(244, 26);
            this.cmb_cinsiyet.TabIndex = 7;
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ilce.FormattingEnabled = true;
            this.cmb_ilce.Location = new System.Drawing.Point(205, 249);
            this.cmb_ilce.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(244, 26);
            this.cmb_ilce.TabIndex = 7;
            this.cmb_ilce.SelectedIndexChanged += new System.EventHandler(this.cmb_ilce_SelectedIndexChanged);
            // 
            // cmb_Dyeri
            // 
            this.cmb_Dyeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dyeri.FormattingEnabled = true;
            this.cmb_Dyeri.Items.AddRange(new object[] {
            "Seçiniz."});
            this.cmb_Dyeri.Location = new System.Drawing.Point(205, 213);
            this.cmb_Dyeri.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Dyeri.Name = "cmb_Dyeri";
            this.cmb_Dyeri.Size = new System.Drawing.Size(244, 26);
            this.cmb_Dyeri.TabIndex = 7;
            this.cmb_Dyeri.SelectedIndexChanged += new System.EventHandler(this.cmb_Dyeri_SelectedIndexChanged);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(205, 108);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(244, 24);
            this.txt_Soyad.TabIndex = 4;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(205, 75);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(244, 24);
            this.txt_Ad.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(205, 42);
            this.txt_Tc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(244, 24);
            this.txt_Tc.TabIndex = 3;
            this.txt_Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tc_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(137, 255);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "İlçe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nüfusa Kayıtlı İl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(117, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Numarası:";
            // 
            // dgv_musteri
            // 
            this.dgv_musteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteri.Location = new System.Drawing.Point(420, 180);
            this.dgv_musteri.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_musteri.Name = "dgv_musteri";
            this.dgv_musteri.Size = new System.Drawing.Size(1457, 271);
            this.dgv_musteri.TabIndex = 18;
            this.dgv_musteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musteri_CellContentClick);
            this.dgv_musteri.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_musteri_CellFormatting);
            this.dgv_musteri.Click += new System.EventHandler(this.dgv_musteri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Azure;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Black;
            this.btnKapat.Image = global::_33RENTACAR.Properties.Resources.kapat1;
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.Location = new System.Drawing.Point(1499, 472);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(171, 76);
            this.btnKapat.TabIndex = 19;
            this.btnKapat.Text = "Kapat   ";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frm_Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1942, 906);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dgv_musteri);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label15);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müsteri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Musteri_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_EverilisYeri;
        private System.Windows.Forms.DateTimePicker dtp_EverilisTarihi;
        private System.Windows.Forms.TextBox txt_Eno;
        private System.Windows.Forms.TextBox txt_Etip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.TextBox txt_Ev;
        private System.Windows.Forms.TextBox txt_Cep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Dyeri;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_musteri;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ImageList ilistMusteri;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.DateTimePicker dtp_Dtarihi;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private System.Windows.Forms.Label label16;
    }
}