using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.Parts
{
    class Basement : IPart
    {
        public string material;

        public Basement(string material)
        {
            this.material = material;
        }
        public void ShowDetail()
        {
            Console.WriteLine("@@@@@@@@@@@@");
            Console.WriteLine("@@@@@@@@@@@@");
        }
    }
}
