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
    public partial class ogrkayitguncelle : Form
    {
        public ogrkayitguncelle()
        {
            InitializeComponent();
        }

        private void ogrkayitguncelle_Load(object sender, EventArgs e)
        {
            //Datagridden textbox'a aktarım.
            ogrkayitduzenleme frm1 = (ogrkayitduzenleme)Application.OpenForms["ogrkayitduzenleme"];
            textBox1.Text = frm1.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = frm1.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = frm1.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            //Veri update.
            ogrkayitduzenleme yeni = (ogrkayitduzenleme)Application.OpenForms["ogrkayitduzenleme"];
            int gelenid;
            gelenid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[0].Value);
            baglanti.Open();
            OleDbCommand guncelle1 = new OleDbCommand("update ogrkayit set ogr_adi_soyadi  = '" + textBox1.Text + "' where id=" + gelenid + "", baglanti);
            OleDbCommand guncelle2 = new OleDbCommand("update ogrkayit set sinifi  = '" + textBox2.Text + "' where id=" + gelenid + "", baglanti);
            OleDbCommand guncelle3 = new OleDbCommand("update ogrkayit set numarasi  = '" + textBox3.Text + "' where id=" + gelenid + "", baglanti);
     
            guncelle1.ExecuteNonQuery();
            guncelle2.ExecuteNonQuery();
            guncelle3.ExecuteNonQuery();
           
            MessageBox.Show("Kaydınız Güncelleştirilmiştir");
            baglanti.Close();
            //Veri Update
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kitap kaydını silmek istiyormusunuz ?", "KAYIT SİLİNECEK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {


                baglanti.Open();
                OleDbCommand kom = new OleDbCommand("DELETE FROM ogrkayit WHERE numarasi='" + textBox3.Text + "'", baglanti);
                kom.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kayıt Silinmiştir.");
            }
            else
            {
                MessageBox.Show("İptal edildi");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
