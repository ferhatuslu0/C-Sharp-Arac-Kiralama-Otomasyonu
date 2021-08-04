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
    public partial class frm_Kullanici : Form
    {
        public frm_Kullanici()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        OleDbCommand komut;
        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (txt_KullaniciAdi.Text=="" || txt_Sifre.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifre Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    string sorgu = "INSERT INTO kullanicilar (kullaniciAdi,Sifre) values (@1,@2)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@1", txt_KullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@2", txt_Sifre.Text);
                    komut.ExecuteNonQuery();
                    kullaniciGetir();
                    MessageBox.Show("Yeni Kullanıcı Başarı İle Eklendi");
                    txt_KullaniciAdi.Clear();
                    txt_Sifre.Clear();
                    
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Kullanıcı Ekleme Hatası" + ex.Message);
                }
            }
            baglanti.Close();  
        }

        void kullaniciGetir()
        {
            string sorgu= "select * from kullanicilar";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "kullanicilar");
            dgv_Kullanici.DataSource = ds.Tables[0];
        }

        private void frm_Kullanici_Load(object sender, EventArgs e)
        {

            OleDbConnection baglanti2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            OleDbCommand getir = new OleDbCommand("select * from kullanicilar", baglanti2);
            OleDbDataReader oku;
            baglanti2.Open();
            oku = getir.ExecuteReader();
            while (oku.Read())
            {
                cmb_Kullanicilar.Items.Add(oku["kullaniciAdi"].ToString());
            }
            baglanti2.Close();
            
           
            kullaniciGetir();
            kayitGuncelle();
            kayitSil();
            dgv_Kullanici.Columns[0].Visible = false;
            ControlBox = false;
            baslik();
            this.WindowState = FormWindowState.Normal;

            dgv_Kullanici.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_Kullanici_CellFormatting);
        }

        private void dgv_Kullanici_Click(object sender, EventArgs e)
        {
            txt_KullaniciAdi.Text = dgv_Kullanici.Rows[dgv_Kullanici.CurrentRow.Index].Cells[1].Value.ToString();
            txt_Sifre.Text = dgv_Kullanici.Rows[dgv_Kullanici.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void btn_AracGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (txt_KullaniciAdi.Text=="" || txt_Sifre.Text=="")
            {
                MessageBox.Show("Doldurulması Zorunlu Alanlar Var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } 
            else
           {
               try
               {
                   string satirGuncelle = dgv_Kullanici.CurrentRow.Cells["kullanici_id"].Value.ToString();

                   DialogResult guncelle = MessageBox.Show("Kullanıcı Bilgilerini Güncellemek İstediğinizden Eminmisiniz?","Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (guncelle==DialogResult.Yes || dgv_Kullanici.CurrentRow.Cells["kullanici_id"].Value.ToString().Trim() !="")
               {
                   string sorgu = "UPDATE kullanicilar set kullaniciAdi=@1,Sifre=@2 where kullanici_id=" + satirGuncelle + " ";
                   komut = new OleDbCommand(sorgu, baglanti);
                   komut.Parameters.AddWithValue("@1", txt_KullaniciAdi.Text);
                   komut.Parameters.AddWithValue("@2", txt_Sifre.Text);
                   komut.ExecuteNonQuery();
                   kayitGuncelle();
                   MessageBox.Show("Kullanıcı Başarı İle Güncellendi");
               }
               else
               {
                   MessageBox.Show("Güncelleme İşlemi İptal edildi");
               }
               }
               catch (Exception ex)
               {

                   MessageBox.Show("Güncelleme Hatası" + ex.Message);
               }

	       }
            baglanti.Close();
        }

        void kayitGuncelle()
        {
            string sorgu = "select * from kullanicilar";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "kullanicilar");
            dgv_Kullanici.DataSource = ds.Tables[0];
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                

            DialogResult sil = MessageBox.Show("Kullanici Bilgisini Silmek İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sil==DialogResult.Yes && dgv_Kullanici.CurrentRow.Cells["kullanici_id"].Value.ToString().Trim() !="")
            {
                string satirSil = dgv_Kullanici.CurrentRow.Cells["kullanici_id"].Value.ToString();
                string sorgu = "delete from kullanicilar where kullanici_id=" + satirSil +"";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                kayitSil();
                MessageBox.Show("Kullanici Kaydı Başarı İle Silindi");
                txt_KullaniciAdi.Clear();
                txt_Sifre.Clear();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silme Hatası" + ex.Message);
            }
            baglanti.Close();
        }

        void kayitSil()
        {
            string sorgu = "select * from kullanicilar";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "kullanicilar");
            dgv_Kullanici.DataSource = ds.Tables[0];
        }

        private void cmb_Kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_KullaniciAdi.Text = cmb_Kullanicilar.SelectedItem.ToString();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void baslik()
        {
            dgv_Kullanici.Columns[1].HeaderText = "Kullanıcı Adı";
            dgv_Kullanici.Columns[2].HeaderText = "Şifre";
        }

        private void dgv_Kullanici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Kullanici.Rows[e.RowIndex].Selected)
            {

                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.White;

            }
        }
    }
}
