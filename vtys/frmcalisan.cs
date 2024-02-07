using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace vtys
{
    public partial class frmcalisan : Form
    {
        public frmcalisan()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PSKPUPE\\SQLEXPRESS;Initial Catalog=vtys;Integrated Security=True;TrustServerCertificate=True");
        DataSet datset = new DataSet();
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into calisanlar(calisanID,calisanAd,calisanSoyad) " +
                "values(@calisanID,@calisanAd,@calisanSoyad)", baglanti);
            komut.Parameters.AddWithValue("@calisanID", txtcalid.Text);
            komut.Parameters.AddWithValue("@calisanAd", txtcalad.Text);
            komut.Parameters.AddWithValue("@calisanSoyad", txtcalsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            Goster();
            MessageBox.Show("Çalışan eklendi");
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
            try { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update calisanlar set  calisanAd=@calisanAd, calisanSoyad=@calisanSoyad" +
                " where calisanID=@calisanID", baglanti);
            komut.Parameters.AddWithValue("@calisanID", txtcalid.Text);
            komut.Parameters.AddWithValue("@calisanAd", txtcalad.Text);
            komut.Parameters.AddWithValue("@calisanSoyad", txtcalsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            Goster();
            MessageBox.Show("Çalışan bilgileri güncellendi");
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from calisanlar where calisanID='" + 
                dataGridView1.CurrentRow.Cells["calisanID"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            Goster();
            MessageBox.Show("Silindi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void frmcalisan_Load(object sender, EventArgs e)
        {
            Goster();

        }

        private void Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from calisanlar", baglanti);
            adtr.Fill(datset, "calisanlar");
            dataGridView1.DataSource = datset.Tables["calisanlar"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcalid.Text = dataGridView1.CurrentRow.Cells["calisanID"].Value.ToString();
            txtcalad.Text = dataGridView1.CurrentRow.Cells["calisanAd"].Value.ToString();
            txtcalsoyad.Text = dataGridView1.CurrentRow.Cells["calisanSoyad"].Value.ToString();
          
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
