using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class EmbossFilter: ConvolutionFilter
    {
        static double[,] Kernel = new double[,] {
            { -1, 0, 1 },
            { -1, 1, 1 },
            { -1, 0, 1 }
        };

        public EmbossFilter(FastImage image): base(image, Kernel) { }
    }
}
