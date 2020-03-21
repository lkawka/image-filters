using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class SharpenFilter : ConvolutionFilter
    {
        const int a = 1;
        const int b = 5;
        const int s = b - 4 * a;

        static double[,] Kernel = new double[3, 3] {
            { 0, -a/s, 0 },
            { -a/s, b/s, -a/s },
            { 0, -a/s, 0 }
        };

        public SharpenFilter(FastImage image) : base(image, Kernel) { }
    }
}
