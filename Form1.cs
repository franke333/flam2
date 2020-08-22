using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            typeof(Spherical),typeof(Swirl),typeof(Linear),typeof(Sinusoidal)
        };

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Flame flame = new Flame();

            flame.width = int.Parse(textBoxWidth.Text);
            flame.height = int.Parse(textBoxHeight.Text);
            flame.centerX = float.Parse(textBoxCenterX.Text);
            flame.centerY = float.Parse(textBoxCenterY.Text);
            flame.scale = int.Parse(textBoxScale.Text);
            flame.oversample = int.Parse(textBoxOversampling.Text);
            flame.quality = int.Parse(textBoxQuality.Text);
            flame.palleteIndex = int.Parse(textBoxPalette.Text);

            int numFuncs = int.Parse(textBoxFlames.Text);
            flame.funcs = new Function[numFuncs];
            flame.weights = new float[numFuncs];

            String[] funcVars = textBoxFuncs.Text.Split('\n');

            for (int i = 0; i < numFuncs; i++)
            {
                String[] vars = funcVars[i * 2].Split(',');
                String[] coeffsStr = funcVars[i * 2 + 1].Split(',');
                float[] coeffs = new float[6];
                for (int j = 0; j < 6; j++)
                {
                    coeffs[j] = float.Parse(coeffsStr[j]);
                }
                Variation var = (Variation)Activator.CreateInstance(variations[int.Parse(vars[2])]);
                flame.weights[i] = float.Parse(vars[0]);

                flame.funcs[i] = new Function(coeffs,var,Palette.GetColor(flame.palleteIndex,float.Parse(vars[1])));
            }
            pictureBox1.Image = flame.Run();
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
    }
}
