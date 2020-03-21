using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    abstract public class ConvolutionFilter : Filter
    {
        double[,] Kernel;
        int Offset;

        public ConvolutionFilter(FastImage image, double[,] kernel, int offset = 0) : base(image)
        {
            Kernel = kernel;
            Offset = offset;
        }

        override public FastImage Apply()
        {
            FastImage org = new FastImage(Image);
            int n = Kernel.GetLength(0);
            double kernelSum = Kernel.Cast<double>().Sum();

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    double r = 0, g = 0, b = 0;
                    for (int kernelY = -n / 2, j = 0; kernelY <= n / 2; kernelY++, j++)
                        for (int kernelX = -n / 2, i = 0; kernelX <= n / 2; kernelX++, i++)
                        {
                            int sourceX = x + kernelX;
                            int sourceY = y + kernelY;

                            if (sourceX < 0)
                                sourceX = 0;

                            if (sourceX >= Image.Width)
                                sourceX = Image.Width - 1;

                            if (sourceY < 0)
                                sourceY = 0;

                            if (sourceY >= Image.Height)
                                sourceY = Image.Height - 1;

                            (int r1, int g1, int b1) = org.GetPixel(sourceX, sourceY);
                            r += r1 * Kernel[i, j];
                            g += g1 * Kernel[i, j];
                            b += b1 * Kernel[i, j];
                        }

                    if (kernelSum == 0) kernelSum = 1;
                    r /= kernelSum;
                    g /= kernelSum;
                    b /= kernelSum;

                    r += Offset;
                    g += Offset;
                    b += Offset;

                    r = Math.Max(0, Math.Min(r, 255));
                    g = Math.Max(0, Math.Min(g, 255));
                    b = Math.Max(0, Math.Min(b, 255));

                    Image.SetPixel(x, y, (int)r, (int)g, (int)b);
                }
            }
            return Image;
        }

    }
}


