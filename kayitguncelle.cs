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
    public partial class kayitguncelle : Form
    {
        public kayitguncelle()
        {
            InitializeComponent();
        }
        public kayitduzenle frm1 = (kayitduzenle)Application.OpenForms["kayitduzenle"];
        private void kayitguncelle_Load(object sender, EventArgs e)
        {
            //Datagridden textbox'a aktarım.
         
            textBox1.Text = frm1.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = frm1.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = frm1.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = frm1.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = frm1.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = frm1.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //Datagridden textbox'a aktarım.
        }
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath.ToString() + "\\taban.accdb");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if (MessageBox.Show("Kitap kaydını silmek istiyormusunuz ?", "KAYIT SİLİNECEK", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
             
                baglanti.Open();
                OleDbCommand kom = new OleDbCommand("DELETE FROM kitap_kayit WHERE demirbas_no='"+textBox1.Text+"'", baglanti);
                kom.ExecuteNonQuery();
               
                baglanti.Close();
                frm1.listele();
                this.Close();
                
                MessageBox.Show("Kayıt Silinmiştir.");

            }
            else
            {
                MessageBox.Show("İptal edildi");
            }
        }
        public static int gelenid;
        private void button2_Click(object sender, EventArgs e)
        {
            //Veri update.
                kayitduzenle yeni = (kayitduzenle)Application.OpenForms["kayitduzenle"];

                gelenid = Convert.ToInt32(yeni.dataGridView1.SelectedRows[0].Cells[0].Value);
                baglanti.Open();
                OleDbCommand guncelle1 = new OleDbCommand("update kitap_kayit set demirbas_no  = '" + textBox1.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle2 = new OleDbCommand("update kitap_kayit set kitabin_adi  = '" + textBox2.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle3 = new OleDbCommand("update kitap_kayit set yazari  = '" + textBox3.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle4 = new OleDbCommand("update kitap_kayit set sayfasi  = '" + textBox4.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle5 = new OleDbCommand("update kitap_kayit set kutuphane_no  = '" + textBox5.Text + "' where id=" + gelenid + "", baglanti);
                OleDbCommand guncelle6 = new OleDbCommand("update kitap_kayit set kategori  = '" + textBox6.Text + "' where id=" + gelenid + "", baglanti);
                guncelle1.ExecuteNonQuery();
                guncelle2.ExecuteNonQuery();
                guncelle3.ExecuteNonQuery();
                guncelle4.ExecuteNonQuery();
                guncelle5.ExecuteNonQuery();
                guncelle6.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncelleştirilmiştir");
                baglanti.Close();
                yeni.listele();
            //Veri Update
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
