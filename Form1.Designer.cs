namespace flam2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOversampling = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPalette = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQuality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFuncs = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFlames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(411, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1407, 971);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resolution";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(172, 20);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(114, 26);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "300";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(297, 20);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(106, 26);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "300";
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(297, 66);
            this.textBoxCenterY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(106, 26);
            this.textBoxCenterY.TabIndex = 6;
            this.textBoxCenterY.Text = "0";
            this.textBoxCenterY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(172, 66);
            this.textBoxCenterX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(114, 26);
            this.textBoxCenterX.TabIndex = 5;
            this.textBoxCenterX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Center [-1,1]";
            // 
            // textBoxOversampling
            // 
            this.textBoxOversampling.Location = new System.Drawing.Point(297, 157);
            this.textBoxOversampling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOversampling.Name = "textBoxOversampling";
            this.textBoxOversampling.Size = new System.Drawing.Size(106, 26);
            this.textBoxOversampling.TabIndex = 12;
            this.textBoxOversampling.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oversampling (1=off)";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(297, 111);
            this.textBoxScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(106, 26);
            this.textBoxScale.TabIndex = 9;
            this.textBoxScale.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Scale (pixels per unit)";
            // 
            // textBoxPalette
            // 
            this.textBoxPalette.Location = new System.Drawing.Point(297, 248);
            this.textBoxPalette.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPalette.Name = "textBoxPalette";
            this.textBoxPalette.Size = new System.Drawing.Size(106, 26);
            this.textBoxPalette.TabIndex = 18;
            this.textBoxPalette.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Palette";
            // 
            // textBoxQuality
            // 
            this.textBoxQuality.Location = new System.Drawing.Point(297, 202);
            this.textBoxQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuality.Name = "textBoxQuality";
            this.textBoxQuality.Size = new System.Drawing.Size(106, 26);
            this.textBoxQuality.TabIndex = 15;
            this.textBoxQuality.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(10, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quality";
            // 
            // textBoxFuncs
            // 
            this.textBoxFuncs.Location = new System.Drawing.Point(16, 379);
            this.textBoxFuncs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFuncs.Multiline = true;
            this.textBoxFuncs.Name = "textBoxFuncs";
            this.textBoxFuncs.Size = new System.Drawing.Size(376, 332);
            this.textBoxFuncs.TabIndex = 19;
            this.textBoxFuncs.Text = "1,0,1\r\n0.6,0.5,0.3,0.4,0.6,-0.1\r\n1,1,2\r\n0.3,0.3,0.5,0.4,0.2,0.5\r\n";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(22, 721);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(370, 98);
            this.buttonGenerate.TabIndex = 20;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 87);
            this.label5.TabIndex = 21;
            this.label5.Text = "Flames:\r\nweight,color[0,1],variation\r\n6x coeffs divided by \',\'";
            // 
            // textBoxFlames
            // 
            this.textBoxFlames.Location = new System.Drawing.Point(297, 287);
            this.textBoxFlames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFlames.Name = "textBoxFlames";
            this.textBoxFlames.Size = new System.Drawing.Size(106, 26);
            this.textBoxFlames.TabIndex = 23;
            this.textBoxFlames.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1820, 975);
            this.Controls.Add(this.textBoxFlames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxFuncs);
            this.Controls.Add(this.textBoxPalette);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuality);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxOversampling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCenterY);
            this.Controls.Add(this.textBoxCenterX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOversampling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPalette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFuncs;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFlames;
    }
}

