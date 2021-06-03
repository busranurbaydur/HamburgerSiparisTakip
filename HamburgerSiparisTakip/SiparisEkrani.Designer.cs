
namespace HamburgerSiparisTakip
{
    partial class SiparisEkrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btmSiparisTamamla = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Controls.Add(this.rbOrta);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Location = new System.Drawing.Point(14, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(222, 49);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçin";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(116, 21);
            this.rbBuyuk.Margin = new System.Windows.Forms.Padding(2);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 6;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(65, 21);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 5;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(4, 21);
            this.rbKucuk.Margin = new System.Windows.Forms.Padding(2);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 4;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // flpExtraMalzemeler
            // 
            this.flpExtraMalzemeler.Location = new System.Drawing.Point(14, 242);
            this.flpExtraMalzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
            this.flpExtraMalzemeler.Size = new System.Drawing.Size(222, 89);
            this.flpExtraMalzemeler.TabIndex = 36;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(50, 341);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(2);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(185, 20);
            this.nmrAdet.TabIndex = 35;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btmSiparisTamamla
            // 
            this.btmSiparisTamamla.Location = new System.Drawing.Point(552, 358);
            this.btmSiparisTamamla.Margin = new System.Windows.Forms.Padding(2);
            this.btmSiparisTamamla.Name = "btmSiparisTamamla";
            this.btmSiparisTamamla.Size = new System.Drawing.Size(161, 23);
            this.btmSiparisTamamla.TabIndex = 34;
            this.btmSiparisTamamla.Text = "Siparişi Tamamla";
            this.btmSiparisTamamla.UseVisualStyleBackColor = true;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(339, 363);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(29, 13);
            this.lblToplamTutar.TabIndex = 30;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Extra Malzemeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Adet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Toplam Tutar :";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(246, 11);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(2);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(286, 316);
            this.lstSiparisler.TabIndex = 29;
            this.lstSiparisler.SelectedIndexChanged += new System.EventHandler(this.lstSiparisler_SelectedIndexChanged);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(11, 363);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(225, 24);
            this.btnSiparisEkle.TabIndex = 28;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(11, 137);
            this.cbMenuler.Margin = new System.Windows.Forms.Padding(2);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(226, 21);
            this.cbMenuler.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Menü Seçin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HamburgerSiparisTakip.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpExtraMalzemeler);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.btmSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisEkrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SiparisEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btmSiparisTamamla;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

