using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    public enum PowderType { Capsule = 1, Powder }
    class Powder : Chemie
    {
        int type;
        public Powder(string title, int price) : base(title, price)
        {
            

            int counter = 1;
            ConsoleKeyInfo info;
            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Powder type: ");
                if (counter == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("1. Capsule");
                Console.ResetColor();
                if (counter == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("2. Powder");
                Console.ResetColor();


                info = Console.ReadKey();
                key = info.Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow: { if (counter > 1) { counter--; } break; }
                    case ConsoleKey.DownArrow: { if (counter < 2) { counter++; } break; }

                }

            }
            while (key != ConsoleKey.Enter);

            this.type = counter;

        }
    }
}
