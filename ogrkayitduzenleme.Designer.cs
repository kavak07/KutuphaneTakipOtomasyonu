namespace kutuphane
{
    partial class ogrkayitduzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrkayitduzenleme));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrkayitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrkayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabanDataSet1 = new kutuphane.tabanDataSet1();
            this.ogrkayitBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrkayitTableAdapter = new kutuphane.tabanDataSet1TableAdapters.ogrkayitTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(537, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "* DÜZENLEME YAPMAK İSTEDİĞİNİZ ÖĞRENCİ İÇİN BİLGİLERİN BULUNDUĞU SATIRA ÇİFT TIKL" +
                "AYINIZ.";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(246, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 41;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(243, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Numarası";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(126, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sınıfı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Adı Soyadı";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "1393032291_old-view-refresh.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(359, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "KAYITLARI YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1393032291_old-view-refresh.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.numarasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrkayitBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 242);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ogrkayitBindingSource2
            // 
            this.ogrkayitBindingSource2.DataMember = "ogrkayit";
            // 
            // ogrkayitBindingSource
            // 
            this.ogrkayitBindingSource.DataMember = "ogrkayit";
            // 
            // ogrkayitBindingSource1
            // 
            this.ogrkayitBindingSource1.DataMember = "ogrkayit";
            // 
            // tabanDataSet1
            // 
            this.tabanDataSet1.DataSetName = "tabanDataSet1";
            this.tabanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrkayitBindingSource3
            // 
            this.ogrkayitBindingSource3.DataMember = "ogrkayit";
            this.ogrkayitBindingSource3.DataSource = this.tabanDataSet1;
            // 
            // ogrkayitTableAdapter
            // 
            this.ogrkayitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ogr_adi_soyadi";
            this.dataGridViewTextBoxColumn2.HeaderText = "ADI SOYADI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sinifi";
            this.dataGridViewTextBoxColumn3.HeaderText = "SINIFI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // numarasiDataGridViewTextBoxColumn
            // 
            this.numarasiDataGridViewTextBoxColumn.DataPropertyName = "numarasi";
            this.numarasiDataGridViewTextBoxColumn.HeaderText = "NUMARASI";
            this.numarasiDataGridViewTextBoxColumn.Name = "numarasiDataGridViewTextBoxColumn";
            this.numarasiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrkayitduzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ogrkayitduzenleme";
            this.Text = "ÖĞRENCİ KAYIT DÜZENLEME - KÜTÜPHANE TAKİP PROGRAMI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ogrkayitduzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrkayitBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        
        private System.Windows.Forms.BindingSource ogrkayitBindingSource;

        public System.Windows.Forms.DataGridView dataGridView1;
  
    
        private System.Windows.Forms.BindingSource ogrkayitBindingSource1;
  
        
        private System.Windows.Forms.BindingSource ogrkayitBindingSource2;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private tabanDataSet1 tabanDataSet1;
        private System.Windows.Forms.BindingSource ogrkayitBindingSource3;
        private tabanDataSet1TableAdapters.ogrkayitTableAdapter ogrkayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarasiDataGridViewTextBoxColumn;
    }
}