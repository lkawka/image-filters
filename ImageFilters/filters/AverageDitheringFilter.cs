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

            List<(int r, int g, int b)> pxs = Image.GetAll().ToList();

            var rPoints = GetDividingPoints(pxs.Select(px => px.r).ToList(), ColorsCount.r);
            var gPoints = GetDividingPoints(pxs.Select(px => px.g).ToList(), ColorsCount.g);
            var bPoints = GetDividingPoints(pxs.Select(px => px.b).ToList(), ColorsCount.b);

            Image.SetAll(px => (GetChannelValue(px.r, rPoints), GetChannelValue(px.g, gPoints), GetChannelValue(px.b, bPoints)));

            return Image;
        }

        private int GetChannelValue(int org, List<int> points)
        {
            double val = 0, t = 255 / points.Count;
            for (int i = 0; i < points.Count; i += 1)
            {
                if (org <= points[i])
                    return (int)val;
                val += t;
            }
            return 255;
        }

        private List<int> GetDividingPoints(List<int> values, int k, int start = 0, int end = 255)
        {
            k = 1 << (k - 1);
            List<int> dividingPoints = new List<int>();

            double t = (end - start) / (k - 1);
            for (double val = start; val < end; val += t)
            {
                var pointsInRange = values.Where(v => (v >= val && v < val + t)).ToList();
                if (pointsInRange.Count > 0)
                {
                    dividingPoints.Add((int)pointsInRange.Average());
                }

            }

            return dividingPoints;
        }
    }
}
