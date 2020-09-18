using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class Trapecia : Figura
    {
        int topOsnova;
        int bottomOsnova;
        int left;
        int right;
        int height;

        public Trapecia(int topOsnova, int bottomOsnova, int left, int right, int height)
        {
            this.topOsnova = topOsnova;
            this.bottomOsnova = bottomOsnova;
            this.left = left;
            this.right = right;
            this.height = height;
        }
        public override int PFigura()
        {
            return this.right + this.left + this.topOsnova + this.bottomOsnova;
        }

        public override int SFigura()
        {
            return ((this.topOsnova + this.bottomOsnova) / 2) * this.height;
        }
    }
}
