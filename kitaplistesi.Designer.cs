namespace kutuphane
{
    partial class kitaplistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitaplistesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabanDataSet1 = new kutuphane.tabanDataSet1();
            this.kitapkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitap_kayitTableAdapter = new kutuphane.tabanDataSet1TableAdapters.kitap_kayitTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuphanenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitabinadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource)).BeginInit();
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
            this.idDataGridViewTextBoxColumn,
            this.demirbasnoDataGridViewTextBoxColumn,
            this.kutuphanenoDataGridViewTextBoxColumn,
            this.kitabinadiDataGridViewTextBoxColumn,
            this.yazariDataGridViewTextBoxColumn,
            this.sayfasiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapkayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabanDataSet1
            // 
            this.tabanDataSet1.DataSetName = "tabanDataSet1";
            this.tabanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapkayitBindingSource
            // 
            this.kitapkayitBindingSource.DataMember = "kitap_kayit";
            this.kitapkayitBindingSource.DataSource = this.tabanDataSet1;
            // 
            // kitap_kayitTableAdapter
            // 
            this.kitap_kayitTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demirbasnoDataGridViewTextBoxColumn
            // 
            this.demirbasnoDataGridViewTextBoxColumn.DataPropertyName = "demirbas_no";
            this.demirbasnoDataGridViewTextBoxColumn.HeaderText = "DEMİRBAŞ NO";
            this.demirbasnoDataGridViewTextBoxColumn.Name = "demirbasnoDataGridViewTextBoxColumn";
            this.demirbasnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kutuphanenoDataGridViewTextBoxColumn
            // 
            this.kutuphanenoDataGridViewTextBoxColumn.DataPropertyName = "kutuphane_no";
            this.kutuphanenoDataGridViewTextBoxColumn.HeaderText = "KÜTÜPHANE NO";
            this.kutuphanenoDataGridViewTextBoxColumn.Name = "kutuphanenoDataGridViewTextBoxColumn";
            this.kutuphanenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kutuphanenoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitabinadiDataGridViewTextBoxColumn
            // 
            this.kitabinadiDataGridViewTextBoxColumn.DataPropertyName = "kitabin_adi";
            this.kitabinadiDataGridViewTextBoxColumn.HeaderText = "KİTAP ADI";
            this.kitabinadiDataGridViewTextBoxColumn.Name = "kitabinadiDataGridViewTextBoxColumn";
            this.kitabinadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazariDataGridViewTextBoxColumn
            // 
            this.yazariDataGridViewTextBoxColumn.DataPropertyName = "yazari";
            this.yazariDataGridViewTextBoxColumn.HeaderText = "YAZARI";
            this.yazariDataGridViewTextBoxColumn.Name = "yazariDataGridViewTextBoxColumn";
            this.yazariDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sayfasiDataGridViewTextBoxColumn
            // 
            this.sayfasiDataGridViewTextBoxColumn.DataPropertyName = "sayfasi";
            this.sayfasiDataGridViewTextBoxColumn.HeaderText = "SAYFASI";
            this.sayfasiDataGridViewTextBoxColumn.Name = "sayfasiDataGridViewTextBoxColumn";
            this.sayfasiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "KATEGORİ";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "1390151012_Excel_15.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(396, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "EXCELE AKTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1390151012_Excel_15.png");
            this.ımageList1.Images.SetKeyName(1, "1393032291_old-view-refresh.png");
            // 
            // kitaplistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitaplistesi";
            this.Text = "KİTAP LİSTESİ - KÜTÜHANE TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.kitaplistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tabanDataSet1 tabanDataSet1;
        private System.Windows.Forms.BindingSource kitapkayitBindingSource;
        private tabanDataSet1TableAdapters.kitap_kayitTableAdapter kitap_kayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuphanenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitabinadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;

    }
}