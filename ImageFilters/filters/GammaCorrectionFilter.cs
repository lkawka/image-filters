using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class GammaCorrectionFilter : Filter
    {
        private const double Gamma = 2.2;

        public GammaCorrectionFilter(FastImage image) : base(image) { }

        public override FastImage Apply()
        {
            Image.SetAll(x => Func(x));

            return Image;
        }

        private int Func(int n)
        {
            return (int)(Math.Pow((double)n / 255, 1 / Gamma) * 255);
        }
    }
}
