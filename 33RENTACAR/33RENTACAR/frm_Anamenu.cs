using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33RENTACAR
{
    public partial class frm_Anamenu : Form
    {
        public frm_Anamenu()
        {
            InitializeComponent();
        }
        frm_Musteri musteri = new frm_Musteri();
        frm_Aracİslemler Aracislem = new frm_Aracİslemler();
        frm_AracKirala AracKirala = new frm_AracKirala();
        frm_Rapor Rapor = new frm_Rapor();
        frm_Kullanici kullanicilar = new frm_Kullanici();
        frm_Yardim yardim = new frm_Yardim();
        
        private void btn_musteri_Click(object sender, EventArgs e)
        {
            if (musteri.Created)
            {
                musteri.Activate();
            }
            else
            {
                musteri = new frm_Musteri();
                musteri.MdiParent = this;
                musteri.Show();
                Aracislem.Close();
                AracKirala.Close();
                Rapor.Close();
                kullanicilar.Close();
                yardim.Close();
                
            }
            
        }

        private void btn_Aracİslem_Click(object sender, EventArgs e)
        {
            if (Aracislem.Created)
            {
                Aracislem.Activate();
            }
            else
            {
                Aracislem = new frm_Aracİslemler();
                Aracislem.MdiParent = this;
                Aracislem.WindowState = FormWindowState.Maximized;
                Aracislem.Show();
                musteri.Close();
                AracKirala.Close();
                Rapor.Close();
                kullanicilar.Close();
                yardim.Close();

            }
            
        }

        private void btn_AracKiralama_Click(object sender, EventArgs e)
        {
            if (AracKirala.Created)
            {
                AracKirala.Activate();
            }
            else
            {
                AracKirala = new frm_AracKirala();
                AracKirala.MdiParent = this;
                AracKirala.Show();
                musteri.Close();
                Aracislem.Close();
                Rapor.Close();
                kullanicilar.Close();
                yardim.Close();
                
            }
        }

        private void btn_raporlama_Click(object sender, EventArgs e)
        {
            if (Rapor.Created)
            {
                Rapor.Activate();
            }
            else
            {
                Rapor = new frm_Rapor();
                Rapor.MdiParent = this;
                Rapor.Show();
                musteri.Close();
                Aracislem.Close();
                AracKirala.Close();
                kullanicilar.Close();
                yardim.Close();
            }
        }

        private void frm_Anamenu_Load(object sender, EventArgs e)
        {
            
            foreach (Form frm_Aracİslemler in this.MdiChildren)
            {
                frm_Aracİslemler.WindowState = FormWindowState.Maximized;
                
            }

          
        }

        private void btn_Kullanicilar_Click(object sender, EventArgs e)
        {
            if (kullanicilar.Created)
            {
                kullanicilar.Activate();
            }
            else
            {
                kullanicilar = new frm_Kullanici();
                kullanicilar.MdiParent = this;
                kullanicilar.Show();
                musteri.Close();
                Aracislem.Close();
                AracKirala.Close();
                Rapor.Close();
                yardim.Close();
            }
        }

        private void frm_Anamenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Yardim_Click(object sender, EventArgs e)
        {
            if (yardim.Created)
            {
                yardim.Activate();
            }
            else
            {
                yardim = new frm_Yardim();
                yardim.MdiParent = this;
                yardim.Show();
                musteri.Close();
                Aracislem.Close();
                AracKirala.Close();
                Rapor.Close();
                kullanicilar.Close();
            }
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
