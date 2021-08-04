namespace _33RENTACAR
{
    partial class frm_KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KullaniciGirisi));
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Saat.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Saat.Location = new System.Drawing.Point(263, 54);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(0, 14);
            this.lbl_Saat.TabIndex = 17;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_tarih.Location = new System.Drawing.Point(263, 22);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(0, 14);
            this.lbl_tarih.TabIndex = 16;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iptal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Image = global::_33RENTACAR.Properties.Resources.power;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iptal.Location = new System.Drawing.Point(86, 202);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(95, 43);
            this.btn_iptal.TabIndex = 15;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_giris.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Image = global::_33RENTACAR.Properties.Resources.ok;
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giris.Location = new System.Drawing.Point(213, 202);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(95, 43);
            this.btn_giris.TabIndex = 13;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbl_Sifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Sifre.Location = new System.Drawing.Point(103, 149);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(52, 18);
            this.lbl_Sifre.TabIndex = 14;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(39, 108);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(116, 18);
            this.lbl_KullaniciAdi.TabIndex = 11;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_Sifre.Location = new System.Drawing.Point(191, 147);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(112, 20);
            this.txt_Sifre.TabIndex = 12;
            this.txt_Sifre.Text = "123";
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(191, 105);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(112, 21);
            this.txt_kullaniciAdi.TabIndex = 10;
            this.txt_kullaniciAdi.Text = "ferhat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(200, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Saat : ";
            // 
            // frm_KullaniciGirisi
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_33RENTACAR.Properties.Resources.arkaplan;
            this.CancelButton = this.btn_giris;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KullaniciGirisi";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.frm_KullaniciGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

