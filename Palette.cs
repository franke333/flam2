using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace flam2
{
    static class Palette
    {
        static private Tuple<Color, Color>[] palette =
        {
            new Tuple<Color,Color>(Color.FromArgb(37,19,201),Color.FromArgb(255,120,5))
        };

        /// <summary>
        /// Get a Color from color pallete.
        /// </summary>
        /// <param name="paletteIndex">Which palette.</param>
        /// <param name="first">[0,1] of how much of first color.</param>
        static public Color GetColor(int paletteIndex, float first)
        {
            float second = 1 - first;
            float r = palette[paletteIndex].Item1.R * first + palette[paletteIndex].Item2.R * second;
            float g = palette[paletteIndex].Item1.G * first + palette[paletteIndex].Item2.G * second;
            float b = palette[paletteIndex].Item1.B * first + palette[paletteIndex].Item2.B * second;
            return Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
