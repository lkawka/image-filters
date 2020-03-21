using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class ContrastEnhancementFilter : Filter
    {
        const int Val = 30;

        public ContrastEnhancementFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            Image.SetAll(x => Func(x));
            return Image;
        }

        private int Func(int n)
        {
            if (n <= Val)
            {
                return 0;
            }

            if (n >= 255 - Val)
            {
                return 255;
            }

            return (255 * n) / (255 - 2 * Val) - ((255 * Val) / (255 - 2 * Val));
        }
    }
}
