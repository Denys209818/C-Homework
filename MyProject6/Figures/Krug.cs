using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Krug : Figura
    {
        int radius;
        public Krug(int radius)
        {
            this.radius = radius;
        }
        public override int PFigura()
        {
            return (int)(2 * 3.14 * (double)this.radius);
        }

        public override int SFigura()
        {
            return (int)(3.14 * (double)(this.radius * this.radius));
        }
    }
}
