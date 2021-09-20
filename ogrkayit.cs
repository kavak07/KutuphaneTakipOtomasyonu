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
    public partial class ogrkayit : Form
    {
        public ogrkayit()
        {
            InitializeComponent();
        }

        private void ogrkayit_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        public OleDbCommand komut = new OleDbCommand();
        public DataSet tablo = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Alanlar boş geçilemez!");
                }
                else
                {

                    OleDbCommand kaydet = new OleDbCommand("insert into ogrkayit (ogr_adi_soyadi,sinifi,numarasi) values('" + textBox1.Text + "','" + textBox2.Text + "' , '" + textBox3.Text + "')", baglan);
                    baglan.Open();
                    kaydet.ExecuteNonQuery();

                    baglan.Close();
                    MessageBox.Show("Kayıt Başarılı.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch
            {
                baglan.Close();
                MessageBox.Show("Öğrenci kayıtlıdır.");
            } 

        }
    }
}
