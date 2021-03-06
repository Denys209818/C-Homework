﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7.cargo
{
    public enum TypeFruit { Dried = 1, Fresh }
    class Fruits : Food
    {
        private int type;
        public Fruits(string title, int m, int priceKg) : base(title, m, priceKg)
        {
            int counter = 1;
            ConsoleKeyInfo info;
            ConsoleKey key;
            do
            {
                Console.Clear();

                Console.WriteLine("Enter fish: ");
                if (counter == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("1. Dried");
                Console.ResetColor();
                if (counter == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("2. Fresh");
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

        public override int GetPrice()
        {
            return this.m * this.priceKg * this.type;
        }

    }
}
