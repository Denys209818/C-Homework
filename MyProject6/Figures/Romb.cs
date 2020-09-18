using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Romb : Figura
    {
        int storonaLength;
        int height;

        public Romb(int storonaLength, int height)
        {
            this.storonaLength = storonaLength;
            this.height = height;
        }
        public override int PFigura()
        {
            return this.storonaLength * 4;
        }

        public override int SFigura()
        {
            return this.height * this.storonaLength;
        }
    }
}
