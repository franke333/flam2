using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace flam2
{
    class Flame
    {
        public int palleteIndex=0;
        public int width, height;
        public float centerX=0, centerY=0; //from -1 to 1 (0 = middle)
        public int scale=50;
        //public float zoom;
        public int oversample=2;
        public int quality=10;
        public Color bgColor= Color.Black;
        public float gamma = 2.2f;

        public Function[] funcs;
        public float[] weights;

        private float weightSum;
        private Bitmap bmp;

        private int chooseFuncIndex(float weight)
        {
            float sum = 0;
            for (int i = 0; i < funcs.Length; i++)
            {
                sum += weights[i];
                if (weight <= sum) return i;
            }
            return funcs.Length - 1;
        }

        private Tuple<int,int> whereInPixels(Point pos)
        {
            float x = pos.x;
            float y = pos.y;

            //scale units to pixels
            x *= scale * oversample;
            y *= scale * oversample;

            //centralize
            x += (centerX + 1) * width * oversample / 2;
            y += (centerY + 1) * height * oversample / 2;

            if (x < 0 || y < 0 || x >= width * oversample || y >= height * oversample) return null; // outOfRange
            return new Tuple<int, int>((int)x, (int)y);
        }

        public Bitmap Run(Form1 form)
        {
            UInt32[,] r = new UInt32[width * oversample, height * oversample];
            UInt32[,] g = new UInt32[width * oversample, height * oversample];
            UInt32[,] b = new UInt32[width * oversample, height * oversample];
            UInt32[,] v = new UInt32[width * oversample, height * oversample]; //so much wasted memory :(

            weightSum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                weightSum += weights[i];
            }

            Random rand = new Random();
            Point postion = new Point((float)(rand.NextDouble()*2-1), (float)(rand.NextDouble() * 2 - 1),Color.White);
            ulong iters = (ulong)width * (ulong)oversample * (ulong)height * (ulong)oversample * (ulong)quality;
            form.setProgress((int)(iters/1000));
            for (ulong i = 0; i < iters; i++)
            {
                if (i % 1000==0)
                {
                    form.updateProgress();
                }
                int currFunc = chooseFuncIndex((float)rand.NextDouble() * weightSum);
                Point help = postion;
                postion = funcs[currFunc].Apply(postion);
                if (i > 20)
                {
                    Tuple<int, int> pixPos = whereInPixels(postion);
                    if (pixPos != null) //add counter for missed ticks later
                    {
                        r[pixPos.Item1, pixPos.Item2] += postion.c.R;
                        g[pixPos.Item1, pixPos.Item2] += postion.c.G;
                        b[pixPos.Item1, pixPos.Item2] += postion.c.B;
                        v[pixPos.Item1, pixPos.Item2] += 1;
                    }
                }
            }

            //find max log-density
            float maxV=0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    UInt32 currV = 0;
                    for (int sx = 0; sx < oversample; sx++)
                    {
                        for (int sy = 0; sy < oversample; sy++)
                        {
                            currV += v[x * oversample + sx, y * oversample + sy];
                        }
                    }
                    maxV = (float)Math.Max(maxV, Math.Log10(currV/(oversample*oversample)));
                }
            }

            //create bitmap + set background
            bmp = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bmp.SetPixel(x, y, bgColor);
                }
            }

            //draw
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int R = 0, G = 0, B = 0;
                    UInt32 V =0;
                    for (int i = 0; i < oversample; i++)
                    {
                        for (int j = 0; j < oversample; j++)
                        {
                            if (v[x * oversample + i, y * oversample + j] != 0)
                            {
                                r[x * oversample + i, y * oversample + j] /= v[x * oversample + i, y * oversample + j];
                                g[x * oversample + i, y * oversample + j] /= v[x * oversample + i, y * oversample + j];
                                b[x * oversample + i, y * oversample + j] /= v[x * oversample + i, y * oversample + j];

                                R += (int)r[x * oversample + i, y * oversample + j];
                                G += (int)g[x * oversample + i, y * oversample + j];
                                B += (int)b[x * oversample + i, y * oversample + j];
                                V += v[x * oversample + i, y * oversample + j];
                            }
                        }
                    }
                    R /= (oversample * oversample);
                    G /= (oversample * oversample);
                    B /= (oversample * oversample);
                    V /= (UInt32)(oversample * oversample);

                    //Currently goes only towards black BG!!!
                    int finalR = (int)(R * (Math.Log10(V) / maxV));
                    int finalG = (int)(G * (Math.Log10(V) / maxV));
                    int finalB = (int)(B * (Math.Log10(V) / maxV));

                    //Apply Gamma
                    finalR = (int)(255 * Math.Pow(finalR / 255f, 1 / gamma));
                    finalG = (int)(255 * Math.Pow(finalG / 255f, 1 / gamma));
                    finalB = (int)(255 * Math.Pow(finalB / 255f, 1 / gamma));

                    if (V>0) bmp.SetPixel(x,y,Color.FromArgb(finalR,finalG,finalB));
                }
            }

            return bmp;
        }

        
    }
}
