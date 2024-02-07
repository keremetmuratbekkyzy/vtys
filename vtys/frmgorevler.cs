using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace vtys
{
    public partial class frmgorevler : Form
    {
        public frmgorevler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PSKPUPE\\SQLEXPRESS;Initial Catalog=vtys;Integrated Security=True;TrustServerCertificate=True");
        DataSet datset = new DataSet();

        private void frmgorevler_Load(object sender, EventArgs e)
        {
            gorevgoster();
            durumgoster();
            projegoster();
            calisangoster();
            HesaplaVeKaydet();

        }



        private void projegoster()
        {
            try
            {
                // Projeleri veritabanından çekme
                string query = "select projeID, projeAd from proje";
                SqlDataAdapter adtr = new SqlDataAdapter(query, baglanti);
                DataTable proje = new DataTable();
                adtr.Fill(proje);

                // ComboBox'a projeleri ekleme
                cmbp.DataSource = proje;
                cmbp.DisplayMember = "projeAd";
                cmbp.ValueMember = "projeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void calisangoster()
        {
            try
            {
                // Projeleri veritabanından çekme
                string query = "select calisanID, calisanAd from calisanlar";
                SqlDataAdapter adtr = new SqlDataAdapter(query, baglanti);
                DataTable calisanlar = new DataTable();
                adtr.Fill(calisanlar);

                // ComboBox'a projeleri ekleme
                cmbc.DataSource = calisanlar;
                cmbc.DisplayMember = "calisanAd";
                cmbc.ValueMember = "calisanID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void gorevgoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from gorevler", baglanti);
            adtr.Fill(datset, "gorevler");
            dataGridView1.DataSource = datset.Tables["gorevler"];
            baglanti.Close();
        }
        private void durumgoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from durum ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbd.Items.Add(read["Durum"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int projeId = Convert.ToInt32(cmbp.SelectedValue);
                int calisanId = Convert.ToInt32(cmbc.SelectedValue);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into gorevler(gorevID,gorevAdi,durum,projeId,calisanId,baslangic,bitis,gecikme)"
                    +" values(@gorevID,@gorevAdi,@durum,@projeId,@calisanId,@baslangic,@bitis,@gecikme)", baglanti);
                komut.Parameters.AddWithValue("@gorevID", txtgid.Text);
                komut.Parameters.AddWithValue("@gorevAdi", txtgad.Text);
                komut.Parameters.AddWithValue("@durum", cmbd.Text);
                komut.Parameters.AddWithValue("@projeId", Convert.ToInt32(cmbp.SelectedValue));
                komut.Parameters.AddWithValue("@calisanId", Convert.ToInt32(cmbc.SelectedValue));
                komut.Parameters.AddWithValue("@baslangic", dbas.Value);
                komut.Parameters.AddWithValue("@bitis", dbit.Value);
                komut.Parameters.AddWithValue("@gecikme", txtgec.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                datset.Tables.Clear();
                gorevgoster();
                HesaplaVeKaydet();
                MessageBox.Show("Görev eklendi");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int projeId = Convert.ToInt32(cmbp.SelectedValue);
                int calisanId = Convert.ToInt32(cmbc.SelectedValue);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update gorevler set gorevAdi=@gorevAdi, projeId=@projeId, calisanId=@calisanId, " +
                    "durum=@durum, baslangic=@baslangic, bitis=@bitis, gecikme=@gecikme where gorevID=@gorevID", baglanti);
                komut.Parameters.AddWithValue("@gorevID", txtgid.Text);
                komut.Parameters.AddWithValue("@gorevAdi", txtgad.Text);
                komut.Parameters.AddWithValue("@projeId", Convert.ToInt32(cmbp.SelectedValue));
                komut.Parameters.AddWithValue("@calisanId", Convert.ToInt32(cmbc.SelectedValue));
                komut.Parameters.AddWithValue("@durum", cmbd.Text);
                komut.Parameters.AddWithValue("@baslangic", dbas.Value);
                komut.Parameters.AddWithValue("@bitis", dbit.Value);
                komut.Parameters.AddWithValue("@gecikme", txtgec.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                datset.Tables.Clear();
                gorevgoster();
                HesaplaVeKaydet();

                MessageBox.Show("Görev bilgileri güncellendi");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from gorevler where gorevID='" + 
                dataGridView1.CurrentRow.Cells["gorevID"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            gorevgoster();
            MessageBox.Show("Görev Silindi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtgid.Text = dataGridView1.CurrentRow.Cells["gorevID"].Value.ToString();
            txtgad.Text = dataGridView1.CurrentRow.Cells["gorevAdi"].Value.ToString();
            dbas.Text = dataGridView1.CurrentRow.Cells["baslangic"].Value.ToString();
            dbit.Text = dataGridView1.CurrentRow.Cells["bitis"].Value.ToString();
            cmbd.Text = dataGridView1.CurrentRow.Cells["durum"].Value.ToString();
            cmbp.Text = dataGridView1.CurrentRow.Cells["projeId"].Value.ToString();
            cmbc.Text = dataGridView1.CurrentRow.Cells["calisanId"].Value.ToString();
            txtgec.Text = dataGridView1.CurrentRow.Cells["gecikme"].Value.ToString();

        }

        private void HesaplaVeKaydet()
        {
            try
            {

                DateTime bitisTarihi = dbit.Value;

                // Şu anki tarih ve saat bilgisini al
                DateTime suankiZaman = DateTime.Now;

                // Gecikme süresini hesapla (gün cinsinden)
                int gecikmeGun = (int)(suankiZaman - bitisTarihi).TotalDays;

                // Gecikme süresini TextBox'a yaz
                txtgec.Text = gecikmeGun.ToString();

                // Veritabanına kaydet
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE gorevler SET gecikme=@gecikme WHERE gorevID=@gorevID", baglanti);
                komut.Parameters.AddWithValue("@gecikme", gecikmeGun);
                komut.Parameters.AddWithValue("@gorevID", txtgid.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                datset.Tables.Clear();
                gorevgoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtbas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
