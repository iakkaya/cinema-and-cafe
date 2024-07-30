namespace fiyatlandirma_uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBilet = new TextBox();
            textÇay = new TextBox();
            textSu = new TextBox();
            textMisir = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            labelKasa = new Label();
            button1 = new Button();
            label13 = new Label();
            labelToplam = new Label();
            label9 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(textBilet);
            groupBox1.Controls.Add(textÇay);
            groupBox1.Controls.Add(textSu);
            groupBox1.Controls.Add(textMisir);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktarı";
            // 
            // textBilet
            // 
            textBilet.Location = new Point(129, 173);
            textBilet.Name = "textBilet";
            textBilet.Size = new Size(125, 27);
            textBilet.TabIndex = 7;
            // 
            // textÇay
            // 
            textÇay.Location = new Point(129, 125);
            textÇay.Name = "textÇay";
            textÇay.Size = new Size(125, 27);
            textÇay.TabIndex = 6;
            // 
            // textSu
            // 
            textSu.Location = new Point(129, 80);
            textSu.Name = "textSu";
            textSu.Size = new Size(125, 27);
            textSu.TabIndex = 5;
            // 
            // textMisir
            // 
            textMisir.Location = new Point(129, 37);
            textMisir.Name = "textMisir";
            textMisir.Size = new Size(125, 27);
            textMisir.TabIndex = 4;
            textMisir.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "BİLET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "ÇAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "SU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "MISIR ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(415, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 180);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 4;
            label8.Text = "BİLET : 8 tl";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 132);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 3;
            label7.Text = "ÇAY : 2 tl";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 87);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 2;
            label6.Text = "SU : 1 tl";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 44);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 1;
            label5.Text = "MISIR  : 4 tl ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(labelKasa);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(labelToplam);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(748, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 271);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // labelKasa
            // 
            labelKasa.AutoSize = true;
            labelKasa.Location = new Point(149, 213);
            labelKasa.Name = "labelKasa";
            labelKasa.Size = new Size(44, 20);
            labelKasa.TabIndex = 6;
            labelKasa.Text = "00 TL";
            // 
            // button1
            // 
            button1.Location = new Point(67, 118);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 2;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 213);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 5;
            label13.Text = "KASA :";
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Location = new Point(149, 83);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(44, 20);
            labelToplam.TabIndex = 1;
            labelToplam.Text = "00 TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 80);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 0;
            label9.Text = "Toplam :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Handwriting", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(33, 24);
            label11.Name = "label11";
            label11.Size = new Size(539, 61);
            label11.TabIndex = 3;
            label11.Text = "BÜFE SATIŞ PANELİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(578, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(67, 166);
            button2.Name = "button2";
            button2.Size = new Size(126, 34);
            button2.TabIndex = 7;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 416);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBilet;
        private TextBox textÇay;
        private TextBox textSu;
        private TextBox textMisir;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button button1;
        private Label labelToplam;
        private Label label9;
        private Label label11;
        private PictureBox pictureBox1;
        private Label labelKasa;
        private Label label13;
        private Button button2;
    }
}
