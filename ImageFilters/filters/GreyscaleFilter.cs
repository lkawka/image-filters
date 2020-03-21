using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class GreyscaleFilter : Filter
    {
        public GreyscaleFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            Image.SetAll(rgb => (ToGrayscale(rgb.r, rgb.g, rgb.b), ToGrayscale(rgb.r, rgb.g, rgb.b), ToGrayscale(rgb.r, rgb.g, rgb.b)));
            return Image;
        }

        private int ToGrayscale(int r, int g, int b)
        {
            return (int)(0.3 * r + 0.6 * g + 0.1 * b);
        }
    }
}
