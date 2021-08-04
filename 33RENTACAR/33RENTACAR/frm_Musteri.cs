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
    public partial class frm_Musteri : Form
    {
        public frm_Musteri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        OleDbCommand komut;

        //arama butonu için 
        OleDbConnection baglanti2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
        private void frm_Musteri_Load(object sender, EventArgs e)
        {
            foreach (Form frm_Musteri in this.MdiChildren)
            {
                frm_Musteri.WindowState = FormWindowState.Maximized;
            }

          // İl ve İlçeler için  
            OleDbConnection baglantiil = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");
            OleDbCommand veriİl = new OleDbCommand("SELECT * FROM iller", baglantiil);
            DataTable iller = new DataTable();
            OleDbDataAdapter il = new OleDbDataAdapter(veriİl);
            il.Fill(iller);
            cmb_Dyeri.DisplayMember = "iller";
            cmb_Dyeri.ValueMember = "illerId";
            cmb_Dyeri.DataSource = iller;
            cmb_Dyeri.SelectedIndex = 0;
            cmb_ilce.SelectedIndex = 0;
            cmb_cinsiyet.SelectedIndex = 0;

            VeriKaydet();  
            KayitGuncelle();
            kayitSil();
            dgv_musteri.Columns[0].Visible = false;
            ControlBox = false;
            baslik();         
            cmb_EverilisYeri.SelectedIndex = 0;

            this.WindowState = FormWindowState.Maximized;
            
           dgv_musteri.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_musteri_CellFormatting);
          
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            if (txt_Tc.Text=="")
            {
                error.SetError(txt_Tc, "Bu Alan Boş Geçilemez");
            }
            else
            {
                error.Clear();

                if (txt_Tc.Text.Length < 11)
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz !"+ Environment.NewLine + "TC kimlik Nonuzu Kontrol ediniz","Eksik Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (txt_Tc.Text == "" || txt_Ad.Text == "" || txt_Soyad.Text == "" ||cmb_cinsiyet.Text == "" || dtp_Dtarihi.Text == "" ||
                    cmb_Dyeri.Text == "" || cmb_ilce.Text == "" || txt_Cep.Text == "" || txt_Ev.Text == "" || txt_Eposta.Text == "" || txt_Adres.Text == "" ||
                    txt_Eno.Text == "" || cmb_EverilisYeri.Text == "" || dtp_EverilisTarihi.Text == "")
                    {

                        MessageBox.Show("Doldurulması Zorunlu Alanlar var ", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        try
                        {
                            string sorgu = "INSERT INTO musteri (TcNo,Ad,Soyad,Cinsiyet,Dtarihi,DYeri,ilce,CepTel,EvTel,Eposta,Adres,EhliyetTipi,EhliyetNo,EhliyetVerilisYer,EhliyetVerisTarih) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15)";
                            komut = new OleDbCommand(sorgu, baglanti);
                            komut.Parameters.AddWithValue("@1", txt_Tc.Text);
                            komut.Parameters.AddWithValue("@2", txt_Ad.Text);
                            komut.Parameters.AddWithValue("@3", txt_Soyad.Text);
                            komut.Parameters.AddWithValue("@4", cmb_cinsiyet.Text);
                            komut.Parameters.AddWithValue("@5", dtp_Dtarihi.Text);
                            komut.Parameters.AddWithValue("@6", cmb_Dyeri.Text);
                            komut.Parameters.AddWithValue("@7", cmb_ilce.Text);
                            komut.Parameters.AddWithValue("@8", txt_Cep.Text);
                            komut.Parameters.AddWithValue("@9", txt_Ev.Text);
                            komut.Parameters.AddWithValue("@10", txt_Eposta.Text);
                            komut.Parameters.AddWithValue("@11", txt_Adres.Text);
                            komut.Parameters.AddWithValue("@12", txt_Etip.Text);
                            komut.Parameters.AddWithValue("@13", txt_Eno.Text);
                            komut.Parameters.AddWithValue("@14", cmb_EverilisYeri.Text);
                            komut.Parameters.AddWithValue("@15", dtp_EverilisTarihi.Value);   
                            komut.ExecuteNonQuery();
                            VeriKaydet();
                            MessageBox.Show("Müşteri Başarıyla Eklendi !");
                            temizle();
                            
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Lütfen Girdiğiniz Bilgileri Kontrol Edip Tekrar Deneyiniz Hata Mesajı :\n\n" + ex.Message);
                        }
                    }
                }
            }
            baglanti.Close();
        }
          void VeriKaydet()
        {
            string sorgu = "SELECT * FROM musteri";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "musteri");
            dgv_musteri.DataSource = ds.Tables[0];
        }

          private void btn_Guncelle_Click(object sender, EventArgs e)
          {
              baglanti.Open();
              if (txt_Tc.Text=="")
              {
                  MessageBox.Show("Bilgilerinizi Kontrol Ediniz !" + Environment.NewLine + "TC kimlik Nonuzu Kontrol ediniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              }
              else
              {
                  try
                  {
                      DialogResult guncelle;
                      guncelle = MessageBox.Show("Müşteri Bilgilerinizi Güncellemek İstediğinizden Eminmisiniz","Uyarı ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                      if (guncelle == DialogResult.Yes && dgv_musteri.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                      {
                          string satirGuncelle = dgv_musteri.CurrentRow.Cells["musteri_id"].Value.ToString();

                          string sorgu = "Update musteri set TcNo=@1,Ad=@2,Soyad=@3,Cinsiyet=@4,Dtarihi=@5,DYeri=@6,ilce=@7,CepTel=@8,EvTel=@9,Eposta=@10,Adres=@11,EhliyetTipi=@12,EhliyetNo=@13,EhliyetVerilisYer=@14,EhliyetVerisTarih=@15 where musteri_id= " + satirGuncelle + " ";

                          komut = new OleDbCommand(sorgu, baglanti);
                          komut.Parameters.AddWithValue("@1", txt_Tc.Text);
                          komut.Parameters.AddWithValue("@2", txt_Ad.Text);
                          komut.Parameters.AddWithValue("@3", txt_Soyad.Text);
                          komut.Parameters.AddWithValue("@4", cmb_cinsiyet.Text);
                          komut.Parameters.AddWithValue("@5", dtp_Dtarihi.Text);
                          komut.Parameters.AddWithValue("@6", cmb_Dyeri.Text);
                          komut.Parameters.AddWithValue("@7", cmb_ilce.Text);
                          komut.Parameters.AddWithValue("@8", txt_Cep.Text);
                          komut.Parameters.AddWithValue("@9", txt_Ev.Text);
                          komut.Parameters.AddWithValue("@10", txt_Eposta.Text);
                          komut.Parameters.AddWithValue("@11", txt_Adres.Text);
                          komut.Parameters.AddWithValue("@12", txt_Etip.Text);
                          komut.Parameters.AddWithValue("@13", txt_Eno.Text);
                          komut.Parameters.AddWithValue("@14", cmb_EverilisYeri.Text);
                          komut.Parameters.AddWithValue("@15", dtp_EverilisTarihi.Value);  
                          komut.ExecuteNonQuery();
                          KayitGuncelle();
                          MessageBox.Show("Müşteri Bilgileri Başarı İle Güncellendi.");
                          temizle();
                         
                      }
                      else
                      {
                          MessageBox.Show("Güncelleme İşlemi İptal Edildi ");
                      }
                  }
                  catch (Exception ex)
                  {

                      MessageBox.Show("Güncelleme Hatası" + ex.Message);
                  }
              }
              baglanti.Close();
          }

          void KayitGuncelle()
          {
              string sorgu = "select * from musteri";
              OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
              DataSet ds = new DataSet();
              da.Fill(ds, "musteri");
              dgv_musteri.DataSource = ds.Tables[0];
          }

          private void dgv_musteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              
          }

          private void dgv_musteri_Click(object sender, EventArgs e)
          {
              
                  txt_Tc.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[1].Value.ToString();
                  txt_Ad.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[2].Value.ToString();
                  txt_Soyad.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[3].Value.ToString();
                  cmb_cinsiyet.SelectedItem = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[4].Value.ToString();
                  dtp_Dtarihi.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[5].Value.ToString();
                  cmb_Dyeri.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[6].Value.ToString();
                  cmb_ilce.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[7].Value.ToString();
                  txt_Cep.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[8].Value.ToString();
                  txt_Ev.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[9].Value.ToString();
                  txt_Eposta.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[10].Value.ToString();
                  txt_Adres.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[11].Value.ToString();
                  txt_Etip.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[12].Value.ToString();
                  txt_Eno.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[13].Value.ToString();
                  cmb_EverilisYeri.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[14].Value.ToString();
                  dtp_EverilisTarihi.Text = dgv_musteri.Rows[dgv_musteri.CurrentRow.Index].Cells[15].Value.ToString();
              
         
          }

          void baslik()
          {
              dgv_musteri.Columns[1].HeaderText="TC Kimlik";
              dgv_musteri.Columns[2].HeaderText="Ad";
              dgv_musteri.Columns[3].HeaderText="Soyad";
              dgv_musteri.Columns[4].HeaderText="Cinsiyet";
              dgv_musteri.Columns[5].HeaderText = "Doğum Tarihi";
              dgv_musteri.Columns[6].HeaderText="Kayıtlı Olduğu İl";
              dgv_musteri.Columns[7].HeaderText = "İlçe";
              dgv_musteri.Columns[8].HeaderText = "Cep Telefonu";
              dgv_musteri.Columns[9].HeaderText="Ev Telefonu";
              dgv_musteri.Columns[10].HeaderText="E-Posta";
              dgv_musteri.Columns[11].HeaderText="Adres";
              dgv_musteri.Columns[12].HeaderText="Ehliyet Tipi";
              dgv_musteri.Columns[13].HeaderText="Ehliyet No";
              dgv_musteri.Columns[14].HeaderText="Ehliyet Verildiği Yer";
              dgv_musteri.Columns[15].HeaderText="Ehliyet Verildiği Tarih";
          }

          private void btn_Sil_Click(object sender, EventArgs e)
          {
              baglanti.Open();

              DialogResult sil;
              sil = MessageBox.Show("Müşteri Silinecektir Silmek istediğinizden Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (sil == DialogResult.Yes && dgv_musteri.CurrentRow.Cells[0].Value.ToString().Trim() != "")
              {
                  string satirSil = dgv_musteri.CurrentRow.Cells["musteri_id"].Value.ToString();
                  string sorgu = "delete from musteri where musteri_id=" + satirSil + " ";
                  komut = new OleDbCommand(sorgu, baglanti);
                  komut.ExecuteNonQuery();
                  kayitSil();
                  MessageBox.Show("Müşteri Başarı İle Silindi.");
                  temizle();
              }
              else
              {
                  MessageBox.Show("Silme İşlemi İptal edildi.");
              }
              baglanti.Close();
          }
          void kayitSil()
          {
              string sorgu = "select * from musteri";
              OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
              DataSet ds2 = new DataSet();
              da.Fill(ds2, "musteri");
              dgv_musteri.DataSource = ds2.Tables[0];
          }
          void temizle()
          {
              txt_Ad.Clear();
              txt_Soyad.Clear();
              txt_Tc.Clear();
              txt_Adres.Clear();
              txt_Cep.Clear();
              txt_Eno.Clear();
              txt_Eposta.Clear();
              txt_Etip.Clear();
              txt_Ev.Clear();
              cmb_Dyeri.SelectedIndex = -1;
              cmb_ilce.SelectedIndex = -1;
              cmb_EverilisYeri.SelectedIndex = -1;
              cmb_cinsiyet.SelectedIndex = 0;
              
          }

          private void btn_Temizle_Click(object sender, EventArgs e)
          {
              temizle();
          }

          private void txt_ara_TextChanged(object sender, EventArgs e)
          {
              dgvDoldur();
          }

          

          private void btnKapat_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          private void btnAra_Click(object sender, EventArgs e)
          {

              OleDbDataAdapter da2 = new OleDbDataAdapter("select * from musteri where TcNo like '%" + txt_ara.Text + "%' or Ad like '%" + txt_ara.Text + "%'", baglanti2);
              DataSet ds2 = new DataSet();
              baglanti2.Open();
              da2.Fill(ds2, "musteri");
              dgv_musteri.DataSource = ds2.Tables["musteri"];
              baglanti2.Close();
              
              
          }

          void dgvDoldur()
          {
              OleDbDataAdapter da2 = new OleDbDataAdapter("select * from musteri ", baglanti2);
              DataSet ds2 = new DataSet();
              baglanti2.Open();
              da2.Fill(ds2, "musteri");
              dgv_musteri.DataSource = ds2.Tables["musteri"];
              baglanti2.Close();
          }

          private void cmb_Dyeri_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (cmb_Dyeri.SelectedValue == null)

                  return;

              string sorgu1 = "SELECT * FROM ilceler WHERE illerId = ?";
              OleDbCommand cmd1 = new OleDbCommand(sorgu1, baglanti);
              cmd1.Parameters.AddWithValue("illerId", cmb_Dyeri.SelectedValue);
              OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
              DataSet ds1 = new DataSet();
              da1.Fill(ds1);
              cmb_ilce.DisplayMember = "ilceler";
              cmb_ilce.ValueMember = "ilcelerId";
              cmb_ilce.DataSource = ds1.Tables[0];
          }

          private void dgv_musteri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
              if (dgv_musteri.Rows[e.RowIndex].Selected)

                  {

            e.CellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                 e.CellStyle.SelectionBackColor = Color.Red;
              e.CellStyle.SelectionForeColor = Color.White;

                  }
          }

          private void txt_Tc_KeyPress(object sender, KeyPressEventArgs e)
          {
              
              switch (e.KeyChar)
              {
                  case '1':
                  case '2':
                  case '3':
                  case '4':
                  case '5':
                  case '6':
                  case '7':
                  case '8':
                  case '9':
                  case '0':
                  case '\b':
                      break;
                  default:
                      MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz", "Uyarı");       
                      break;
              }
          }

          private void txt_Cep_KeyPress(object sender, KeyPressEventArgs e)
          {
              switch (e.KeyChar)
              {
                  case '1':
                  case '2':
                  case '3':
                  case '4':
                  case '5':
                  case '6':
                  case '7':
                  case '8':
                  case '9':
                  case '0':
                  case '\b':
                      break;
                  default:
                      MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz", "Uyarı");
                      break;
              }
          }

          private void txt_Ev_KeyPress(object sender, KeyPressEventArgs e)
          {
              switch (e.KeyChar)
              {
                  case '1':
                  case '2':
                  case '3':
                  case '4':
                  case '5':
                  case '6':
                  case '7':
                  case '8':
                  case '9':
                  case '0':
                  case '\b':
                      break;
                  default:
                      MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz", "Uyarı");
                      break;
              }
          }

          private void txt_Eno_KeyPress(object sender, KeyPressEventArgs e)
          {
              switch (e.KeyChar)
              {
                  case '1':
                  case '2':
                  case '3':
                  case '4':
                  case '5':
                  case '6':
                  case '7':
                  case '8':
                  case '9':
                  case '0':
                  case '\b':
                      break;
                  default:
                      MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz", "Uyarı");
                      break;
              }
          }

          private void label15_Click(object sender, EventArgs e)
          {

          }

          private void cmb_ilce_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          
  
        
    }
}
