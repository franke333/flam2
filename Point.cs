using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace flam2
{
    public struct Point
    {
        public float x;
        public float y;
        public Color c;
        public Point(float x,float y, Color c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
    }
}
