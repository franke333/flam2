using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace flam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxSaveFolder.Text = folderBrowserDialog1.SelectedPath;
            setTooltips();
        }

        static Type[] variations = {
            typeof(Spherical),typeof(Sinusoidal),typeof(Linear),typeof(Swirl),
            typeof(Fisheye),typeof(Bubble),typeof(Cylinder),typeof(Handkerchief),
            typeof(Hyperbolic),typeof(Ex),typeof(Horseshoe),
            typeof(Polar),typeof(Heart),typeof(Disc),
            typeof(Spiral),typeof(Diamond),typeof(Julia)
        };

        public void setProgress(int max)
        {
            progressBar1.Maximum = max;
            progressBar1.Value = 0;
        }

        public void updateProgress()
        {
            progressBar1.PerformStep();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Flame flame = new Flame();
            String pathFolder = "";

            flame.width = int.Parse(textBoxWidth.Text);
            flame.height = int.Parse(textBoxHeight.Text);
            flame.centerX = float.Parse(textBoxCenterX.Text, CultureInfo.InvariantCulture);
            flame.centerY = float.Parse(textBoxCenterY.Text, CultureInfo.InvariantCulture);
            flame.scale = int.Parse(textBoxScale.Text);
            flame.oversample = int.Parse(textBoxOversampling.Text);
            flame.quality = int.Parse(textBoxQuality.Text);
            flame.gamma = float.Parse(textBoxGamma.Text, CultureInfo.InvariantCulture);
            flame.frames = int.Parse(textBoxFrames.Text);

            int numFuncs = int.Parse(textBoxFlames.Text);
            flame.funcs = new Function[numFuncs];
            flame.weights = new float[numFuncs];

            bool anim = checkBoxAnimate.Checked;
            bool save = checkBoxSaveAnim.Checked;

            String[] funcVars = textBoxFuncs.Text.Split(';');
            if (save)
            {
                long time = DateTime.Now.ToBinary();
                pathFolder = textBoxSaveFolder.Text +"\\animation_"+ time.ToString();
                Directory.CreateDirectory(pathFolder);
            }
            for (int i = 0; i < funcVars.Length; i++)
            {
                funcVars[i] = funcVars[i].Replace("\r", "");
                funcVars[i] = funcVars[i].Replace("\n", "");
                funcVars[i] = funcVars[i].Replace(" ", "");
            }

            int k = 0;
            for (int i = 0; i < numFuncs; i++)
            {
                String[] vars = funcVars[k++].Split(',');
                String[] coeffsStr = funcVars[k++].Split(',');
                String[] coeffsFinalStr = { };
                if (anim) 
                    coeffsFinalStr = funcVars[k++].Split(',');
                float[] coeffs = new float[6];
                float[] finalCoeffs = new float[6];
                for (int j = 0; j < 6; j++)
                {
                    coeffs[j] = float.Parse(coeffsStr[j], CultureInfo.InvariantCulture);
                    if (anim) finalCoeffs[j] = float.Parse(coeffsFinalStr[j], CultureInfo.InvariantCulture);
                }
                Variation var = (Variation)Activator.CreateInstance(variations[int.Parse(vars[1], CultureInfo.InvariantCulture)]);
                flame.weights[i] = float.Parse(vars[0], CultureInfo.InvariantCulture);

                flame.funcs[i] = new Function(coeffs,var,Color.FromArgb(int.Parse(vars[2]), int.Parse(vars[3]), int.Parse(vars[4])));
                if (anim) flame.funcs[i].coeffsUpd = finalCoeffs;
                if (anim) for (int j = 0; j < 6; j++)
                {
                        flame.funcs[i].coeffsUpd[j] = (flame.funcs[i].coeffsUpd[j] - flame.funcs[i].coeffs[j]) / Math.Max(((float)flame.frames-1),1f); //(y-x)/frames
                }
                
            }
            pictureBox1.Image = flame.Run(this);
            pictureBox1.Refresh();
            if (anim)
            {
                progressBar2.Maximum = flame.frames;
                progressBar2.Value = 1;
                progressBar2.Step = 1;
                if (save)
                {
                    String path = pathFolder + "\\frame_" + (0).ToString().PadLeft(5, '0') + ".png";
                    pictureBox1.Image.Save(path, ImageFormat.Png);
                }
                for (int i = 0; i < flame.frames-1; i++)
                {
                    flame.Update();
                    pictureBox1.Image = flame.Run(this);
                    pictureBox1.Refresh();
                    progressBar2.PerformStep();
                    if (save)
                    {
                        String path = pathFolder + "\\frame_" + (i+1).ToString().PadLeft(5, '0') + ".png";
                        pictureBox1.Image.Save(path, ImageFormat.Png);
                    }
                }
                
            }
        }


        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            int flames = int.Parse(textBoxFlames.Text);
            for (int i = 0; i < flames; i++)
            {
                float weight = (float)r.NextDouble();
                float color = (float)(r.Next(0, 11) / 10f);
                int var = r.Next(0, variations.Length);
                sb.AppendFormat("{0},{1},{2},{3},{4};\r\n",weight.ToString("0.0000", CultureInfo.InvariantCulture),
                    var,r.Next(0,256), r.Next(0, 256), r.Next(0, 256));
                for (int j = 0; j < 6; j++)
                {
                    sb.Append((r.NextDouble() * 2 - 1).ToString("0.000", CultureInfo.InvariantCulture));
                    if (j != 5) sb.Append(",");
                    else sb.Append(";\r\n");
                }
                if(checkBoxAnimate.Checked) for (int j = 0; j < 6; j++)
                    {
                        sb.Append((r.NextDouble() * 2 - 1).ToString("0.000", CultureInfo.InvariantCulture));
                        if (j != 5) sb.Append(",");
                        else sb.Append(";\r\n");
                    }
            }
            textBoxFuncs.Text = sb.ToString();
        }
















        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void setTooltips()
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(labelRes,"Set resolution of final image in pixels (width x height)");
            tt1.SetToolTip(labelQuality, "How many iterations per pixel (the more, the better image, but takes longer)\n 1 is minimum, 10+ wont make big difference");
            tt1.SetToolTip(labelAnim,"Animate fractals\nNeeds 2 lines for coefficients (first line as starting coeffs which gradually transform to second line over the duration of frames)");
            tt1.SetToolTip(labelCenter,"Sets the center of image\n(1 unit equals to half a image)\nCan be float");
            tt1.SetToolTip(labelFlames,"Each 2 lines (3 if animated) corresponds to 1 function, every line must be ended with ';'\n\n"+
                "weight,variation,r,g,b;\na,b,c,d,e,f;\n(only if animated)aFinal,bFinal,cFinal,dFinal,eFinal,fFinal;\n\n"+
                "weight = number(float) at which this function is chosen each iteration(chance = weight/SumOfAllWeights)\n"+
                "variation = which Variation is used, see ? for more help\nr,g,b = numbers between 0 and 255 inclusive that sets RGB color to this function\n"+
                "a,b,c,d,e,f = floats (recommended) between -1 and 1. F(x,y) = (ax+by+c,dx+ey+f)");
            tt1.SetToolTip(labelFrames,"How many frames for this animation -> more frames = less big jumps in animation");
            tt1.SetToolTip(labelGamma,"Set the brightness of colors\n1 = base colors\n2.2 = golden ratio (recommended)\n4 = pastel colors");
            tt1.SetToolTip(labelOversample,"When calculating the image, it is recommended that we ovesample.\n"+
                "For example if Oversample is set to 2, then when the picture is being calculated, for each pixel there is actually 4 points(2x2)\n"+
                "and when the image is being drawn on bitmap those 4 points avarage into 1 pixel\nOversample = 1 turns off the oversampling");
            tt1.SetToolTip(labelScale, "How many pixels equals to 1 unit in the image. This zoom in or zoom out the image");

        }

        private void buttonChangeSave_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxSaveFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBoxSaveFolder.Text + "\\ff_" + DateTime.Now.ToBinary() + ".png";
            pictureBox1.Image.Save(str, ImageFormat.Png);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonRandomize_Click(sender, e);
            buttonGenerate_Click(sender, e);
        }
    }
}
