﻿using System;
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
    public partial class ogrkayitduzenleme : Form
    {
        public ogrkayitduzenleme()
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
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM ogrkayit", baglanti);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ogrkayitduzenleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tabanDataSet1.ogrkayit' table. You can move, or remove it, as needed.
            this.ogrkayitTableAdapter.Fill(this.tabanDataSet1.ogrkayit);
            
            
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from ogrkayit where numarasi Like'" + textBox5.Text + "%'", baglanti);
            adaptor.Fill(ds, "ogrkayit");
            dataGridView1.DataSource = ds.Tables["ogrkayit"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form yeni = new ogrkayitguncelle();
            yeni.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from ogrkayit where ogr_adi_soyadi Like'" + textBox1.Text + "%'", baglanti);
            adaptor.Fill(ds, "ogrkayit");
            dataGridView1.DataSource = ds.Tables["ogrkayit"];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataSet ds = new DataSet();
            ds.Clear();
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * from ogrkayit where sinifi Like'" + textBox3.Text + "%'", baglanti);
            adaptor.Fill(ds, "ogrkayit");
            dataGridView1.DataSource = ds.Tables["ogrkayit"];
        }
    }
}
