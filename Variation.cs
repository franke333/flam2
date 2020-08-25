using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flam2
{
    abstract class Variation
    {
        public abstract Point flame(Point point);


    }

    class Spherical : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            r = r * r;
            return new Point(point.x / r, point.y / r, point.c);
        }
    }

    class Sinusoidal : Variation
    {
        public override Point flame(Point point)
        {
            return new Point((float)Math.Sin(point.x), (float)Math.Sin(point.y), point.c);
        }
    }

    class Linear : Variation
    {
        public override Point flame(Point point)
        {
            return new Point(point.x, point.y, point.c);
        }
    }

    class Swirl : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            r = r * r;
            float x = (float)(point.x * Math.Sin(r) - point.y * Math.Cos(r));
            float y = (float)(point.x * Math.Cos(r) + point.y * Math.Sin(r));
            return new Point(x, y, point.c);
        }
    }

    class Fisheye : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            float n = 2 / (r + 1);
            return new Point(point.y * n, point.x * n, point.c);
        }
    }

    class Bubble : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            float n = 4 / (r * r + 4);
            return new Point(point.x * n, point.y * n, point.c);
        }
    }

    class Cylinder : Variation
    {
        public override Point flame(Point point)
        {
            return new Point((float)Math.Sin(point.x), point.y, point.c);
        }
    }

    class Handkerchief : Variation
    {
        public override Point flame(Point point)
        {
            double omega = Math.Atan2(point.x, point.y);
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            return new Point((float)Math.Sin(omega + r) * r, (float)Math.Cos(omega - r) * r, point.c);
        }
    }

    class Hyperbolic : Variation
    {
        public override Point flame(Point point)
        {
            double omega = Math.Atan2(point.x, point.y);
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            return new Point((float)Math.Sin(omega) / r, (float)Math.Cos(omega) * r, point.c);
        }
    }

    class Ex : Variation
    {
        public override Point flame(Point point)
        {
            double omega = Math.Atan2(point.x, point.y);
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            float p0 = (float)Math.Sin(omega + r); float p1 = (float)Math.Cos(omega - r);
            return new Point((p0 * p0 * p0 + p1 * p1 * p1) * r, (p0 * p0 * p0 - p1 * p1 * p1) * r, point.c);
        }
    }

    class Horseshoe : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            return new Point((point.x * point.x-point.y*point.y)/r, 2*point.x*point.y/r, point.c);
        }
    }

    class Polar : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            return new Point((float)(omega/Math.PI), r-1, point.c);
        }
    }

    class Heart : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            return new Point((float)Math.Sin(omega*r)*r , (float)(-Math.Cos(omega*r)*r) , point.c);
        }
    }

    class Disc : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            return new Point((float)(Math.Sin(Math.PI * r) * omega / Math.PI), (float)(Math.Cos(Math.PI * r) * omega / Math.PI), point.c);
        }
    }

    class Spiral : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            float x =(1/r)* (float)(Math.Cos(omega)+Math.Sin(r));
            float y = (1 / r) * (float)(Math.Sin(omega) - Math.Cos(r));
            return new Point(x,y, point.c);
        }
    }

    class Diamond : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            float x = (float)(Math.Sin(omega)*Math.Cos(r));
            float y = (float)(Math.Cos(omega) * Math.Sin(r));
            return new Point(x, y, point.c);
        }
    }

    class Julia : Variation
    {
        Random rand;
        public Julia()
        {
            rand = new Random();
        }
        public override Point flame(Point point)
        {
            
            float pi = this.rand.Next(0, 2) * (float)Math.PI;
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            float x =(float)(Math.Sqrt(r)*Math.Cos(omega/2+pi));
            float y = (float)(Math.Sqrt(r) * Math.Sin(omega / 2 + pi)) ;
            return new Point(x, y, point.c);
        }
    }

    class Exponemtial : Variation
    {
        public override Point flame(Point point)
        {
            float r = (float)Math.Sqrt(point.x * point.x + point.y * point.y);
            double omega = Math.Atan2(point.x, point.y);
            float x = (float)(Math.Exp(point.x-1) * Math.Cos(Math.PI*point.y));
            float y = (float)(Math.Exp(point.x - 1) * Math.Sin(Math.PI * point.y));
            return new Point(x, y, point.c);
        }
    }
}
