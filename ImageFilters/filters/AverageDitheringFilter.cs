using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class AverageDitheringFilter : Filter
    {

        (int r, int g, int b) ColorsCount;

        public AverageDitheringFilter(FastImage image, int rColors = 2, int gColors = 2, int bColors = 2) : base(image)
        {
            ColorsCount = (rColors, gColors, bColors);
        }

        public override FastImage Apply()
        {
            var avg = GetAverages();

            Image.SetAll(px => (GetChannelValue(px.r, avg.r, ColorsCount.r), GetChannelValue(px.g, avg.g, ColorsCount.g), GetChannelValue(px.b, avg.b, ColorsCount.b)));

            return Image;
        }

        private (int r, int g, int b) GetAverages()
        {
            (int r, int g, int b) avg = (0, 0, 0);

            foreach (var (r, g, b) in Image.GetAll())
            {
                avg.r += r;
                avg.g += g;
                avg.b += b;
            }

            int pxCount = Image.Width * Image.Width;
            avg.r /= pxCount;
            avg.b /= pxCount;
            avg.g /= pxCount;

            return avg;
        }

        private int GetChannelValue(int org, int avg, int k)
        {
            double t = 255 / (k-1);
            for (double i = t / 2, val = 0; i < 255; i += t, val += t)
            {
                if (org <= i) return (int)val;
            }
            return 255;
        }
    }
}
