using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class GaussianBlurFilter : ConvolutionFilter
    {
        static double[,] Kernel = new double[3, 3] {
            { 0, 1, 0 },
            { 1, 4, 1 },
            { 0, 1, 0 }
        };

        public GaussianBlurFilter(FastImage image) : base(image, Kernel)
        {

        }
    }
}
