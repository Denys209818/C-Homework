using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Trykutnyk : Figura
    {
        int firstLength;
        int secondLength;
        int lastLength;

        public Trykutnyk(int firstLength, int secondLength, int lastLength)
        {
            this.firstLength = firstLength;
            this.secondLength = secondLength;
            this.lastLength = lastLength;
        }
        public override int PFigura()
        {
            return this.firstLength + this.secondLength + this.lastLength;
        }

        public override int SFigura()
        {
            double pp = ((double)(this.firstLength + this.secondLength + this.lastLength))/2;
            double s = Math.Sqrt((double)(pp * (double)(pp - (double)firstLength) * (double)(pp - (double)secondLength) * (double)(pp - (double)lastLength)));
            return (int)s;
        }
    }
}
