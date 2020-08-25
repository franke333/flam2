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
            this.labelRes = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.labelCenter = new System.Windows.Forms.Label();
            this.textBoxOversampling = new System.Windows.Forms.TextBox();
            this.labelOversample = new System.Windows.Forms.Label();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxQuality = new System.Windows.Forms.TextBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.textBoxFuncs = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelFlames = new System.Windows.Forms.Label();
            this.textBoxFlames = new System.Windows.Forms.TextBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.labelGamma = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.textBoxFrames = new System.Windows.Forms.TextBox();
            this.labelAnim = new System.Windows.Forms.Label();
            this.checkBoxAnimate = new System.Windows.Forms.CheckBox();
            this.labelFrames = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.buttonChangeSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxSaveAnim = new System.Windows.Forms.CheckBox();
            this.labelSaveAnimation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(274, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 812);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRes.Location = new System.Drawing.Point(7, 11);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(85, 20);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Resolution";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(115, 13);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(77, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "400";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(198, 13);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(72, 20);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "400";
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(198, 43);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(72, 20);
            this.textBoxCenterY.TabIndex = 6;
            this.textBoxCenterY.Text = "0";
            this.textBoxCenterY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(115, 43);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(77, 20);
            this.textBoxCenterX.TabIndex = 5;
            this.textBoxCenterX.Text = "0";
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCenter.Location = new System.Drawing.Point(7, 41);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(57, 20);
            this.labelCenter.TabIndex = 4;
            this.labelCenter.Text = "Center";
            // 
            // textBoxOversampling
            // 
            this.textBoxOversampling.Location = new System.Drawing.Point(198, 102);
            this.textBoxOversampling.Name = "textBoxOversampling";
            this.textBoxOversampling.Size = new System.Drawing.Size(72, 20);
            this.textBoxOversampling.TabIndex = 12;
            this.textBoxOversampling.Text = "2";
            // 
            // labelOversample
            // 
            this.labelOversample.AutoSize = true;
            this.labelOversample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOversample.Location = new System.Drawing.Point(7, 100);
            this.labelOversample.Name = "labelOversample";
            this.labelOversample.Size = new System.Drawing.Size(105, 20);
            this.labelOversample.TabIndex = 10;
            this.labelOversample.Text = "Oversampling";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(198, 72);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(72, 20);
            this.textBoxScale.TabIndex = 9;
            this.textBoxScale.Text = "80";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScale.Location = new System.Drawing.Point(7, 70);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(49, 20);
            this.labelScale.TabIndex = 7;
            this.labelScale.Text = "Scale";
            // 
            // textBoxQuality
            // 
            this.textBoxQuality.Location = new System.Drawing.Point(198, 131);
            this.textBoxQuality.Name = "textBoxQuality";
            this.textBoxQuality.Size = new System.Drawing.Size(72, 20);
            this.textBoxQuality.TabIndex = 15;
            this.textBoxQuality.Text = "5";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuality.Location = new System.Drawing.Point(7, 129);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(57, 20);
            this.labelQuality.TabIndex = 13;
            this.labelQuality.Text = "Quality";
            // 
            // textBoxFuncs
            // 
            this.textBoxFuncs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFuncs.Location = new System.Drawing.Point(9, 350);
            this.textBoxFuncs.Multiline = true;
            this.textBoxFuncs.Name = "textBoxFuncs";
            this.textBoxFuncs.Size = new System.Drawing.Size(252, 217);
            this.textBoxFuncs.TabIndex = 19;
            this.textBoxFuncs.Text = "0.4725,3,251,224,142;\r\n0.347,0.588,-0.347,-0.844,-0.148,-0.765;\r\n0.7383,10,28,221" +
    ",109;\r\n-0.694,-0.037,0.545,-0.810,0.875,-0.454;";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(13, 573);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(119, 64);
            this.buttonGenerate.TabIndex = 20;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelFlames
            // 
            this.labelFlames.AutoSize = true;
            this.labelFlames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFlames.Location = new System.Drawing.Point(7, 291);
            this.labelFlames.Name = "labelFlames";
            this.labelFlames.Size = new System.Drawing.Size(186, 60);
            this.labelFlames.TabIndex = 21;
            this.labelFlames.Text = "Flames:\r\nweight,color[0,1],variation\r\n6x coeffs divided by \',\'";
            // 
            // textBoxFlames
            // 
            this.textBoxFlames.Location = new System.Drawing.Point(196, 291);
            this.textBoxFlames.Name = "textBoxFlames";
            this.textBoxFlames.Size = new System.Drawing.Size(72, 20);
            this.textBoxFlames.TabIndex = 23;
            this.textBoxFlames.Text = "2";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(198, 157);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(72, 20);
            this.textBoxGamma.TabIndex = 25;
            this.textBoxGamma.Text = "2.2";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGamma.Location = new System.Drawing.Point(7, 155);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(66, 20);
            this.labelGamma.TabIndex = 24;
            this.labelGamma.Text = "Gamma";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 642);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 26;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(196, 317);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(70, 27);
            this.buttonRandomize.TabIndex = 27;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // textBoxFrames
            // 
            this.textBoxFrames.Location = new System.Drawing.Point(76, 272);
            this.textBoxFrames.Name = "textBoxFrames";
            this.textBoxFrames.Size = new System.Drawing.Size(72, 20);
            this.textBoxFrames.TabIndex = 29;
            this.textBoxFrames.Text = "30";
            // 
            // labelAnim
            // 
            this.labelAnim.AutoSize = true;
            this.labelAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnim.Location = new System.Drawing.Point(9, 250);
            this.labelAnim.Name = "labelAnim";
            this.labelAnim.Size = new System.Drawing.Size(45, 20);
            this.labelAnim.TabIndex = 28;
            this.labelAnim.Text = "Anim";
            // 
            // checkBoxAnimate
            // 
            this.checkBoxAnimate.AutoSize = true;
            this.checkBoxAnimate.Location = new System.Drawing.Point(60, 253);
            this.checkBoxAnimate.Name = "checkBoxAnimate";
            this.checkBoxAnimate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnimate.TabIndex = 30;
            this.checkBoxAnimate.UseVisualStyleBackColor = true;
            // 
            // labelFrames
            // 
            this.labelFrames.AutoSize = true;
            this.labelFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFrames.Location = new System.Drawing.Point(7, 270);
            this.labelFrames.Name = "labelFrames";
            this.labelFrames.Size = new System.Drawing.Size(63, 20);
            this.labelFrames.TabIndex = 31;
            this.labelFrames.Text = "Frames";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 671);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(248, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 721);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Save folder:";
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Location = new System.Drawing.Point(4, 744);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(267, 20);
            this.textBoxSaveFolder.TabIndex = 34;
            // 
            // buttonChangeSave
            // 
            this.buttonChangeSave.Location = new System.Drawing.Point(186, 718);
            this.buttonChangeSave.Name = "buttonChangeSave";
            this.buttonChangeSave.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeSave.TabIndex = 35;
            this.buttonChangeSave.Text = "Change";
            this.buttonChangeSave.UseVisualStyleBackColor = true;
            this.buttonChangeSave.Click += new System.EventHandler(this.buttonChangeSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 770);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 64);
            this.button2.TabIndex = 37;
            this.button2.Text = "Randomize\r\nand\r\n Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxSaveAnim
            // 
            this.checkBoxSaveAnim.AutoSize = true;
            this.checkBoxSaveAnim.Location = new System.Drawing.Point(246, 255);
            this.checkBoxSaveAnim.Name = "checkBoxSaveAnim";
            this.checkBoxSaveAnim.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSaveAnim.TabIndex = 39;
            this.checkBoxSaveAnim.UseVisualStyleBackColor = true;
            // 
            // labelSaveAnimation
            // 
            this.labelSaveAnimation.AutoSize = true;
            this.labelSaveAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaveAnimation.Location = new System.Drawing.Point(127, 250);
            this.labelSaveAnimation.Name = "labelSaveAnimation";
            this.labelSaveAnimation.Size = new System.Drawing.Size(120, 20);
            this.labelSaveAnimation.TabIndex = 38;
            this.labelSaveAnimation.Text = "Save Animation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1226, 815);
            this.Controls.Add(this.checkBoxSaveAnim);
            this.Controls.Add(this.labelSaveAnimation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonChangeSave);
            this.Controls.Add(this.textBoxSaveFolder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.labelFrames);
            this.Controls.Add(this.checkBoxAnimate);
            this.Controls.Add(this.textBoxFrames);
            this.Controls.Add(this.labelAnim);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.textBoxFlames);
            this.Controls.Add(this.labelFlames);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxFuncs);
            this.Controls.Add(this.textBoxQuality);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.textBoxOversampling);
            this.Controls.Add(this.labelOversample);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.textBoxCenterY);
            this.Controls.Add(this.textBoxCenterX);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.TextBox textBoxOversampling;
        private System.Windows.Forms.Label labelOversample;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxQuality;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.TextBox textBoxFuncs;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelFlames;
        private System.Windows.Forms.TextBox textBoxFlames;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.TextBox textBoxFrames;
        private System.Windows.Forms.Label labelAnim;
        private System.Windows.Forms.CheckBox checkBoxAnimate;
        private System.Windows.Forms.Label labelFrames;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.Button buttonChangeSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxSaveAnim;
        private System.Windows.Forms.Label labelSaveAnimation;
    }
}

