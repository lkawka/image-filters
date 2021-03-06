﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class BrightnessCorrectionFilter : Filter
    {
        const int CorrectionVal = 30;

        public BrightnessCorrectionFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            Image.SetAll(x => Math.Min(255, x + CorrectionVal));

            return Image;
         }
    }
}
