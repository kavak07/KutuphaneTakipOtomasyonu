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
    public partial class kitapver : Form
    {
        public kitapver()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
   
        private void kitapver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabanDataSet1.ogrkayit' table. You can move, or remove it, as needed.
            this.ogrkayitTableAdapter.Fill(this.tabanDataSet1.ogrkayit);
          
            
            listele();
            listele2();
          

           
         
          
        }
     public void baglan()
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
            int durum = 0;
            baglan();
            DataTable dt = new DataTable();
           
            OleDbDataAdapter bilgi = new OleDbDataAdapter("SELECT * FROM kitap_kayit WHERE durum='"+durum+"'  ", baglanti);
            
            bilgi.Fill(dt);
             
            dataGridView1.DataSource = dt;
      
        }
        public void listele2()
        {
            baglan();
            
            DataTable dt2 = new DataTable();
           
            OleDbDataAdapter bilgi2 = new OleDbDataAdapter("SELECT * FROM ogrkayit", baglanti);
          
            bilgi2.Fill(dt2);
         
            dataGridView2.DataSource = dt2;
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form ktpteslim = new kitapver2();

            ktpteslim.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
       public static int kitapdurum=1;
          
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if ((textBox2.Text == "") && (textBox1.Text == ""))
            {

                MessageBox.Show("Kitap Seçiniz.");  

                
            }
            else if ((textBox3.Text == "") && (textBox4.Text == ""))
            {

                MessageBox.Show("Öğrenci Seçiniz.");

            }
            else if ((textBox6.Text == "1")&&(textBox5.Text == "1"))
            {
                MessageBox.Show("Önce öğrencinin kitabı vermesini sağlayın.");
                MessageBox.Show("Seçilen kitap şu anda bulunmamaktadır.");
            }
            else  if (textBox5.Text =="1") 
            {
                
                   
              
                  MessageBox.Show("Seçilen kitap şu anda bulunmamaktadır.");
                }
                    else if (textBox6.Text == "1")
                    {
                        MessageBox.Show("Önce öğrencinin kitabı vermesini sağlayın.");
                    }
                    else
                    {
                        Form yeni = new kitapver2();
                        yeni.Show();
                    }


            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dataGridView2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView2_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {
                listele2();
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {
                listele();
            }
        }

        private void dataGridView2_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void YENİLE_Click(object sender, EventArgs e)
        {
            listele();
            listele2();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from ogrkayit where ogr_adi_soyadi Like'" + textBox3.Text + "%'", baglanti);
            adaptor.Fill(ds, "ogrkayit");
            dataGridView2.DataSource = ds.Tables["ogrkayit"];

            baglan();
            DataSet ds2 = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("Select * from ogrkayit where numarasi Like'" + textBox4.Text + "%'", baglanti);
            adaptor.Fill(ds, "ogrkayit");
            dataGridView2.DataSource = ds.Tables["ogrkayit"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from kitap_kayit where demirbas_no Like'" + textBox1.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
           
            baglan();
            DataSet ds2 = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor2 = new OleDbDataAdapter("Select * from kitap_kayit where kitabin_adi Like'" + textBox2.Text + "%'", baglanti);
            adaptor.Fill(ds, "kitap_kayit");
            dataGridView1.DataSource = ds.Tables["kitap_kayit"];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
