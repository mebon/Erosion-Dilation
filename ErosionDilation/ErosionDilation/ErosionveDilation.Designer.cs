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
            this.buttonSifirla = new System.Windows.Forms.Button();
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonLaplacian = new System.Windows.Forms.Button();
            this.buttonConvulation = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonClosing = new System.Windows.Forms.Button();
            this.buttonOpening = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonTersSimetri = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonGradient = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonStandartDefination = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.labelStandartSapma = new System.Windows.Forms.Label();
            this.labelOrt1 = new System.Windows.Forms.Label();
            this.labelEksi = new System.Windows.Forms.Label();
            this.labelStnSp1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelstnSp2 = new System.Windows.Forms.Label();
            this.labelArti = new System.Windows.Forms.Label();
            this.labelort2 = new System.Windows.Forms.Label();
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
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(325, 18);
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
            this.panel4.Controls.Add(this.buttonSifirla);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.radioButtonBitmap);
            this.panel4.Controls.Add(this.radioButtonGrayScale);
            this.panel4.Controls.Add(this.radioButtonRGB);
            this.panel4.Location = new System.Drawing.Point(325, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 41);
            this.panel4.TabIndex = 3;
            // 
            // buttonSifirla
            // 
            this.buttonSifirla.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSifirla.Location = new System.Drawing.Point(25, 4);
            this.buttonSifirla.Name = "buttonSifirla";
            this.buttonSifirla.Size = new System.Drawing.Size(87, 30);
            this.buttonSifirla.TabIndex = 4;
            this.buttonSifirla.Text = "Sıfırla";
            this.buttonSifirla.UseVisualStyleBackColor = true;
            this.buttonSifirla.Click += new System.EventHandler(this.buttonSifirla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(235, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bitmap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(168, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "GrayScale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(129, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "RGB";
            // 
            // radioButtonBitmap
            // 
            this.radioButtonBitmap.AutoSize = true;
            this.radioButtonBitmap.Location = new System.Drawing.Point(252, 23);
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
            this.radioButtonGrayScale.Location = new System.Drawing.Point(191, 23);
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
            this.radioButtonRGB.Location = new System.Drawing.Point(139, 23);
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
            this.panel5.Location = new System.Drawing.Point(325, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 61);
            this.panel5.TabIndex = 3;
            // 
            // buttonSetPikselEksi
            // 
            this.buttonSetPikselEksi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSetPikselEksi.Location = new System.Drawing.Point(157, 15);
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
            this.buttonSetPikselArti.Location = new System.Drawing.Point(25, 15);
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
            this.panel6.Location = new System.Drawing.Point(325, 188);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 61);
            this.panel6.TabIndex = 3;
            // 
            // buttonDilation
            // 
            this.buttonDilation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDilation.Location = new System.Drawing.Point(157, 15);
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
            this.buttonErosion.Location = new System.Drawing.Point(25, 15);
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
            this.panel7.Location = new System.Drawing.Point(19, 477);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 61);
            this.panel7.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad ve Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Okul Numarası : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "201513171070";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 12);
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
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
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
            this.panel8.Size = new System.Drawing.Size(644, 551);
            this.panel8.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.buttonLaplacian);
            this.panel11.Controls.Add(this.buttonConvulation);
            this.panel11.Location = new System.Drawing.Point(325, 340);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(300, 61);
            this.panel11.TabIndex = 7;
            // 
            // buttonLaplacian
            // 
            this.buttonLaplacian.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLaplacian.Location = new System.Drawing.Point(157, 14);
            this.buttonLaplacian.Name = "buttonLaplacian";
            this.buttonLaplacian.Size = new System.Drawing.Size(115, 30);
            this.buttonLaplacian.TabIndex = 5;
            this.buttonLaplacian.Text = "Laplacian\r\n";
            this.buttonLaplacian.UseVisualStyleBackColor = true;
            this.buttonLaplacian.Click += new System.EventHandler(this.buttonLaplacian_Click);
            // 
            // buttonConvulation
            // 
            this.buttonConvulation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConvulation.Location = new System.Drawing.Point(25, 14);
            this.buttonConvulation.Name = "buttonConvulation";
            this.buttonConvulation.Size = new System.Drawing.Size(115, 30);
            this.buttonConvulation.TabIndex = 4;
            this.buttonConvulation.Text = "Convolution\r\n";
            this.buttonConvulation.UseVisualStyleBackColor = true;
            this.buttonConvulation.Click += new System.EventHandler(this.buttonConvulation_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.buttonClosing);
            this.panel10.Controls.Add(this.buttonOpening);
            this.panel10.Location = new System.Drawing.Point(325, 264);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(300, 61);
            this.panel10.TabIndex = 6;
            // 
            // buttonClosing
            // 
            this.buttonClosing.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClosing.Location = new System.Drawing.Point(157, 14);
            this.buttonClosing.Name = "buttonClosing";
            this.buttonClosing.Size = new System.Drawing.Size(115, 30);
            this.buttonClosing.TabIndex = 5;
            this.buttonClosing.Text = "Closing\r";
            this.buttonClosing.UseVisualStyleBackColor = true;
            this.buttonClosing.Click += new System.EventHandler(this.buttonClosing_Click);
            // 
            // buttonOpening
            // 
            this.buttonOpening.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOpening.Location = new System.Drawing.Point(25, 14);
            this.buttonOpening.Name = "buttonOpening";
            this.buttonOpening.Size = new System.Drawing.Size(115, 30);
            this.buttonOpening.TabIndex = 4;
            this.buttonOpening.Text = "Opening\r\n";
            this.buttonOpening.UseVisualStyleBackColor = true;
            this.buttonOpening.Click += new System.EventHandler(this.buttonOpening_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.buttonTersSimetri);
            this.panel9.Location = new System.Drawing.Point(19, 405);
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
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.buttonGradient);
            this.panel12.Location = new System.Drawing.Point(325, 410);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(300, 61);
            this.panel12.TabIndex = 8;
            // 
            // buttonGradient
            // 
            this.buttonGradient.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGradient.Location = new System.Drawing.Point(25, 14);
            this.buttonGradient.Name = "buttonGradient";
            this.buttonGradient.Size = new System.Drawing.Size(87, 30);
            this.buttonGradient.TabIndex = 4;
            this.buttonGradient.Text = "Gradient";
            this.buttonGradient.UseVisualStyleBackColor = true;
            this.buttonGradient.Click += new System.EventHandler(this.buttonGradient_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.labelstnSp2);
            this.panel13.Controls.Add(this.labelArti);
            this.panel13.Controls.Add(this.labelort2);
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.labelStnSp1);
            this.panel13.Controls.Add(this.labelEksi);
            this.panel13.Controls.Add(this.labelOrt1);
            this.panel13.Controls.Add(this.labelStandartSapma);
            this.panel13.Controls.Add(this.labelOrtalama);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Controls.Add(this.buttonStandartDefination);
            this.panel13.Location = new System.Drawing.Point(325, 477);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(300, 61);
            this.panel13.TabIndex = 8;
            // 
            // buttonStandartDefination
            // 
            this.buttonStandartDefination.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStandartDefination.Location = new System.Drawing.Point(25, 7);
            this.buttonStandartDefination.Name = "buttonStandartDefination";
            this.buttonStandartDefination.Size = new System.Drawing.Size(87, 43);
            this.buttonStandartDefination.TabIndex = 4;
            this.buttonStandartDefination.Text = "Standart Defination";
            this.buttonStandartDefination.UseVisualStyleBackColor = true;
            this.buttonStandartDefination.Click += new System.EventHandler(this.buttonStandartDefination_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(220, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 30);
            this.label9.TabIndex = 7;
            this.label9.Text = "[ 0  1 ]\r\n[ 1  0 ]\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(118, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Gradient Matrisi : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(118, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ortalama : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(118, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Standart Sapma : ";
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.AutoSize = true;
            this.labelOrtalama.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrtalama.Location = new System.Drawing.Point(212, 7);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(13, 15);
            this.labelOrtalama.TabIndex = 10;
            this.labelOrtalama.Text = "0";
            // 
            // labelStandartSapma
            // 
            this.labelStandartSapma.AutoSize = true;
            this.labelStandartSapma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStandartSapma.Location = new System.Drawing.Point(212, 23);
            this.labelStandartSapma.Name = "labelStandartSapma";
            this.labelStandartSapma.Size = new System.Drawing.Size(13, 15);
            this.labelStandartSapma.TabIndex = 11;
            this.labelStandartSapma.Text = "0";
            // 
            // labelOrt1
            // 
            this.labelOrt1.AutoSize = true;
            this.labelOrt1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrt1.Location = new System.Drawing.Point(118, 35);
            this.labelOrt1.Name = "labelOrt1";
            this.labelOrt1.Size = new System.Drawing.Size(23, 15);
            this.labelOrt1.TabIndex = 12;
            this.labelOrt1.Text = "|ort";
            // 
            // labelEksi
            // 
            this.labelEksi.AutoSize = true;
            this.labelEksi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEksi.Location = new System.Drawing.Point(136, 34);
            this.labelEksi.Name = "labelEksi";
            this.labelEksi.Size = new System.Drawing.Size(11, 15);
            this.labelEksi.TabIndex = 13;
            this.labelEksi.Text = "-";
            // 
            // labelStnSp1
            // 
            this.labelStnSp1.AutoSize = true;
            this.labelStnSp1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStnSp1.Location = new System.Drawing.Point(143, 35);
            this.labelStnSp1.Name = "labelStnSp1";
            this.labelStnSp1.Size = new System.Drawing.Size(37, 15);
            this.labelStnSp1.TabIndex = 14;
            this.labelStnSp1.Text = "stnSp|";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(176, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "<= N. D. <=";
            // 
            // labelstnSp2
            // 
            this.labelstnSp2.AutoSize = true;
            this.labelstnSp2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelstnSp2.Location = new System.Drawing.Point(262, 35);
            this.labelstnSp2.Name = "labelstnSp2";
            this.labelstnSp2.Size = new System.Drawing.Size(37, 15);
            this.labelstnSp2.TabIndex = 18;
            this.labelstnSp2.Text = "stnSp|";
            // 
            // labelArti
            // 
            this.labelArti.AutoSize = true;
            this.labelArti.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelArti.Location = new System.Drawing.Point(254, 34);
            this.labelArti.Name = "labelArti";
            this.labelArti.Size = new System.Drawing.Size(14, 15);
            this.labelArti.TabIndex = 17;
            this.labelArti.Text = "+";
            // 
            // labelort2
            // 
            this.labelort2.AutoSize = true;
            this.labelort2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelort2.Location = new System.Drawing.Point(236, 35);
            this.labelort2.Name = "labelort2";
            this.labelort2.Size = new System.Drawing.Size(23, 15);
            this.labelort2.TabIndex = 16;
            this.labelort2.Text = "|ort";
            // 
            // ErosionveDilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(668, 575);
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
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
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
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonClosing;
        private System.Windows.Forms.Button buttonOpening;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonLaplacian;
        private System.Windows.Forms.Button buttonConvulation;
        private System.Windows.Forms.Button buttonSifirla;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button buttonStandartDefination;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonGradient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStandartSapma;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.Label labelstnSp2;
        private System.Windows.Forms.Label labelArti;
        private System.Windows.Forms.Label labelort2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelStnSp1;
        private System.Windows.Forms.Label labelEksi;
        private System.Windows.Forms.Label labelOrt1;
    }
}

