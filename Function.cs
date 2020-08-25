using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace flam2
{
    class Function
    {
        public float[] coeffs;
        public float[] coeffsUpd;
        public Variation var;
        public Color color;
        public Function(float[] coeffs,Variation var, Color color)
        {
            this.coeffs = coeffs;
            this.var = var;
            this.color = color;
        }
        /// <summary>
        /// Combine 2 colors
        /// </summary>
        static private Color combineColors(Color a,Color b)
        {
            return Color.FromArgb((a.R + b.R) / 2, (a.G + b.G) / 2, (a.B + b.B) / 2);
        }


        /// <summary>
        /// Affine pretransform function A(x,y) := (ax+by+c,dx+ey+f) using coeffs[] as coefficients
        /// </summary>
        private Point Affine(Point input)
        {
            return new Point(coeffs[0] * input.x + coeffs[1] * input.y + coeffs[2], coeffs[3] * input.x + coeffs[4] * input.y + coeffs[5],input.c);
        }

        public void updateCoeffs()
        {
            if (coeffsUpd == null) return;
            for (int i = 0; i < 6; i++)
            {
                coeffs[i] += coeffsUpd[i];
            }
        }

        /// <summary>
        /// Do the thing
        /// </summary>
        public Point Apply(Point point)
        {
            point = var.flame(Affine(point));
            point.c = combineColors(point.c, color);
            return point;
        }

    }
}
