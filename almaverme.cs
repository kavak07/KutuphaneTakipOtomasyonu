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
    public partial class almaverme : Form
    {
        public almaverme()
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
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from odunckitap    ", baglanti);

            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void almaverme_Load(object sender, EventArgs e)
        {
            listele();
           

        }
    }
}
