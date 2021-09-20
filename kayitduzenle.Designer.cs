namespace kutuphane
{
    partial class kayitduzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitduzenle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitabinadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuphanenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapkayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          
            this.kitapkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
 
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            
            this.label6 = new System.Windows.Forms.Label();
         
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource)).BeginInit();
      
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.demirbasnoDataGridViewTextBoxColumn,
            this.kitabinadiDataGridViewTextBoxColumn,
            this.yazariDataGridViewTextBoxColumn,
            this.sayfasiDataGridViewTextBoxColumn,
            this.kutuphanenoDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.kitapkayitBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // demirbasnoDataGridViewTextBoxColumn
            // 
            this.demirbasnoDataGridViewTextBoxColumn.DataPropertyName = "demirbas_no";
            this.demirbasnoDataGridViewTextBoxColumn.HeaderText = "Demirbaş No";
            this.demirbasnoDataGridViewTextBoxColumn.Name = "demirbasnoDataGridViewTextBoxColumn";
            this.demirbasnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitabinadiDataGridViewTextBoxColumn
            // 
            this.kitabinadiDataGridViewTextBoxColumn.DataPropertyName = "kitabin_adi";
            this.kitabinadiDataGridViewTextBoxColumn.HeaderText = "Kitabın Adı";
            this.kitabinadiDataGridViewTextBoxColumn.Name = "kitabinadiDataGridViewTextBoxColumn";
            this.kitabinadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazariDataGridViewTextBoxColumn
            // 
            this.yazariDataGridViewTextBoxColumn.DataPropertyName = "yazari";
            this.yazariDataGridViewTextBoxColumn.HeaderText = "Yazarı";
            this.yazariDataGridViewTextBoxColumn.Name = "yazariDataGridViewTextBoxColumn";
            this.yazariDataGridViewTextBoxColumn.ReadOnly = true;
            this.yazariDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfasiDataGridViewTextBoxColumn
            // 
            this.sayfasiDataGridViewTextBoxColumn.DataPropertyName = "sayfasi";
            this.sayfasiDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            this.sayfasiDataGridViewTextBoxColumn.Name = "sayfasiDataGridViewTextBoxColumn";
            this.sayfasiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kutuphanenoDataGridViewTextBoxColumn
            // 
            this.kutuphanenoDataGridViewTextBoxColumn.DataPropertyName = "kutuphane_no";
            this.kutuphanenoDataGridViewTextBoxColumn.HeaderText = "Kütüphane No";
            this.kutuphanenoDataGridViewTextBoxColumn.Name = "kutuphanenoDataGridViewTextBoxColumn";
            this.kutuphanenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapkayitBindingSource1
            // 
            this.kitapkayitBindingSource1.DataMember = "kitap_kayit";

            // 
            // tabanDataSet3
            // 
          
            // 
            // kitapkayitBindingSource
            // 
            this.kitapkayitBindingSource.DataMember = "kitap_kayit";
          
            // 
            // tabanDataSet2
            // 
           
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "1393032291_old-view-refresh.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(366, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = " YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1394498477_refresh.png");
            this.ımageList1.Images.SetKeyName(1, "1393032291_old-view-refresh.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demirbaş No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kütüphane No";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(133, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Adı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(133, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yazarı";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(250, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategori";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kitap_kayitTableAdapter2
            // 

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "* DÜZENLEME YAPMAK İSTEDİĞİNİZ KİTAP İÇİN BİLGİLERİN BULUNDUĞU SATIRA ÇİFT TIKLAY" +
                "INIZ.";
            // 
            // kitap_kayitTableAdapter
            // 
           
            // 
            // kayitduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kayitduzenle";
            this.Text = "KAYIT DÜZENLE - KÜTÜPHANE TAKİP PROGRAMI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.kayitduzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource1)).EndInit();
        
            ((System.ComponentModel.ISupportInitialize)(this.kitapkayitBindingSource)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
       
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kitapkayitBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitabinadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuphanenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
   
        private System.Windows.Forms.BindingSource kitapkayitBindingSource1;
     
        private System.Windows.Forms.ImageList ımageList1;
        
    }
}