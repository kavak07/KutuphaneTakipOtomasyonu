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
    public partial class arama : Form
    {
        public arama()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
       

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

        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter liste = new OleDbDataAdapter("SELECT * FROM kitap_kayit", baglanti);
            liste.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void arama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabanDataSet1.kitap_kayit' table. You can move, or remove it, as needed.
            this.kitap_kayitTableAdapter1.Fill(this.tabanDataSet1.kitap_kayit);
          
     

            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where demirbas_no Like'" + textBox1.Text + "%'", baglanti);
            
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where kitabin_adi Like'" + textBox3.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where kategori Like'" + textBox5.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where kutuphane_no Like'" + textBox2.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where yazari Like'" + textBox4.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }
    }
}
