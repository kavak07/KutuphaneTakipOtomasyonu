namespace kutuphane
{
    partial class almaverme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            
            this.odunckitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
         
            this.demirbasnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitabinadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aldigitarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getirecegitarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getirdigitarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goruslerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.odunckitapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demirbasnoDataGridViewTextBoxColumn,
            this.kitabinadiDataGridViewTextBoxColumn,
            this.yazariDataGridViewTextBoxColumn,
            this.adisoyadiDataGridViewTextBoxColumn,
            this.sinifiDataGridViewTextBoxColumn,
            this.numarasiDataGridViewTextBoxColumn,
            this.aldigitarihDataGridViewTextBoxColumn,
            this.getirecegitarihDataGridViewTextBoxColumn,
            this.gdurumDataGridViewTextBoxColumn,
            this.getirdigitarihDataGridViewTextBoxColumn,
            this.goruslerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odunckitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabanDataSet5
            // 
           
            // 
            // odunckitapBindingSource
            // 
            this.odunckitapBindingSource.DataMember = "odunckitap";
         
            // 
            // odunckitapTableAdapter
            // 
            
            // 
            // demirbasnoDataGridViewTextBoxColumn
            // 
            this.demirbasnoDataGridViewTextBoxColumn.DataPropertyName = "demirbas_no";
            this.demirbasnoDataGridViewTextBoxColumn.HeaderText = "DEMİRBAŞ NO";
            this.demirbasnoDataGridViewTextBoxColumn.Name = "demirbasnoDataGridViewTextBoxColumn";
            this.demirbasnoDataGridViewTextBoxColumn.Width = 130;
            // 
            // kitabinadiDataGridViewTextBoxColumn
            // 
            this.kitabinadiDataGridViewTextBoxColumn.DataPropertyName = "kitabin_adi";
            this.kitabinadiDataGridViewTextBoxColumn.HeaderText = "KİTAP ADI";
            this.kitabinadiDataGridViewTextBoxColumn.Name = "kitabinadiDataGridViewTextBoxColumn";
            // 
            // yazariDataGridViewTextBoxColumn
            // 
            this.yazariDataGridViewTextBoxColumn.DataPropertyName = "yazari";
            this.yazariDataGridViewTextBoxColumn.HeaderText = "YAZARI";
            this.yazariDataGridViewTextBoxColumn.Name = "yazariDataGridViewTextBoxColumn";
            // 
            // adisoyadiDataGridViewTextBoxColumn
            // 
            this.adisoyadiDataGridViewTextBoxColumn.DataPropertyName = "adi_soyadi";
            this.adisoyadiDataGridViewTextBoxColumn.HeaderText = "ADI SOYADI";
            this.adisoyadiDataGridViewTextBoxColumn.Name = "adisoyadiDataGridViewTextBoxColumn";
            // 
            // sinifiDataGridViewTextBoxColumn
            // 
            this.sinifiDataGridViewTextBoxColumn.DataPropertyName = "sinifi";
            this.sinifiDataGridViewTextBoxColumn.HeaderText = "SINIFI";
            this.sinifiDataGridViewTextBoxColumn.Name = "sinifiDataGridViewTextBoxColumn";
            // 
            // numarasiDataGridViewTextBoxColumn
            // 
            this.numarasiDataGridViewTextBoxColumn.DataPropertyName = "numarasi";
            this.numarasiDataGridViewTextBoxColumn.HeaderText = "NUMARASI";
            this.numarasiDataGridViewTextBoxColumn.Name = "numarasiDataGridViewTextBoxColumn";
            // 
            // aldigitarihDataGridViewTextBoxColumn
            // 
            this.aldigitarihDataGridViewTextBoxColumn.DataPropertyName = "aldigi_tarih";
            this.aldigitarihDataGridViewTextBoxColumn.HeaderText = "ALDIĞI TARİH";
            this.aldigitarihDataGridViewTextBoxColumn.Name = "aldigitarihDataGridViewTextBoxColumn";
            // 
            // getirecegitarihDataGridViewTextBoxColumn
            // 
            this.getirecegitarihDataGridViewTextBoxColumn.DataPropertyName = "getirecegi_tarih";
            this.getirecegitarihDataGridViewTextBoxColumn.HeaderText = "GETİRECEĞİ TARİH";
            this.getirecegitarihDataGridViewTextBoxColumn.Name = "getirecegitarihDataGridViewTextBoxColumn";
            // 
            // gdurumDataGridViewTextBoxColumn
            // 
            this.gdurumDataGridViewTextBoxColumn.DataPropertyName = "gdurum";
            this.gdurumDataGridViewTextBoxColumn.HeaderText = "DURUM";
            this.gdurumDataGridViewTextBoxColumn.Name = "gdurumDataGridViewTextBoxColumn";
            // 
            // getirdigitarihDataGridViewTextBoxColumn
            // 
            this.getirdigitarihDataGridViewTextBoxColumn.DataPropertyName = "getirdigi_tarih";
            this.getirdigitarihDataGridViewTextBoxColumn.HeaderText = "GETİRDİĞİ TARİH";
            this.getirdigitarihDataGridViewTextBoxColumn.Name = "getirdigitarihDataGridViewTextBoxColumn";
            // 
            // goruslerDataGridViewTextBoxColumn
            // 
            this.goruslerDataGridViewTextBoxColumn.DataPropertyName = "gorusler";
            this.goruslerDataGridViewTextBoxColumn.HeaderText = "GÖRÜŞLER";
            this.goruslerDataGridViewTextBoxColumn.Name = "goruslerDataGridViewTextBoxColumn";
            // 
            // almaverme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "almaverme";
            this.Text = "LİSTE - KÜTÜPHANE TAKİP PROGRAMI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.almaverme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.odunckitapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource odunckitapBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitabinadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aldigitarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getirecegitarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getirdigitarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goruslerDataGridViewTextBoxColumn;
    }
}