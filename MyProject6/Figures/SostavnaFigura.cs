using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject6.Figures
{
    class SostavnaFigura
    {
       private List<Figura> figures = new List<Figura>();

        public void AddFigura(Figura f) 
        {
            figures.Add(f);
        }

        public void RemoveFigura(Figura f)
        {
            figures.Remove(f);
        }

        public int GetS() 
        {
            int a = 0;
            foreach (var figura in figures) 
            {
               a += figura.SFigura();
            }
            return a;
        }
    }
}
