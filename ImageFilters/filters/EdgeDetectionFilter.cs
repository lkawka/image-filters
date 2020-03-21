using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class EdgeDetectionFilter : ConvolutionFilter
    {
        const int Offset = 100;

        static double[,] Kernel = new double[,] {
            { 0, -1, 0 },
            { 0, 1, 0 },
            { 0, 0, 0 }
        };

        public EdgeDetectionFilter(FastImage image) : base(image, Kernel, Offset) { }
    }
}
