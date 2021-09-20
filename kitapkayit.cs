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
    public partial class kitapkayit : Form
    {
        public kitapkayit()
        {
            InitializeComponent();
        }
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public DataSet tablo = new DataSet();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kitapkayit_Load(object sender, EventArgs e)
        {
           


           
     

        }
        public int gelen_id;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int durum = 0;
            
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox5.Text == ""))
                {
                    MessageBox.Show("Demirbaş No , Kütüphane No , Kitap Adı alanları boş bırakılamaz.");
                }
                else
                {
                    OleDbCommand kaydet = new OleDbCommand("insert into kitap_kayit (demirbas_no,kutuphane_no,kitabin_adi,yazari,sayfasi,kategori,durum) values('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text + "' , '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox6.Text + "','"+durum+"' )", baglan);
                    baglan.Open();
                    kaydet.ExecuteNonQuery();

                    baglan.Close();
                    MessageBox.Show("Kayıt Başarılı.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear(); 
                }
            }
            catch
            {
                baglan.Close();
                MessageBox.Show("Kitap kayıtlıdır.");
            }

          

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
