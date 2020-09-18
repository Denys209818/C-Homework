using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.Parts
{
    class House
    {
        static public int counterWalls = 0;
        static public int counterWindow = 0;

        private int ind = 1;
        private IPart[] parts = new IPart[11];

        public void AddBasement(Basement basement) 
        {
            if (parts[10] == null)
            {
                parts[10] = basement;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Фундамент уже готовий!");
            }
        }

        public void AddWindow(Window w) 
        {
            if (parts[10] == null)
            {
                Console.WriteLine("Збудуйте фундамент!");
                return;
            }
            for (int i = 4; i > 0; i--)
            {
                if (parts[i] == null)
                {
                    Console.WriteLine("Збудуйте всі стіни!");
                    return;
                }
            }
            for (int i = 9; i > 5; i--) 
            {
                if (parts[i] == null) 
                {
                    parts[i] = w;
                    return;
                }
            }

            Console.WriteLine("Вікна уже готові!");
        }

        public void AddDoor(Door d) 
        {
            if (parts[10] == null) 
            {
                Console.WriteLine("Збудуйте фундамент!");
                return;
            }
            for (int i = 4;i > 0; i--) 
            {
                if (parts[i] == null) 
                {
                    Console.WriteLine("Збудуйте всі стіни!");
                    return;
                }
            }
            if (parts[5] == null)
            {
                parts[5] = d;
            }
            else 
            {
                Console.WriteLine("Двері вже вставлені!");
            }
        }

        public void AddWall(Wall w) 
        {
            if (parts[10] == null) 
            {
                Console.WriteLine("Збудуйте фундамент!");
                return;
            }
            for (int i = 4; i > 0; i--)
            {
                if (parts[i] == null)
                {
                    parts[i] = w;
                    return;
                }
            }
            Console.WriteLine("Стіни побудовані!");

        }

        public void AddPart(Part p) 
        {
            if (parts[10] == null) 
            {
                Console.WriteLine("Зробіть фундамент!");
                return;
            }
            for (int i = 4; i > 0; i--) 
            {
                if (parts[i] == null) 
                {
                    Console.WriteLine("Не всі стіни збудовані!");
                }
            }
            if (parts[0] != null) 
            {
                Console.WriteLine("Криша вже побудована!");
            }
            parts[0] = p;
        }
        public void ShowHouse() 
        {
            for (int i = 0; i < parts.Length; i++) 
            {
                if (parts[i] != null)
                {
                    (parts[i] as Part)?.ShowDetail();
                    (parts[i] as Wall)?.ShowDetail();
                    (parts[i] as Basement)?.ShowDetail();
                    if (parts[i] is Wall) 
                    {
                        i += 4;
                    }
                   // Console.WriteLine("OK");
                }              
            }
        }

        public bool isTrueBasement() 
        {
            if (parts[10] == null) 
            {
                return false;
            }
            return true;
        }

        public bool isTrueDoor()
        {
            if (parts[5] == null)
            {
                return false;
            }
            return true;
        }
    }
}
