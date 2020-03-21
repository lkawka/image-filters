using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class MedianFilter : Filter
    {
        public MedianFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            FastImage org = new FastImage(Image);

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    List<(int, int, int)> pixels = new List<(int, int, int)>();
                    if (x > 0 && y > 0)
                        pixels.Add(org.GetPixel(x - 1, y - 1));
                    if (x > 0)
                        pixels.Add(org.GetPixel(x - 1, y));
                    if (x > 0 && y < Image.Height - 1)
                        pixels.Add(org.GetPixel(x - 1, y + 1));
                    if (y > 0)
                        pixels.Add(org.GetPixel(x, y - 1));
                    if (y < Image.Height - 1)
                        pixels.Add(org.GetPixel(x, y + 1));
                    if (x < Image.Width - 1 && y > 0)
                        pixels.Add(org.GetPixel(x + 1, y - 1));
                    if (x < Image.Width - 1)
                        pixels.Add(org.GetPixel(x + 1, y));
                    if (x < Image.Width - 1 && y < Image.Height - 1)
                        pixels.Add(org.GetPixel(x + 1, y + 1));

                    pixels = pixels.OrderBy(p => (0.3 * p.Item1 + 0.6 * p.Item2 + 0.1 * p.Item3)).ToList();

                    if (pixels.Count % 2 == 0)
                    {
                        var p1 = pixels[pixels.Count / 2 - 1];
                        var p2 = pixels[pixels.Count / 2];
                        Image.SetPixel(x, y, (p1.Item1 + p2.Item1) / 2, (p1.Item2 + p2.Item2) / 2, (p1.Item3 + p2.Item3) / 2);
                    }
                    else
                    {
                        var p = pixels[pixels.Count / 2];
                        Image.SetPixel(x, y, p.Item1, p.Item1, p.Item3);
                    }
                }
            }
            return Image;
        }
    }
}
