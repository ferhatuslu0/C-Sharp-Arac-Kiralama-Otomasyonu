using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace _33RENTACAR
{
    public partial class frm_KullaniciGirisi : Form
    {
        public frm_KullaniciGirisi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbCommand sorgula = new OleDbCommand("SELECT * from kullanicilar where kullaniciAdi='" + txt_kullaniciAdi.Text + "' and Sifre='" + txt_Sifre.Text + "'", baglanti);
            OleDbDataReader oku = sorgula.ExecuteReader();

            if (oku.Read())
            {
                frm_Anamenu ana = new frm_Anamenu();
                ana.Show();
                this.Visible = false;
                
            }
            else if (txt_kullaniciAdi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adınız Hatalı Lütfen Tekrar Deneyiniz !");
            }
            else if (txt_Sifre.Text == "")
            {
                MessageBox.Show("Şifreniz Hatalı Lütfen Tekrar Deneyiniz !");
            }

            else
            {

                MessageBox.Show("Kullanıcı Adı Veya Şifreniz Hatalı !");
            }

            baglanti.Close();
            
        }

        private void frm_KullaniciGirisi_Load(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            lbl_Saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
