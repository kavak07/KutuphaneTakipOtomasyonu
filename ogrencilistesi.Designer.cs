namespace kutuphane
{
    partial class ogrencilistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencilistesi));
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabanDataSet1 = new kutuphane.tabanDataSet1();
            this.ogrkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrkayitTableAdapter = new kutuphane.tabanDataSet1TableAdapters.ogrkayitTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "1390151012_Excel_15.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(235, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 52);
            this.button2.TabIndex = 21;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ogradisoyadiDataGridViewTextBoxColumn,
            this.sinifiDataGridViewTextBoxColumn,
            this.numarasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrkayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 252);
            this.dataGridView1.TabIndex = 20;
            // 
            // tabanDataSet1
            // 
            this.tabanDataSet1.DataSetName = "tabanDataSet1";
            this.tabanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrkayitBindingSource
            // 
            this.ogrkayitBindingSource.DataMember = "ogrkayit";
            this.ogrkayitBindingSource.DataSource = this.tabanDataSet1;
            // 
            // ogrkayitTableAdapter
            // 
            this.ogrkayitTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradisoyadiDataGridViewTextBoxColumn
            // 
            this.ogradisoyadiDataGridViewTextBoxColumn.DataPropertyName = "ogr_adi_soyadi";
            this.ogradisoyadiDataGridViewTextBoxColumn.HeaderText = "ADI SOYADI";
            this.ogradisoyadiDataGridViewTextBoxColumn.Name = "ogradisoyadiDataGridViewTextBoxColumn";
            this.ogradisoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinifiDataGridViewTextBoxColumn
            // 
            this.sinifiDataGridViewTextBoxColumn.DataPropertyName = "sinifi";
            this.sinifiDataGridViewTextBoxColumn.HeaderText = "SINIFI";
            this.sinifiDataGridViewTextBoxColumn.Name = "sinifiDataGridViewTextBoxColumn";
            this.sinifiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarasiDataGridViewTextBoxColumn
            // 
            this.numarasiDataGridViewTextBoxColumn.DataPropertyName = "numarasi";
            this.numarasiDataGridViewTextBoxColumn.HeaderText = "NUMARASI";
            this.numarasiDataGridViewTextBoxColumn.Name = "numarasiDataGridViewTextBoxColumn";
            this.numarasiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrencilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrencilistesi";
            this.Text = "ÖĞRENCİ LİSTESİ - KÜTÜPHANE TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.ogrencilistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tabanDataSet1 tabanDataSet1;
        private System.Windows.Forms.BindingSource ogrkayitBindingSource;
        private tabanDataSet1TableAdapters.ogrkayitTableAdapter ogrkayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarasiDataGridViewTextBoxColumn;
    }
}