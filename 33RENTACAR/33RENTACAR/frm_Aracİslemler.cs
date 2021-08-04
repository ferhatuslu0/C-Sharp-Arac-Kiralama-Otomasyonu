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
    public partial class frm_Aracİslemler : Form
    {
        public frm_Aracİslemler()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        OleDbCommand komut;

        //Arama için
        OleDbConnection baglanti2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");

        
        private void frm_Aracİslemler_Load(object sender, EventArgs e)
        {
            //Araç Marka model getirme
            OleDbConnection baglanti3 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            OleDbCommand veri = new OleDbCommand("SELECT * FROM AracMarka", baglanti3);
            DataTable aracMarka = new DataTable();
            OleDbDataAdapter aracDa = new OleDbDataAdapter(veri);
            aracDa.Fill(aracMarka);
            cmb_Marka.DisplayMember = "AracMarkaAd";
            cmb_Marka.ValueMember = "aMarkaid";
            cmb_Marka.DataSource = aracMarka;
            cmb_Marka.SelectedIndex = -1;
            cmb_Model.SelectedIndex = -1;


            txt_AracPlaka.Clear();
            txt_Km.Clear();
            cmb_garanti.SelectedIndex = 0;
            cmb_Klima.SelectedIndex = 0;
            cmb_MotorGucu.SelectedIndex = 0;
            cmb_MotorHacmi.SelectedIndex = 0;
            cmb_vitesTipi.SelectedIndex = 0;
            cmb_yakit.SelectedIndex = 0;
            cmb_Yil.SelectedIndex = 0;
            cmb_Renk.SelectedIndex = 0;
            cmb_Marka.SelectedIndex = -1;
            cmb_Model.SelectedIndex = -1;
            ControlBox = false;   
            AracGetir();
            baslik();
            dgv_aracİslemleri.Columns[0].Visible = false;

            this.WindowState = FormWindowState.Maximized;

            dgv_aracİslemleri.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_aracİslemleri_CellFormatting);
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (txt_AracPlaka.Text == "" || cmb_Marka.Text == "" || cmb_garanti.Text == "" || cmb_Renk.Text == "" || txt_Km.Text == "" || cmb_MotorHacmi.Text == "")
            {
                MessageBox.Show("Doldurulması Zorunlu Alanlar var", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    string sorgu = "INSERT INTO aracİslemleri(AracPlakasi,AracMarka,Model,Garanti,Yil,Renk,Yakit,VitesTipi,Km,MotorHacmi,MotorGucu,Klima,Durum) VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@1", txt_AracPlaka.Text);
                    komut.Parameters.AddWithValue("@2", cmb_Marka.Text);
                    komut.Parameters.AddWithValue("@3", cmb_Model.Text);
                    komut.Parameters.AddWithValue("@4", cmb_garanti.Text);
                    komut.Parameters.AddWithValue("@5", cmb_Yil.Text);
                    komut.Parameters.AddWithValue("@6", cmb_Renk.Text);
                    komut.Parameters.AddWithValue("@7", cmb_yakit.Text);
                    komut.Parameters.AddWithValue("@8", cmb_vitesTipi.Text);
                    komut.Parameters.AddWithValue("@9", txt_Km.Text);
                    komut.Parameters.AddWithValue("@10", cmb_MotorHacmi.Text);
                    komut.Parameters.AddWithValue("@11", cmb_MotorGucu.Text);
                    komut.Parameters.AddWithValue("@12", cmb_Klima.Text);
                    komut.Parameters.AddWithValue("@13", "Uygun");
                    komut.ExecuteNonQuery();
                    AracGetir();
                    MessageBox.Show("Araç Başarıyla Eklendi !");
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen Girdiğiniz Araç Bilgilerini Kontrol Edip Tekrar Deneyiniz Hata Mesajı :\n\n" + ex.Message);
                }

            }
            baglanti.Close();
        }

        void AracGetir()
        {
            string sorgu = "select * from aracİslemleri";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "aracİslemleri");
            dgv_aracİslemleri.DataSource = ds.Tables[0];

        }

        

        private void dgv_aracİslemleri_Click(object sender, EventArgs e)
        {
            if (dgv_aracİslemleri.CurrentRow.Cells["Arac_id"].Value.ToString() == "")
            {
                MessageBox.Show("Boş Alanı Seçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                txt_AracPlaka.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[1].Value.ToString();
                cmb_Marka.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[2].Value.ToString();
                cmb_Model.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[3].Value.ToString();
                cmb_garanti.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[4].Value.ToString();
                cmb_Yil.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[5].Value.ToString();
                cmb_Renk.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[6].Value.ToString();
                cmb_yakit.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[7].Value.ToString();
                cmb_vitesTipi.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[8].Value.ToString();
                txt_Km.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[9].Value.ToString();
                cmb_MotorHacmi.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[10].Value.ToString();
                cmb_MotorGucu.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[11].Value.ToString();
                cmb_Klima.Text = dgv_aracİslemleri.Rows[dgv_aracİslemleri.CurrentRow.Index].Cells[12].Value.ToString();
                
            }
        }

        private void btn_AracGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                DialogResult guncelle;
                guncelle = MessageBox.Show("Araç Bilgileri Güncellenecektir", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (guncelle == DialogResult.Yes && dgv_aracİslemleri.CurrentRow.Cells[0].Value.ToString().Trim() != " ")
                {
                    string satirGuncelle = dgv_aracİslemleri.CurrentRow.Cells["Arac_id"].Value.ToString();

                    string sorgu = "update  aracİslemleri set AracPlakasi=@1,AracMarka=@2,Model=@3,Garanti=@4,Yil=@5,Renk=@6,Yakit=@7,VitesTipi=@8,Km=@9,MotorHacmi=@10,MotorGucu=@11,Klima=@12 where Arac_id=" + satirGuncelle + "";

                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@1", txt_AracPlaka.Text);
                    komut.Parameters.AddWithValue("@2", cmb_Marka.Text);
                    komut.Parameters.AddWithValue("@3", cmb_Model.Text);
                    komut.Parameters.AddWithValue("@4", cmb_garanti.Text);
                    komut.Parameters.AddWithValue("@5", cmb_Yil.Text);
                    komut.Parameters.AddWithValue("@6", cmb_Renk.Text);
                    komut.Parameters.AddWithValue("@7", cmb_yakit.Text);
                    komut.Parameters.AddWithValue("@8", cmb_vitesTipi.Text);
                    komut.Parameters.AddWithValue("@9", txt_Km.Text);
                    komut.Parameters.AddWithValue("@10", cmb_MotorHacmi.Text);
                    komut.Parameters.AddWithValue("@11", cmb_MotorGucu.Text);
                    komut.Parameters.AddWithValue("@12", cmb_Klima.Text);
                    komut.ExecuteNonQuery();
                    AracGuncelle();
                    MessageBox.Show("Araç Bilgileri Başarı İle Güncellendi");
                    temizle();

                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi İptal Edildi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Güncelleme Hatası", ex.Message);
            }
            baglanti.Close();
        }


        void AracGuncelle()
        {
            string sorgu = "select * from aracİslemleri";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "aracİslemleri");
            dgv_aracİslemleri.DataSource = ds.Tables[0];
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DialogResult sil;
            sil = MessageBox.Show("Arac Bilgilerini Silmek İstediğinizden Eminmisiniz", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sil==DialogResult.Yes && dgv_aracİslemleri.CurrentRow.Cells[0].Value.ToString().Trim() !="")
            {
                string satirSil = dgv_aracİslemleri.CurrentRow.Cells["Arac_id"].Value.ToString();
                string sorgu = "delete from aracİslemleri where Arac_id=" + satirSil + "";
                komut =new OleDbCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                AracSil();
                MessageBox.Show("Araç Başarı İle Silindi");
                temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }
            baglanti.Close();
        }

        void AracSil()
        {
            string sorgu = "select * from aracİslemleri";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "aracİslemleri");
            dgv_aracİslemleri.DataSource = ds.Tables[0];
        }

        void temizle()
        {
            txt_AracPlaka.Clear();
            cmb_Marka.SelectedIndex = -1;
            cmb_Model.SelectedIndex = -1;
            cmb_garanti.SelectedIndex = 0;
            cmb_Yil.SelectedIndex = 0;
            cmb_Renk.SelectedIndex = 0;
            cmb_yakit.SelectedIndex = 0;
            cmb_vitesTipi.SelectedIndex = 0;
            txt_Km.Clear();
            cmb_MotorHacmi.SelectedIndex = 0;
            cmb_MotorGucu.SelectedIndex = 0;
            cmb_Klima.SelectedIndex = 0;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from aracİslemleri where AracPlakasi like '%" + txt_ara.Text + "%'", baglanti2);
            DataSet ds2 = new DataSet();
            baglanti2.Open();
            da2.Fill(ds2, "aracİslemleri");
            dgv_aracİslemleri.DataSource = ds2.Tables["aracİslemleri"];
            baglanti2.Close();
        }

        void dgvDoldur()
        {
            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from aracİslemleri ", baglanti2);
            DataSet ds2 = new DataSet();
            baglanti2.Open();
            da2.Fill(ds2, "aracİslemleri");
            dgv_aracİslemleri.DataSource = ds2.Tables["aracİslemleri"];
            baglanti2.Close();
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            dgvDoldur();
        }

        private void cmb_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Marka.SelectedValue == null)

                return;

            string sorgu = "SELECT * FROM AracModel WHERE aMarkaid = ?";
            OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("aMarkaid", cmb_Marka.SelectedValue);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmb_Model.DisplayMember = "AracModelAd";
            cmb_Model.ValueMember = "aModelid";
            cmb_Model.DataSource = ds.Tables[0];
        }

        private void dgv_aracİslemleri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_aracİslemleri.Rows[e.RowIndex].Selected)
            {

                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.White;

            }
        }

        void baslik()
        {
            dgv_aracİslemleri.Columns[1].HeaderText = "Araç Plakası";
            dgv_aracİslemleri.Columns[2].HeaderText = "Araç Markası";
            dgv_aracİslemleri.Columns[3].HeaderText = "Aracın Modeli";
            dgv_aracİslemleri.Columns[4].HeaderText = "Garanti";
            dgv_aracİslemleri.Columns[5].HeaderText = "Yıl";
            dgv_aracİslemleri.Columns[6].HeaderText = "Renk";
            dgv_aracİslemleri.Columns[7].HeaderText = "Yakıt";
            dgv_aracİslemleri.Columns[8].HeaderText = "Vites Tipi";
            dgv_aracİslemleri.Columns[9].HeaderText = "Aracın Km'si";
            dgv_aracİslemleri.Columns[10].HeaderText = "Motor Hacmi";
            dgv_aracİslemleri.Columns[11].HeaderText = "Motor Gücü";
            dgv_aracİslemleri.Columns[12].HeaderText = "Klima";
        }
    }
}
