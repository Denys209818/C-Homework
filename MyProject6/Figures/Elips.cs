using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Elips : Figura
    {
        int lengthFirst;
        int lengthLast;


        public Elips(int lengthFirst, int lengthLast)
        {
            this.lengthFirst = lengthFirst;
            this.lengthLast = lengthLast;
        }
        public override int PFigura()
        {
            return (4 * (int)(3.14 * lengthFirst * lengthLast) + (lengthLast - lengthFirst)) / (lengthFirst + lengthLast);
        }

        public override int SFigura()
        {
            return (int)((double)this.lengthLast * (double)lengthFirst * 3.14);
        }
    }
}
