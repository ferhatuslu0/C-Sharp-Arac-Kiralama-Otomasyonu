namespace _33RENTACAR
{
    partial class frm_Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kullanici));
            this.lbl_KullaniciSifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAd = new System.Windows.Forms.Label();
            this.lbl_Kullanici = new System.Windows.Forms.Label();
            this.cmb_Kullanicilar = new System.Windows.Forms.ComboBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.btn_UyeEkle = new System.Windows.Forms.Button();
            this.imglistKullanici = new System.Windows.Forms.ImageList(this.components);
            this.btn_AracGuncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.dgv_Kullanici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KullaniciSifre
            // 
            this.lbl_KullaniciSifre.AutoSize = true;
            this.lbl_KullaniciSifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciSifre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_KullaniciSifre.Location = new System.Drawing.Point(75, 285);
            this.lbl_KullaniciSifre.Name = "lbl_KullaniciSifre";
            this.lbl_KullaniciSifre.Size = new System.Drawing.Size(56, 23);
            this.lbl_KullaniciSifre.TabIndex = 25;
            this.lbl_KullaniciSifre.Text = "Şifre:";
            // 
            // lbl_KullaniciAd
            // 
            this.lbl_KullaniciAd.AutoSize = true;
            this.lbl_KullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAd.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_KullaniciAd.Location = new System.Drawing.Point(11, 238);
            this.lbl_KullaniciAd.Name = "lbl_KullaniciAd";
            this.lbl_KullaniciAd.Size = new System.Drawing.Size(125, 23);
            this.lbl_KullaniciAd.TabIndex = 24;
            this.lbl_KullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // lbl_Kullanici
            // 
            this.lbl_Kullanici.AutoSize = true;
            this.lbl_Kullanici.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Kullanici.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullanici.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Kullanici.Location = new System.Drawing.Point(22, 188);
            this.lbl_Kullanici.Name = "lbl_Kullanici";
            this.lbl_Kullanici.Size = new System.Drawing.Size(116, 23);
            this.lbl_Kullanici.TabIndex = 23;
            this.lbl_Kullanici.Text = "Kullanıcılar:";
            // 
            // cmb_Kullanicilar
            // 
            this.cmb_Kullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kullanicilar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmb_Kullanicilar.FormattingEnabled = true;
            this.cmb_Kullanicilar.Location = new System.Drawing.Point(154, 190);
            this.cmb_Kullanicilar.Name = "cmb_Kullanicilar";
            this.cmb_Kullanicilar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Kullanicilar.TabIndex = 22;
            this.cmb_Kullanicilar.SelectedIndexChanged += new System.EventHandler(this.cmb_Kullanicilar_SelectedIndexChanged);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txt_Sifre.Location = new System.Drawing.Point(154, 286);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(121, 21);
            this.txt_Sifre.TabIndex = 21;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(154, 239);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(121, 21);
            this.txt_KullaniciAdi.TabIndex = 20;
            // 
            // btn_UyeEkle
            // 
            this.btn_UyeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UyeEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_UyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UyeEkle.ImageKey = "kullanicidegistir.png";
            this.btn_UyeEkle.ImageList = this.imglistKullanici;
            this.btn_UyeEkle.Location = new System.Drawing.Point(301, 150);
            this.btn_UyeEkle.Name = "btn_UyeEkle";
            this.btn_UyeEkle.Size = new System.Drawing.Size(124, 52);
            this.btn_UyeEkle.TabIndex = 30;
            this.btn_UyeEkle.Text = "Üye Ekle";
            this.btn_UyeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UyeEkle.UseVisualStyleBackColor = true;
            this.btn_UyeEkle.Click += new System.EventHandler(this.btn_UyeEkle_Click);
            // 
            // imglistKullanici
            // 
            this.imglistKullanici.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistKullanici.ImageStream")));
            this.imglistKullanici.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistKullanici.Images.SetKeyName(0, "kullanicidegistir.png");
            this.imglistKullanici.Images.SetKeyName(1, "guncelle.png");
            this.imglistKullanici.Images.SetKeyName(2, "kapat.png");
            this.imglistKullanici.Images.SetKeyName(3, "sil.png");
            // 
            // btn_AracGuncelle
            // 
            this.btn_AracGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AracGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AracGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_AracGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AracGuncelle.ImageKey = "guncelle.png";
            this.btn_AracGuncelle.ImageList = this.imglistKullanici;
            this.btn_AracGuncelle.Location = new System.Drawing.Point(301, 208);
            this.btn_AracGuncelle.Name = "btn_AracGuncelle";
            this.btn_AracGuncelle.Size = new System.Drawing.Size(124, 52);
            this.btn_AracGuncelle.TabIndex = 32;
            this.btn_AracGuncelle.Text = "Güncelle";
            this.btn_AracGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AracGuncelle.UseVisualStyleBackColor = true;
            this.btn_AracGuncelle.Click += new System.EventHandler(this.btn_AracGuncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.ImageKey = "sil.png";
            this.btn_Sil.ImageList = this.imglistKullanici;
            this.btn_Sil.Location = new System.Drawing.Point(301, 266);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(124, 52);
            this.btn_Sil.TabIndex = 31;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kapat.ForeColor = System.Drawing.Color.Black;
            this.Btn_Kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Kapat.ImageKey = "kapat.png";
            this.Btn_Kapat.ImageList = this.imglistKullanici;
            this.Btn_Kapat.Location = new System.Drawing.Point(301, 325);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(124, 52);
            this.Btn_Kapat.TabIndex = 33;
            this.Btn_Kapat.Text = "Kapat";
            this.Btn_Kapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Kapat.UseVisualStyleBackColor = true;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // dgv_Kullanici
            // 
            this.dgv_Kullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kullanici.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Kullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kullanici.Location = new System.Drawing.Point(5, 21);
            this.dgv_Kullanici.Name = "dgv_Kullanici";
            this.dgv_Kullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kullanici.Size = new System.Drawing.Size(420, 123);
            this.dgv_Kullanici.TabIndex = 34;
            this.dgv_Kullanici.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Kullanici_CellFormatting);
            this.dgv_Kullanici.Click += new System.EventHandler(this.dgv_Kullanici_Click);
            // 
            // frm_Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::_33RENTACAR.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(437, 389);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Kullanici);
            this.Controls.Add(this.Btn_Kapat);
            this.Controls.Add(this.btn_UyeEkle);
            this.Controls.Add(this.btn_AracGuncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_KullaniciSifre);
            this.Controls.Add(this.lbl_KullaniciAd);
            this.Controls.Add(this.lbl_Kullanici);
            this.Controls.Add(this.cmb_Kullanicilar);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.frm_Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullaniciSifre;
        private System.Windows.Forms.Label lbl_KullaniciAd;
        private System.Windows.Forms.Label lbl_Kullanici;
        private System.Windows.Forms.ComboBox cmb_Kullanicilar;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Button btn_UyeEkle;
        private System.Windows.Forms.Button btn_AracGuncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.ImageList imglistKullanici;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.DataGridView dgv_Kullanici;
    }
}