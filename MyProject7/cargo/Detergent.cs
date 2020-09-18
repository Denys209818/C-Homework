using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    class Detergent : Chemie
    {
        private int V;
        public Detergent(string title, int price, int V) : base(title, price)
        {
            this.V = V;
        }

        public override int GetPrice() 
        {
            return this.V * this.price;
        }            
    }
}
