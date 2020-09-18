using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.Parts
{
    class Part : IPart
    {
        public void ShowDetail()
        {
            Console.WriteLine("    @@@@     ");
            Console.WriteLine("  @@    @@   ");
            Console.WriteLine(" @@      @@  ");
            Console.WriteLine("@@@@@@@@@@@@");
        }
    }
}
