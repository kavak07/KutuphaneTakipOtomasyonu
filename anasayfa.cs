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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

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

            string durum = "Teslim Edilmedi";
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from odunckitap where getirecegi_tarih < Now() AND gdurum='" + durum + "'  ", baglanti);

            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void anasayfa_Load(object sender, EventArgs e)
        {
         
            listele();
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;//Forum sitilini None yaptık yani yok ettik.
 
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form yeni = new kitaplistesi();
            yeni.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form yeni = new kitapkayit();
            yeni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form yeni = new kayitduzenle();
            yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form yeni = new arama();
            yeni.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrkayitduzenleme();
            yeni.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form yeni = new ograrama();
            yeni.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrkayit();
            yeni.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form yeni = new kitapver();
            yeni.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form yeni = new kitapal();
            yeni.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form yeni=new getirilmeyenkitaplar();
            yeni.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrencilistesi();
            yeni.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void öĞRENCİDÜZENLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrkayitduzenleme();
            yeni.Show();
        }

        private void kİTAPKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new kitapkayit();
            yeni.Show();

        }

        private void kİTAPDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new kayitduzenle();
            yeni.Show();
        }

        private void kİTAPARAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new arama();
            yeni.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void öĞRENCİKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrkayit();
            yeni.Show();
        }

        private void öĞRENCİARAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new ograrama();
            yeni.Show();
        }

        private void öĞRENCİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new ogrlistesi();
            yeni.Show();
        }

        private void kİTAPVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new kitapver();
            yeni.Show();
        }

        private void kİTAPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new kitapal();
            yeni.Show();
        }

        private void sÜRESİDOLANKİTAPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new getirilmeyenkitaplar();
            yeni.Show();
        }

        private void aLINIPVERİLENKİTAPLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////
        }

        private void kİTAPLİSTESİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon şu anda kullanılamamaktadır.En kısa zamanda düzeltilecektir.");
        }

        private void öĞRENCİLİSTESİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon şu anda kullanılamamaktadır.En kısa zamanda düzeltilecektir.");
        }

        private void gETİRİLMEYENKİTAPLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni = new getirilmeyenkitaplar();
            yeni.Show();
        }

        private void aLINIPVERİLENKİTAPLİSTESİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form yeni = new almaverme();
            yeni.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form yeni = new almaverme();
            yeni.Show();
        }

        private void kİTAPİŞLEMLERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form yeni = new hakkinda1();
            yeni.Show();

        }

        private void öĞRENCİİŞLEMLERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form yeni = new yardim2();
            yeni.Show();
        }

        private void kİTAPALMAVERMEİŞLEMLERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form yeni = new yardim3();
            yeni.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
