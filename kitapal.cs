using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace kutuphane
{
    public partial class kitapal : Form
    {
        public kitapal()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        public void listele()
        {
            
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM odunckitap ", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void baglan()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void kitapal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabanDataSet1.odunckitap' table. You can move, or remove it, as needed.
            this.odunckitapTableAdapter.Fill(this.tabanDataSet1.odunckitap);
           
            listele();
           
            


        }

        private void kitapvermealmaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitapvermealmaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string durum = "Teslim Edilmedi";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                textBox5.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                if (textBox5.Text == durum)
                {

                    Form yeni = new kitapalsekme2();
                    yeni.Show();
                }
                else
                {

                    MessageBox.Show("Kitap zaten verilmiş!");
                }
            }
            catch
            {
                MessageBox.Show("Seçim yapmadınız !");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from odunckitap where demirbas_no Like'" + textBox3.Text + "%'", baglanti);
            adaptor.Fill(ds, "odunckitap");
            dataGridView1.DataSource = ds.Tables["odunckitap"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from odunckitap where adi_soyadi Like'" + textBox1.Text + "%'", baglanti);
            adaptor.Fill(ds, "odunckitap");
            dataGridView1.DataSource = ds.Tables["odunckitap"];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from odunckitap where sinifi Like'" + textBox2.Text + "%'", baglanti);
            adaptor.Fill(ds, "odunckitap");
            dataGridView1.DataSource = ds.Tables["odunckitap"];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from odunckitap where kitabin_adi Like'" + textBox4.Text + "%'", baglanti);
            adaptor.Fill(ds, "odunckitap");
            dataGridView1.DataSource = ds.Tables["odunckitap"];
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
       

  
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
       
        }
        
    }
}
