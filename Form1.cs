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

namespace flam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Type[] variations = {
            typeof(Spherical),typeof(Sinusoidal),typeof(Linear),typeof(Swirl),
            typeof(Fisheye),typeof(Bubble),typeof(Cylinder),typeof(Handkerchief),
            typeof(Hyperbolic),typeof(Ex)
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

            flame.width = int.Parse(textBoxWidth.Text);
            flame.height = int.Parse(textBoxHeight.Text);
            flame.centerX = float.Parse(textBoxCenterX.Text, CultureInfo.InvariantCulture);
            flame.centerY = float.Parse(textBoxCenterY.Text, CultureInfo.InvariantCulture);
            flame.scale = int.Parse(textBoxScale.Text);
            flame.oversample = int.Parse(textBoxOversampling.Text);
            flame.quality = int.Parse(textBoxQuality.Text);
            flame.palleteIndex = int.Parse(textBoxPalette.Text);
            flame.gamma = float.Parse(textBoxGamma.Text, CultureInfo.InvariantCulture);

            int numFuncs = int.Parse(textBoxFlames.Text);
            flame.funcs = new Function[numFuncs];
            flame.weights = new float[numFuncs];

            String[] funcVars = textBoxFuncs.Text.Split(';');
            for (int i = 0; i < funcVars.Length; i++)
            {
                funcVars[i] = funcVars[i].Replace("\r", "");
                funcVars[i] = funcVars[i].Replace("\n", "");
                funcVars[i] = funcVars[i].Replace(" ", "");
            }

            for (int i = 0; i < numFuncs; i++)
            {
                String[] vars = funcVars[i * 2].Split(',');
                String[] coeffsStr = funcVars[i * 2 + 1].Split(',');
                float[] coeffs = new float[6];
                for (int j = 0; j < 6; j++)
                {
                    coeffs[j] = float.Parse(coeffsStr[j], CultureInfo.InvariantCulture);
                }
                Variation var = (Variation)Activator.CreateInstance(variations[int.Parse(vars[2], CultureInfo.InvariantCulture)]);
                flame.weights[i] = float.Parse(vars[0], CultureInfo.InvariantCulture);

                flame.funcs[i] = new Function(coeffs,var,Palette.GetColor(flame.palleteIndex,float.Parse(vars[1], CultureInfo.InvariantCulture)));
            }
            pictureBox1.Image = flame.Run(this);
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
                sb.AppendFormat("{0},{1},{2};\r\n",weight.ToString("0.0000", CultureInfo.InvariantCulture),
                    color.ToString("0.0", CultureInfo.InvariantCulture), var);
                for (int j = 0; j < 6; j++)
                {
                    sb.Append((r.NextDouble() * 2 - 1).ToString("0.000", CultureInfo.InvariantCulture));
                    if (j != 5) sb.Append(",");
                    else sb.Append(";\n");
                }
            }
            textBoxFuncs.Text = sb.ToString();
        }
    }
}
