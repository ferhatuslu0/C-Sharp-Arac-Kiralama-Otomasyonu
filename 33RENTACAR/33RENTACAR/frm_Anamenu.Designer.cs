namespace _33RENTACAR
{
    partial class frm_Anamenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anamenu));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Yardim = new System.Windows.Forms.Button();
            this.btn_Kullanicilar = new System.Windows.Forms.Button();
            this.btn_raporlama = new System.Windows.Forms.Button();
            this.btn_AEkleme = new System.Windows.Forms.Button();
            this.btn_Akiralama = new System.Windows.Forms.Button();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Maroon;
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Controls.Add(this.btn_Yardim);
            this.pnl_menu.Controls.Add(this.btn_Kullanicilar);
            this.pnl_menu.Controls.Add(this.btn_raporlama);
            this.pnl_menu.Controls.Add(this.btn_AEkleme);
            this.pnl_menu.Controls.Add(this.btn_Akiralama);
            this.pnl_menu.Controls.Add(this.btn_Kapat);
            this.pnl_menu.Controls.Add(this.btn_musteri);
            this.pnl_menu.Location = new System.Drawing.Point(0, 24);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(146, 703);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu";
            // 
            // btn_Yardim
            // 
            this.btn_Yardim.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_Yardim.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Yardim.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yardim.Image = global::_33RENTACAR.Properties.Resources.yardim;
            this.btn_Yardim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Yardim.Location = new System.Drawing.Point(3, 545);
            this.btn_Yardim.Name = "btn_Yardim";
            this.btn_Yardim.Size = new System.Drawing.Size(140, 62);
            this.btn_Yardim.TabIndex = 12;
            this.btn_Yardim.Text = "Yardım    ";
            this.btn_Yardim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Yardim.UseVisualStyleBackColor = true;
            this.btn_Yardim.Click += new System.EventHandler(this.btn_Yardim_Click);
            // 
            // btn_Kullanicilar
            // 
            this.btn_Kullanicilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kullanicilar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Kullanicilar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kullanicilar.Image = global::_33RENTACAR.Properties.Resources.kullanicidegistir;
            this.btn_Kullanicilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kullanicilar.Location = new System.Drawing.Point(3, 453);
            this.btn_Kullanicilar.Name = "btn_Kullanicilar";
            this.btn_Kullanicilar.Size = new System.Drawing.Size(140, 62);
            this.btn_Kullanicilar.TabIndex = 11;
            this.btn_Kullanicilar.Text = "Kullanıcılar";
            this.btn_Kullanicilar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kullanicilar.UseVisualStyleBackColor = true;
            this.btn_Kullanicilar.Click += new System.EventHandler(this.btn_Kullanicilar_Click);
            // 
            // btn_raporlama
            // 
            this.btn_raporlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_raporlama.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_raporlama.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlama.Image = global::_33RENTACAR.Properties.Resources.raporla;
            this.btn_raporlama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_raporlama.Location = new System.Drawing.Point(3, 359);
            this.btn_raporlama.Name = "btn_raporlama";
            this.btn_raporlama.Size = new System.Drawing.Size(140, 62);
            this.btn_raporlama.TabIndex = 8;
            this.btn_raporlama.Text = "Raporlar   ";
            this.btn_raporlama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_raporlama.UseVisualStyleBackColor = true;
            this.btn_raporlama.Click += new System.EventHandler(this.btn_raporlama_Click);
            // 
            // btn_AEkleme
            // 
            this.btn_AEkleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AEkleme.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_AEkleme.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AEkleme.Image = global::_33RENTACAR.Properties.Resources.aracc;
            this.btn_AEkleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AEkleme.Location = new System.Drawing.Point(3, 177);
            this.btn_AEkleme.Name = "btn_AEkleme";
            this.btn_AEkleme.Size = new System.Drawing.Size(140, 62);
            this.btn_AEkleme.TabIndex = 10;
            this.btn_AEkleme.Text = "         Araç        İşlemleri  ";
            this.btn_AEkleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AEkleme.UseVisualStyleBackColor = true;
            this.btn_AEkleme.Click += new System.EventHandler(this.btn_Aracİslem_Click);
            // 
            // btn_Akiralama
            // 
            this.btn_Akiralama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Akiralama.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Akiralama.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Akiralama.Image = global::_33RENTACAR.Properties.Resources.aracKirala;
            this.btn_Akiralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Akiralama.Location = new System.Drawing.Point(3, 268);
            this.btn_Akiralama.Name = "btn_Akiralama";
            this.btn_Akiralama.Size = new System.Drawing.Size(140, 62);
            this.btn_Akiralama.TabIndex = 9;
            this.btn_Akiralama.Text = "Araç       Kiralama  ";
            this.btn_Akiralama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Akiralama.UseVisualStyleBackColor = true;
            this.btn_Akiralama.Click += new System.EventHandler(this.btn_AracKiralama_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Kapat.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Image = global::_33RENTACAR.Properties.Resources.kapat;
            this.btn_Kapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kapat.Location = new System.Drawing.Point(3, 630);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(140, 62);
            this.btn_Kapat.TabIndex = 13;
            this.btn_Kapat.Text = "Kapat     ";
            this.btn_Kapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musteri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_musteri.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musteri.Image = global::_33RENTACAR.Properties.Resources.musteri;
            this.btn_musteri.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_musteri.Location = new System.Drawing.Point(3, 89);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(140, 62);
            this.btn_musteri.TabIndex = 7;
            this.btn_musteri.Text = "Müşteri   ";
            this.btn_musteri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.btn_Kullanicilar_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.btn_raporlama_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // işlemYapToolStripMenuItem
            // 
            this.işlemYapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem,
            this.araçKiralamaToolStripMenuItem});
            this.işlemYapToolStripMenuItem.Name = "işlemYapToolStripMenuItem";
            this.işlemYapToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.işlemYapToolStripMenuItem.Text = "İşlem Yap";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            this.araçİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.btn_Aracİslem_Click);
            // 
            // araçKiralamaToolStripMenuItem
            // 
            this.araçKiralamaToolStripMenuItem.Name = "araçKiralamaToolStripMenuItem";
            this.araçKiralamaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.araçKiralamaToolStripMenuItem.Text = "Araç Kiralama";
            this.araçKiralamaToolStripMenuItem.Click += new System.EventHandler(this.btn_AracKiralama_Click);
            // 
            // frm_Anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_33RENTACAR.Properties.Resources.anaSayfa1;
            this.ClientSize = new System.Drawing.Size(1098, 727);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_Anamenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Anamenu_FormClosed);
            this.Load += new System.EventHandler(this.frm_Anamenu_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Yardim;
        private System.Windows.Forms.Button btn_Kullanicilar;
        private System.Windows.Forms.Button btn_raporlama;
        private System.Windows.Forms.Button btn_AEkleme;
        private System.Windows.Forms.Button btn_Akiralama;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralamaToolStripMenuItem;
    }
}