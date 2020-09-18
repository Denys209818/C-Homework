using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    class Chemie
    {
        public string title;
        protected int price;

       

        public Chemie(string title, int price)
        {
            this.title = title;
            this.price = price;
        }

        public virtual int GetPrice() 
        {
            return this.price;
        }
    }
}
