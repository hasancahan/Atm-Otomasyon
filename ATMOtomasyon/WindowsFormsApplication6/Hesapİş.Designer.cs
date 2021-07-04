namespace WindowsFormsApplication6
{
    partial class Hesapİş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesapİş));
            this.button1 = new System.Windows.Forms.Button();
            this.GeriBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.atm_OtomasyonDataSet = new WindowsFormsApplication6.Atm_OtomasyonDataSet();
            this.atmOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girişEkranıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girişEkranıTableAdapter = new WindowsFormsApplication6.Atm_OtomasyonDataSetTableAdapters.GirişEkranıTableAdapter();
            this.girişKullanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girişKullanıcıTableAdapter = new WindowsFormsApplication6.Atm_OtomasyonDataSetTableAdapters.GirişKullanıcıTableAdapter();
            this.girişKullanıcıBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atm_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişEkranıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişKullanıcıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişKullanıcıBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hasap Bakiye Sorgulama";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeriBut
            // 
            this.GeriBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeriBut.BackgroundImage")));
            this.GeriBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriBut.Location = new System.Drawing.Point(12, 12);
            this.GeriBut.Name = "GeriBut";
            this.GeriBut.Size = new System.Drawing.Size(67, 67);
            this.GeriBut.TabIndex = 14;
            this.GeriBut.UseVisualStyleBackColor = true;
            this.GeriBut.Click += new System.EventHandler(this.GeriBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(406, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 217);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(398, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(445, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(115, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 50);
            this.label9.TabIndex = 3;
            this.label9.Text = "HESABINIZDA TOPLAM\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(374, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(466, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = " TL BULUNMAKTADIR.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(270, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "SAYIN\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tarih Saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(305, 75);
            this.button4.TabIndex = 17;
            this.button4.Text = "Hesaba Kayıtlı Adres\r\n";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(406, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 253);
            this.panel3.TabIndex = 18;
            this.panel3.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(84, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "label12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(17, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adres:";
            // 
            // atm_OtomasyonDataSet
            // 
            this.atm_OtomasyonDataSet.DataSetName = "Atm_OtomasyonDataSet";
            this.atm_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atmOtomasyonDataSetBindingSource
            // 
            this.atmOtomasyonDataSetBindingSource.DataSource = this.atm_OtomasyonDataSet;
            this.atmOtomasyonDataSetBindingSource.Position = 0;
            // 
            // girişEkranıBindingSource
            // 
            this.girişEkranıBindingSource.DataMember = "GirişEkranı";
            this.girişEkranıBindingSource.DataSource = this.atmOtomasyonDataSetBindingSource;
            // 
            // girişEkranıTableAdapter
            // 
            this.girişEkranıTableAdapter.ClearBeforeFill = true;
            // 
            // girişKullanıcıBindingSource
            // 
            this.girişKullanıcıBindingSource.DataMember = "GirişKullanıcı";
            this.girişKullanıcıBindingSource.DataSource = this.atmOtomasyonDataSetBindingSource;
            // 
            // girişKullanıcıTableAdapter
            // 
            this.girişKullanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // girişKullanıcıBindingSource1
            // 
            this.girişKullanıcıBindingSource1.DataMember = "GirişKullanıcı";
            this.girişKullanıcıBindingSource1.DataSource = this.atm_OtomasyonDataSet;
            // 
            // Hesapİş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GeriBut);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hesapİş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fırat Üniversitesi Bankamatik";
            this.Load += new System.EventHandler(this.Hesapİş_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atm_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişEkranıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişKullanıcıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girişKullanıcıBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GeriBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource atmOtomasyonDataSetBindingSource;
        private Atm_OtomasyonDataSet atm_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource girişEkranıBindingSource;
        private Atm_OtomasyonDataSetTableAdapters.GirişEkranıTableAdapter girişEkranıTableAdapter;
        private System.Windows.Forms.BindingSource girişKullanıcıBindingSource;
        private Atm_OtomasyonDataSetTableAdapters.GirişKullanıcıTableAdapter girişKullanıcıTableAdapter;
        private System.Windows.Forms.BindingSource girişKullanıcıBindingSource1;
        private System.Windows.Forms.Label label12;

    }
}