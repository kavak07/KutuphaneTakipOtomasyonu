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
    public partial class kitapalsekme2 : Form
    {
        public kitapalsekme2()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grup1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void kitapalsekme2_Load(object sender, EventArgs e)
        {
    
   
                kitapal frm1 = (kitapal)Application.OpenForms["kitapal"];
                textBox1.Text = frm1.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox2.Text = frm1.dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBox3.Text = frm1.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox4.Text = frm1.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox5.Text = frm1.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox6.Text = frm1.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            kitapal yeni = (kitapal)Application.OpenForms["kitapal"];
            int gelenid,kid,ogrid;
            gelenid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[0].Value);
            kid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[1].Value);
            ogrid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[2].Value);
            string gdurum = "Teslim Edildi";
            if (textBox7.Text == "")
            {
                MessageBox.Show("GÖRÜŞLER BÖLÜMÜ BOŞ GEÇİLEMEZ !");
            }
            else
            {
                
                
                OleDbCommand guncelle1 = new OleDbCommand("update odunckitap set getirdigi_tarih  = '" + dateTimePicker1.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle2 = new OleDbCommand("update odunckitap set gorusler  = '" + textBox7.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle3 = new OleDbCommand("update odunckitap set gdurum  = '" + gdurum + "' where id=" + gelenid + "", baglanti);
                baglanti.Open();
                guncelle1.ExecuteNonQuery();
                guncelle2.ExecuteNonQuery();
                guncelle3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Teslim Edilmiştir");

               
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                int kdurum = 0;
                OleDbCommand guncelle = new OleDbCommand("update kitap_kayit set durum  = '" + kdurum + "' where id=" + kid + "", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                //öğrencidurumguncellemekodu

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
               
                OleDbCommand guncelleogr = new OleDbCommand("update ogrkayit set durum  = '" + kdurum + "' where id=" + ogrid + "", baglanti);
                guncelleogr.ExecuteNonQuery();
                baglanti.Close();
                yeni.listele();

                this.Close();
                MessageBox.Show("Kitap Verilmiştir.");
            }
           
        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
