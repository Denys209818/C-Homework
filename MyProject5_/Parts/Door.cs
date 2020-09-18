using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.Parts
{
    class Door : IPart
    {
        public string material;

        public Door(string material)
        {
            this.material = material;
        }
        public void ShowDetail()
        {
            Console.WriteLine("@@");
            Console.WriteLine("@@");
        }
    }
}
