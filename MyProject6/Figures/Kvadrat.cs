using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Kvadrat  : Figura
    {

        int storonaLength;

        public Kvadrat(int storonaLength)
        {
            this.storonaLength = storonaLength;
        }
        public override int PFigura()
        {
            return this.storonaLength * 4;
        }

        public override int SFigura()
        {
            return this.storonaLength * this.storonaLength;
        }
    }
}
