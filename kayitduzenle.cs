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
    public partial class kayitduzenle : Form
    {
        public kayitduzenle()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            kayitguncelle ktpteslim = new kayitguncelle();

            ktpteslim.ShowDialog();

            


        }

        private void kayitduzenle_Load(object sender, EventArgs e)
        {
           
            listele();

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

       public void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM kitap_kayit", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
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

       

     

  

        private void button3_Click(object sender, EventArgs e)
        {
            //EXCELE AKTARIM GERÇEKLEŞTİRME
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //TIKLANINCA SATIRI SEÇME KODU
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
          //Dataset arama sorunu !! 
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
