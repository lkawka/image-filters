using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class AverageDitheringYCbCrFilter : Filter
    {
        (int Y, int Cb, int Cr) ColorsCount;

        public AverageDitheringYCbCrFilter(FastImage image, int yColors = 2, int cbColors = 2, int crColors = 2) : base(image)
        {
            ColorsCount = (yColors, cbColors, crColors);
        }

        public override FastImage Apply()
        {
            List<(int Y, int Cb, int Cr)> pxs = Image.GetAll().Select(px => ConvertToYCbCr(px)).ToList();

            List<int> yPoints = GetDividingPoints(pxs.Select(px => px.Y).ToList(), ColorsCount.Y);
            List<int> cbPoints = GetDividingPoints(pxs.Select(px => px.Cb).ToList(), ColorsCount.Cb);
            List<int> crPoints = GetDividingPoints(pxs.Select(px => px.Cr).ToList(), ColorsCount.Cr);

            Image.SetAll(px => ApplyDithering(px, yPoints, cbPoints, crPoints));

            return Image;
        }

        private (int r, int g, int b) ApplyDithering((int r, int g, int b) px, List<int> yPoints, List<int> cbPoints, List<int> crPoints)
        {
            var convertedPx = ConvertToYCbCr(px);
            int y = GetChannelValue(convertedPx.Y, yPoints, 16, 235);
            int cb = GetChannelValue(convertedPx.Cb, cbPoints, 16, 240);
            int cr = GetChannelValue(convertedPx.Cr, crPoints, 16, 240);
            return ConvertToRgb((y, cb, cr));
        }

        private (int Y, int Cb, int Cr) ConvertToYCbCr((int r, int g, int b) px)
        {
            int Y = Clip((int)(16 + (65.738 * px.r + 129.057 * px.g + 25.064 * px.b) / 256), 16, 235);
            int Cb = Clip((int)(128 + (-37.945 * px.r - 74.494 * px.g + 112.439 * px.b) / 256), 16, 240);
            int Cr = Clip((int)(128 + (112.439 * px.r - 94.154 * px.g - 18.285 * px.b) / 256), 16, 240);

            return (Y, Cb, Cr);
        }

        private (int r, int g, int b) ConvertToRgb((int Y, int Cb, int Cr) px)
        {
            int r = Clip((int)(((298.082 * px.Y + 408.583 * px.Cr) / 256) - 222.921));
            int g = Clip((int)((298.082 * px.Y - 100.291F * px.Cb - 208.120 * px.Cr) / 256 + 135.576));
            int b = Clip((int)((298.082 * px.Y + 516.412 * px.Cb) / 256 - 276.836));

            return (r, g, b);
        }

        private int GetChannelValue(int org, List<int> points, int start = 0, int end = 255)
        {
            double val = start, t = (start-end) / points.Count;
            for (int i = 0; i < points.Count; i += 1)
            {
                if (org <= points[i])
                    return (int)val;
                val += t;
            }
            return end;
        }

        private List<int> GetDividingPoints(List<int> values, int k)
        {
            var points = new List<int>();
            if (k == 1 || values.Count < 2)
                return points;

            int average = (int)values.Average();

            points.AddRange(GetDividingPoints(values.Where(v => v <= average).ToList(), k - 1));
            points.Add(average);
            points.AddRange(GetDividingPoints(values.Where(v => v > average).ToList(), k - 1));

            return points;
        }

        private int Clip(int val, int min = 0, int max = 255)
        {
            return Math.Max(min, Math.Min(max, val));
        }
    }
}
