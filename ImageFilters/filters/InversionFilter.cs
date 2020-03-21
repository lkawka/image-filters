using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    public class InversionFilter : Filter
    {
        public InversionFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            Image.SetAll(x => 255 - x);
            return new FastImage(Image);
        }
    }
}
