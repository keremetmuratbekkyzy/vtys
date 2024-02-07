using System.Data.SqlClient;
using System.Data;

namespace vtys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PSKPUPE\\SQLEXPRESS;Initial Catalog=vtys;Integrated Security=True;TrustServerCertificate=True");
        DataSet datset = new DataSet();
        
        

        private void btnpekle_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into proje(projeID, projeAd, bitis, baslangic, durum ) " +
                "values(@projeID, @projeAd, @bitis, @baslangic, @durum)", baglanti);
            komut.Parameters.AddWithValue("@projeID", txtpid.Text);
            komut.Parameters.AddWithValue("@projeAd", txtpad.Text);
            komut.Parameters.AddWithValue("@baslangic", dtbas.Value);
            komut.Parameters.AddWithValue("@bitis", dtbit.Value);
            komut.Parameters.AddWithValue("@durum", cmbdur.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            projegoster();

            MessageBox.Show("Proje eklendi");
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


        private void btnpgun_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update proje set projeAd=@projeAd, bitis=@bitis, baslangic=@baslangic," +
                " durum=@durum where projeID=@projeID", baglanti);
            komut.Parameters.AddWithValue("@projeID", txtpid.Text);
            komut.Parameters.AddWithValue("@projeAd", txtpad.Text);
            komut.Parameters.AddWithValue("@baslangic", dtbas.Value);
            komut.Parameters.AddWithValue("@bitis", dtbit.Value);
            komut.Parameters.AddWithValue("@durum", cmbdur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            projegoster();

            MessageBox.Show("Proje bilgileri guncellendi");
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

        private void btnpsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from proje where ProjeID='" + 
                dataGridView1.CurrentRow.Cells["ProjeID"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            datset.Tables.Clear();
            projegoster();
            MessageBox.Show("Proje Silindi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void durumgoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from durum ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbdur.Items.Add(read["durum"].ToString());
            }
            baglanti.Close();
        }
        private void projegoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from proje", baglanti);
            adtr.Fill(datset, "proje");
            dataGridView1.DataSource = datset.Tables["proje"];
            baglanti.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            durumgoster();
            projegoster();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dataGridView1.CurrentRow.Cells["projeID"].Value.ToString();
            txtpad.Text = dataGridView1.CurrentRow.Cells["projeAd"].Value.ToString();
            dtbas.Text = dataGridView1.CurrentRow.Cells["baslangic"].Value.ToString();
            dtbit.Text = dataGridView1.CurrentRow.Cells["bitis"].Value.ToString();
            cmbdur.Text = dataGridView1.CurrentRow.Cells["durum"].Value.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmcalisan ekle = new frmcalisan();
            ekle.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            frmgorevler ekle = new frmgorevler();
            ekle.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

