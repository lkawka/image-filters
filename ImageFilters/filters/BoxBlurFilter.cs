﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class BoxBlurFilter : ConvolutionFilter
    {
        static double[,] Kernel = new double[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

        public BoxBlurFilter(FastImage image) : base(image, Kernel) { }

    }
}
