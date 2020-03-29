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
            Image.SetAll(px => (GetChannelValue(px.r, ColorsCount.r), GetChannelValue(px.g, ColorsCount.g), GetChannelValue(px.b, ColorsCount.b)));

            return Image;
        }

        private int GetChannelValue(int org, int k)
        {
            double t = 255 / (k - 1);
            for (double i = t / 2, val = 0; i < 255; i += t, val += t)
            {
                if (org <= i) return (int)val;
            }
            return 255;
        }
    }
}
