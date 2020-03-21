using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class AverageDitheringFilter : Filter
    {

        public AverageDitheringFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            var avg = GetAverages();

            Image.SetAll(px => ((px.r < avg.r ? 0 : 255), (px.g < avg.g ? 0 : 255), (px.b < avg.b ? 0 : 255)));

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
    }
}
