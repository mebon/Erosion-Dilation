namespace ErosionDilation
{
    partial class ErosionveDilation
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResimYukle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDeger = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonBitmap = new System.Windows.Forms.RadioButton();
            this.radioButtonGrayScale = new System.Windows.Forms.RadioButton();
            this.radioButtonRGB = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSetPikselEksi = new System.Windows.Forms.Button();
            this.buttonSetPikselArti = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonDilation = new System.Windows.Forms.Button();
            this.buttonErosion = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonTersSimetri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeger)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonResimYukle);
            this.panel2.Location = new System.Drawing.Point(19, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 77);
            this.panel2.TabIndex = 1;
            // 
            // buttonResimYukle
            // 
            this.buttonResimYukle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonResimYukle.Location = new System.Drawing.Point(54, 22);
            this.buttonResimYukle.Name = "buttonResimYukle";
            this.buttonResimYukle.Size = new System.Drawing.Size(190, 30);
            this.buttonResimYukle.TabIndex = 2;
            this.buttonResimYukle.Text = "Resim Yükle";
            this.buttonResimYukle.UseVisualStyleBackColor = true;
            this.buttonResimYukle.Click += new System.EventHandler(this.buttonResimYukle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.numericUpDownDeger);
            this.panel3.Location = new System.Drawing.Point(325, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 41);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Değer/Threshold : ";
            // 
            // numericUpDownDeger
            // 
            this.numericUpDownDeger.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numericUpDownDeger.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownDeger.Location = new System.Drawing.Point(176, 9);
            this.numericUpDownDeger.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDeger.Name = "numericUpDownDeger";
            this.numericUpDownDeger.Size = new System.Drawing.Size(53, 21);
            this.numericUpDownDeger.TabIndex = 0;
            this.numericUpDownDeger.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.radioButtonBitmap);
            this.panel4.Controls.Add(this.radioButtonGrayScale);
            this.panel4.Controls.Add(this.radioButtonRGB);
            this.panel4.Location = new System.Drawing.Point(325, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 41);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(198, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bitmap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(119, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "GrayScale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "RGB";
            // 
            // radioButtonBitmap
            // 
            this.radioButtonBitmap.AutoSize = true;
            this.radioButtonBitmap.Location = new System.Drawing.Point(215, 22);
            this.radioButtonBitmap.Name = "radioButtonBitmap";
            this.radioButtonBitmap.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBitmap.TabIndex = 2;
            this.radioButtonBitmap.TabStop = true;
            this.radioButtonBitmap.UseVisualStyleBackColor = true;
            this.radioButtonBitmap.CheckedChanged += new System.EventHandler(this.radioButtonBitmap_CheckedChanged);
            // 
            // radioButtonGrayScale
            // 
            this.radioButtonGrayScale.AutoSize = true;
            this.radioButtonGrayScale.Location = new System.Drawing.Point(142, 22);
            this.radioButtonGrayScale.Name = "radioButtonGrayScale";
            this.radioButtonGrayScale.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGrayScale.TabIndex = 1;
            this.radioButtonGrayScale.TabStop = true;
            this.radioButtonGrayScale.UseVisualStyleBackColor = true;
            this.radioButtonGrayScale.CheckedChanged += new System.EventHandler(this.radioButtonGrayScale_CheckedChanged);
            // 
            // radioButtonRGB
            // 
            this.radioButtonRGB.AutoSize = true;
            this.radioButtonRGB.Location = new System.Drawing.Point(66, 22);
            this.radioButtonRGB.Name = "radioButtonRGB";
            this.radioButtonRGB.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRGB.TabIndex = 0;
            this.radioButtonRGB.TabStop = true;
            this.radioButtonRGB.UseVisualStyleBackColor = true;
            this.radioButtonRGB.CheckedChanged += new System.EventHandler(this.radioButtonRGB_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.buttonSetPikselEksi);
            this.panel5.Controls.Add(this.buttonSetPikselArti);
            this.panel5.Location = new System.Drawing.Point(325, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 77);
            this.panel5.TabIndex = 3;
            // 
            // buttonSetPikselEksi
            // 
            this.buttonSetPikselEksi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSetPikselEksi.Location = new System.Drawing.Point(157, 24);
            this.buttonSetPikselEksi.Name = "buttonSetPikselEksi";
            this.buttonSetPikselEksi.Size = new System.Drawing.Size(115, 30);
            this.buttonSetPikselEksi.TabIndex = 3;
            this.buttonSetPikselEksi.Text = "Set Piksel -";
            this.buttonSetPikselEksi.UseVisualStyleBackColor = true;
            this.buttonSetPikselEksi.Click += new System.EventHandler(this.buttonSetPikselEksi_Click);
            // 
            // buttonSetPikselArti
            // 
            this.buttonSetPikselArti.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSetPikselArti.Location = new System.Drawing.Point(25, 24);
            this.buttonSetPikselArti.Name = "buttonSetPikselArti";
            this.buttonSetPikselArti.Size = new System.Drawing.Size(115, 30);
            this.buttonSetPikselArti.TabIndex = 2;
            this.buttonSetPikselArti.Text = "Set Piksel +";
            this.buttonSetPikselArti.UseVisualStyleBackColor = true;
            this.buttonSetPikselArti.Click += new System.EventHandler(this.buttonSetPikselArti_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.buttonDilation);
            this.panel6.Controls.Add(this.buttonErosion);
            this.panel6.Location = new System.Drawing.Point(325, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 77);
            this.panel6.TabIndex = 3;
            // 
            // buttonDilation
            // 
            this.buttonDilation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDilation.Location = new System.Drawing.Point(157, 19);
            this.buttonDilation.Name = "buttonDilation";
            this.buttonDilation.Size = new System.Drawing.Size(115, 30);
            this.buttonDilation.TabIndex = 5;
            this.buttonDilation.Text = "Dilation";
            this.buttonDilation.UseVisualStyleBackColor = true;
            this.buttonDilation.Click += new System.EventHandler(this.buttonDilation_Click);
            // 
            // buttonErosion
            // 
            this.buttonErosion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonErosion.Location = new System.Drawing.Point(25, 19);
            this.buttonErosion.Name = "buttonErosion";
            this.buttonErosion.Size = new System.Drawing.Size(115, 30);
            this.buttonErosion.TabIndex = 4;
            this.buttonErosion.Text = "Erosion";
            this.buttonErosion.UseVisualStyleBackColor = true;
            this.buttonErosion.Click += new System.EventHandler(this.buttonErosion_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(325, 350);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 51);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad ve Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Okul Numarası : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "201513171070";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muhammed Emin Berkay KOCAOĞLU";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Location = new System.Drawing.Point(12, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(644, 420);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.buttonTersSimetri);
            this.panel9.Location = new System.Drawing.Point(325, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 66);
            this.panel9.TabIndex = 5;
            // 
            // buttonTersSimetri
            // 
            this.buttonTersSimetri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTersSimetri.Location = new System.Drawing.Point(59, 19);
            this.buttonTersSimetri.Name = "buttonTersSimetri";
            this.buttonTersSimetri.Size = new System.Drawing.Size(184, 30);
            this.buttonTersSimetri.TabIndex = 3;
            this.buttonTersSimetri.Text = "Ters Simetri";
            this.buttonTersSimetri.UseVisualStyleBackColor = true;
            this.buttonTersSimetri.Click += new System.EventHandler(this.buttonTersSimetri_Click);
            // 
            // ErosionveDilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(668, 444);
            this.Controls.Add(this.panel8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErosionveDilation";
            this.ShowIcon = false;
            this.Text = "Erosion ve Dilation";
            this.Load += new System.EventHandler(this.ErosionveDilation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeger)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonResimYukle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSetPikselEksi;
        private System.Windows.Forms.Button buttonSetPikselArti;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonDilation;
        private System.Windows.Forms.Button buttonErosion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonTersSimetri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDeger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonBitmap;
        private System.Windows.Forms.RadioButton radioButtonGrayScale;
        private System.Windows.Forms.RadioButton radioButtonRGB;
        private System.Windows.Forms.Panel panel9;
    }
}

