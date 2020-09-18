using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    class Cart
    {
       public int status = 1;

       public List<Chemie> chemies = new List<Chemie>();
       public List<Food> food = new List<Food>();

        public void AddToCartFood(Food f) 
        {
            this.food.Add(f);
        }

        public void RemoveFromCartFood(Food f)
        {
            this.food.Remove(f);
        }

        public void AddToCartChemie(Chemie c)
        {
            this.chemies.Add(c);
        }

        public void RemoveFromCartChemie(Chemie c)
        {
            this.chemies.Remove(c);
        }
    }
}
