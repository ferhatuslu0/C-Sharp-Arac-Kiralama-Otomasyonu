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
    public partial class frm_AracKirala : Form
    {
        public frm_AracKirala()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut4 = new OleDbCommand();

        private void frm_AracKirala_Load(object sender, EventArgs e)
        {
            aracKira();
            kayitSil();
            AracTeslim();
            ControlBox = false;
            komut.Connection = baglanti;
            komut2.Connection = baglanti;
            komut3.Connection = baglanti;
            komut4.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select TcNo from musteri";
            komut2.CommandText = "select AracPlakasi from aracİslemleri where Durum='Uygun'";
            
            
            OleDbDataReader oku = komut.ExecuteReader();
            OleDbDataReader oku2 = komut2.ExecuteReader();
            
            while (oku.Read())
            {
                cmb_Tc.Items.Add(oku[0].ToString());
            }
            while (oku2.Read())
            {
                cmb_Plaka.Items.Add(oku2[0].ToString());
            }
            
            baglanti.Close();
            baslik();

            this.WindowState = FormWindowState.Maximized;
            dgv_aracKirala.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_aracKirala_CellFormatting);
        }

        private void btn_Kirala_Click(object sender, EventArgs e)
        {
            if (cmb_Tc.Text=="" || cmb_Plaka.Text=="" || Mtxt_alisSaat.Text=="" || Mtxt_teslimSaat.Text=="" || txt_Fiyat.Text=="")
            {
                MessageBox.Show("Boş Geçilmemesi Gereken Alanlar Var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                     OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= vt.accdb");
                    OleDbCommand kayit = new OleDbCommand();
                    OleDbCommand guncelle = new OleDbCommand();
                    OleDbCommand durum = new OleDbCommand();
                    durum.Connection = baglanti;
                    guncelle.Connection = baglanti;
                    kayit.Connection = baglanti;
                        baglanti.Open(); 
                    kayit.CommandText = "INSERT INTO AracKiralama(TcKimlik,AracPlaka,AlisTarih,AlisSaat,TeslimTarih,TeslimSaat,Fiyat) VALUES(@1,@2,@3,@4,@5,@6,@7)";
                    kayit.Parameters.AddWithValue("@1", cmb_Tc.Text);
                    kayit.Parameters.AddWithValue("@2", cmb_Plaka.Text);
                    kayit.Parameters.AddWithValue("@3", dtp_alisTarih.Text);
                    kayit.Parameters.AddWithValue("@4", Mtxt_alisSaat.Text);
                    kayit.Parameters.AddWithValue("@5", dtp_teslimTarih.Text);
                    kayit.Parameters.AddWithValue("@6", Mtxt_teslimSaat.Text);
                    kayit.Parameters.AddWithValue("@7", txt_Fiyat.Text);
                    guncelle.CommandText = "Update aracİslemleri set Durum='" + "Kiralandı" + "' where AracPlakasi='" + cmb_Plaka.Text + "'";
                    durum.CommandText = "Select AracPlakasi from aracİslemleri Where Durum='Uygun'";
                    kayit.ExecuteNonQuery();
                    guncelle.ExecuteNonQuery();
                    temizle();
                    MessageBox.Show("Araç Kiralandı");
                    OleDbDataReader oku = durum.ExecuteReader();
                    while (oku.Read())
                    {
                        cmb_Plaka.Items.Add(oku[0].ToString());

                    }
                        baglanti.Close();
                    baglanti.Close();
                    txt_Fiyat.Clear();
                    aracKira();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        void aracKira()
        {
            string sorgu = "select * from AracKiralama";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "AracKiralama");
            dgv_aracKirala.DataSource = ds.Tables[0];
            dgv_aracKirala.Columns[0].Visible = false;
        }

        private void dgv_aracKirala_Click(object sender, EventArgs e)
        {
           
                cmb_Tc.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[1].Value.ToString();
                cmb_Plaka.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[2].Value.ToString();
                dtp_alisTarih.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[3].Value.ToString();
                Mtxt_alisSaat.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[4].Value.ToString();
                dtp_teslimTarih.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[5].Value.ToString();
                Mtxt_teslimSaat.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[6].Value.ToString();
                txt_Fiyat.Text = dgv_aracKirala.Rows[dgv_aracKirala.CurrentRow.Index].Cells[7].Value.ToString();
           
            

        }

        private void Mtxt_teslimSaat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Mtxt_alisSaat_Leave(object sender, EventArgs e)
        {
            
                Mtxt_teslimSaat.Text = Mtxt_alisSaat.Text;
     
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void temizle()
        {
            cmb_Tc.SelectedIndex = -1;
            cmb_Plaka.SelectedIndex = -1;
            Mtxt_alisSaat.Clear();
            Mtxt_teslimSaat.Clear();
            txt_Fiyat.Clear();
            txt_Toplam.Clear();
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
                baglanti.Open();
            DialogResult sil;
            sil = MessageBox.Show("Kiralanan Araç Bilgileri silinecektir! Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sil==DialogResult.Yes && dgv_aracKirala.CurrentRow.Cells[0].Value.ToString().Trim() !="")
            {
                string satirSil = dgv_aracKirala.CurrentRow.Cells["AracKira_id"].Value.ToString();
                string sorgu = "delete from AracKiralama where AracKira_id=" + satirSil + "";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                kayitSil();
                MessageBox.Show("Kayıt Başarı İle silindi");
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }
                baglanti.Close();
        }

        void kayitSil()
        {
            string sorgu = "select * from AracKiralama";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "AracKiralama");
            dgv_aracKirala.DataSource = ds.Tables[0];
        }

        private void btn_aTeslimAl_Click(object sender, EventArgs e)
        {
            if (cmb_PlakaTeslim.Text=="")
            {
                MessageBox.Show("Lütfen Teslim Almak İstediğiniz Aracın Plakasını Seçin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= vt.accdb");
                    OleDbCommand guncelle = new OleDbCommand();
                    OleDbCommand Plakadurum = new OleDbCommand();
                    OleDbCommand Aracdurum = new OleDbCommand();
                    guncelle.Connection = baglanti;
                    Plakadurum.Connection = baglanti;
                    Aracdurum.Connection = baglanti;
                        baglanti.Open();
                    guncelle.CommandText = "update aracİslemleri set Durum='" + "Uygun" + "' where AracPlakasi='" + cmb_Plaka.Text + "'";
                    Aracdurum.CommandText = "update aracİslemleri set Durum='" + "Uygun" + "' where AracPlakasi='" + cmb_PlakaTeslim.Text + "'";
                    guncelle.ExecuteNonQuery();
                    Aracdurum.ExecuteNonQuery();
                    MessageBox.Show("Araç Teslim Alındı");
                    Plakadurum.CommandText = "select AracPlakasi from aracİslemleri where Durum='Kiralandı'";
                    OleDbDataReader oku = Plakadurum.ExecuteReader();
                    while (oku.Read())
                    {
                        cmb_Plaka.Items.Add(oku[0].ToString());
                    }
                        baglanti.Close();
                    AracTeslim();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        void AracTeslim()
        {
            cmb_PlakaTeslim.Items.Clear();
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= vt.accdb");
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.Connection = baglanti;
                baglanti.Open();
            guncelle.CommandText = "select AracPlakasi from aracİslemleri where Durum='Kiralandı'";
            OleDbDataReader oku = guncelle.ExecuteReader();
            while (oku.Read())
            {
                cmb_PlakaTeslim.Items.Add(oku[0].ToString());
            }
            dgv_aracKirala.Columns[0].Visible = false;
                baglanti.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from AracKiralama where TcKimlik like '%" + txt_ara.Text + "%' or AracPlaka like '%" + txt_ara.Text + "%'", baglanti);
            DataSet ds = new DataSet();
                baglanti.Open();  
            da.Fill(ds, "AracKiralama");
            dgv_aracKirala.DataSource = ds.Tables["AracKiralama"];
                baglanti.Close();
           
        }

        void dgvDoldur()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from AracKiralama", baglanti);
            DataSet ds = new DataSet();
                baglanti.Open();
            da.Fill(ds, "AracKiralama");
            dgv_aracKirala.DataSource = ds.Tables["AracKiralama"];
            baglanti.Close();
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            dgvDoldur();
        }

        private void dgv_aracKirala_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_aracKirala.Rows[e.RowIndex].Selected)
            {

                e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.White;

            }
        }

        void baslik()
        {
            dgv_aracKirala.Columns[1].HeaderText = "Tc Kimlik No";
            dgv_aracKirala.Columns[2].HeaderText = "Araç Plakası";
            dgv_aracKirala.Columns[3].HeaderText = "Araç Alış Tarihi";
            dgv_aracKirala.Columns[4].HeaderText = "Araç Alış Saati";
            dgv_aracKirala.Columns[5].HeaderText = "Araç Teslim Tarihi";
            dgv_aracKirala.Columns[6].HeaderText = "Araç Teslim Saati";
            dgv_aracKirala.Columns[7].HeaderText = "Araç Fiyatı";
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            DateTime alis = dtp_alisTarih.Value;
            DateTime teslim = dtp_teslimTarih.Value;

            System.TimeSpan zaman;
            zaman = teslim.Subtract(alis);
            int toplamGun = Convert.ToInt32(zaman.TotalDays);

            int fiyat = Convert.ToInt32(txt_Fiyat.Text);

            int toplamFiyat;
            toplamFiyat = toplamGun * fiyat;

            txt_Toplam.Text = toplamFiyat.ToString();  
        }

        private void txt_Toplam_TextChanged(object sender, EventArgs e)
        {
            txt_Fiyat.Text = txt_Toplam.Text;
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut3.CommandText = "select Ad from musteri";
            komut4.CommandText = "select Soyad from musteri";
            OleDbDataReader oku3 = komut3.ExecuteReader();
            OleDbDataReader oku4 = komut4.ExecuteReader();
            while (oku3.Read())
            {
                cmb_musteriAd.Items.Add(oku3[0].ToString());
            }
            while (oku4.Read())
            {
                cmb_musteriSoyad.Items.Add(oku4[0].ToString());
            }
            baglanti.Close();

            cmb_musteriAd.SelectedIndex = 0;
            cmb_musteriSoyad.SelectedIndex = 0;
        }

       
    }
}
