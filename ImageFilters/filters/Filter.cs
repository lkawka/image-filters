using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    abstract public class Filter
    {
        protected FastImage Image;

        protected Filter(FastImage image)
        {
            Image = image;
        }

        abstract public FastImage Apply();
    }
}
