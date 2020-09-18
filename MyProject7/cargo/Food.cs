using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    abstract class Food
    {
        public string title;
        protected int m;
        protected int priceKg;

        public Food(string title, int m, int priceKg)
        {
            this.title = title;
            this.m = m;
            this.priceKg = priceKg;
        }

        public virtual int GetPrice() 
        {
            return this.m * this.priceKg;
        }
    }
}
