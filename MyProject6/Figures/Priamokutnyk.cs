using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Priamokutnyk : Figura
    {

        int topBottomLength;
        int leftRightLength;

        public Priamokutnyk(int topBottom, int leftRight)
        {
            this.topBottomLength = topBottom;
            this.leftRightLength = leftRight;
        }
        public override int PFigura()
        {
            return (this.topBottomLength + this.leftRightLength) * 2;
        }

        public override int SFigura()
        {
            return this.topBottomLength * this.leftRightLength;
        }
    }
}
