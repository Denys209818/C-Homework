using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Paralelogram : Figura
    {
        int topBottomLength;
        int leftRightLength;
        int height;

        public Paralelogram(int topBottom, int leftRight, int height)
        {
            this.topBottomLength = topBottom;
            this.leftRightLength = leftRight;
            this.height = height;
        }
        public override int PFigura()
        {
            return (this.leftRightLength + this.topBottomLength) * 2;
        }

        public override int SFigura()
        {
            return this.topBottomLength * height;
        }
    }
}
