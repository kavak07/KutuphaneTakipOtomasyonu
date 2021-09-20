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
    public partial class kitapver2 : Form
    {
        public kitapver2()
        {
            InitializeComponent();
        }

        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public DataSet tablo = new DataSet();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapver2_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(15);
            //Datagridden textbox'a aktarım.
            kitapver frm1 = (kitapver)Application.OpenForms["kitapver"];
            textBox1.Text = frm1.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = frm1.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = frm1.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = frm1.dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = frm1.dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = frm1.dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            //Datagridden textbox'a aktarım.
            
        }

        public static string durum;
        

        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gdurum = "Teslim Edilmedi";
      
            kitapver yeni = (kitapver)Application.OpenForms["kitapver"];
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            int gelenid, durum = 1;
            gelenid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[0].Value);
            int ogrid = Convert.ToInt32(yeni.dataGridView2.SelectedRows[0].Cells[0].Value); ;
            OleDbCommand kaydet = new OleDbCommand("insert into odunckitap (kitap_id,ogr_id,demirbas_no,kitabin_adi,yazari,adi_soyadi,sinifi,numarasi,aldigi_tarih,getirecegi_tarih,gdurum) values('"+ gelenid +"','"+ ogrid +"','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox4.Text + "' ,'" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + gdurum + "')", baglanti);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
          
            //kitapdurumguncellemekodu
            
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            
            OleDbCommand guncelle = new OleDbCommand("update kitap_kayit set durum  = '" + durum + "' where id=" + gelenid +  "", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
           
            //öğrencidurumguncellemekodu
          
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        
            OleDbCommand guncelle1 = new OleDbCommand("update ogrkayit set durum  = '" + durum + "' where id=" + ogrid + "", baglanti);
            guncelle1.ExecuteNonQuery();
            baglanti.Close();
            yeni.listele();
            yeni.listele2();
            
            this.Close();
            MessageBox.Show("Kitap Verilmiştir.");

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
