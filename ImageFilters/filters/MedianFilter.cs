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
                    List<(int r, int g, int b)> pixels = new List<(int r, int g, int b)>();
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

                    pixels = pixels.OrderBy(p => (0.3 * p.r + 0.6 * p.g + 0.1 * p.b)).ToList();

                    if (pixels.Count % 2 == 0)
                    {
                        var p1 = pixels[pixels.Count / 2 - 1];
                        var p2 = pixels[pixels.Count / 2];
                        Image.SetPixel(x, y, (p1.r + p2.r) / 2, (p1.g + p2.g) / 2, (p1.b + p2.b) / 2);
                    }
                    else
                    {
                        var p = pixels[pixels.Count / 2];
                        Image.SetPixel(x, y, p.r, p.g, p.b);
                    }
                }
            }
            return Image;
        }
    }
}
