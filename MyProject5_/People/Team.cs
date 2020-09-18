using MyProject5_.Parts;
using System;
using System.Collections.Generic;
using MyProject5_;
using System.Text;


namespace MyProject5_.People
{
    enum Basements { strich, zbirn, stovpch, suc, vareniy };
    enum Doors { sklo, metal, derevo, profil };
    class Team
    {
        TeamLeader tm = null;
        List<Worker> workers = new List<Worker>();


        public Team(TeamLeader tm)
        {
            this.tm = tm;
        }

        public void AddWorker(Worker w) 
        {
            this.workers.Add(w);
        }

        public void RemoveWorker(Worker w)
        {
            this.workers.Remove(w);
        }

        public void ShowWorkers() 
        {
            foreach (var worker in workers)
            {
                worker.ShowData();
            }
        }

        public House BuildHouse(House house = null) 
        {
            string material_ = "";
            string material = "";

            int counter;
            house = house ?? new House();
            if (!house.isTrueBasement()) 
            {
            counter = 1;
            while (true) 
            {
                Console.Clear();
            Console.WriteLine("Виберіть тип фундаменту:");
                if (counter == 1) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Basements.strich+1}. Стрічковий тип");
                Console.ResetColor();
                if (counter == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Basements.zbirn + 1}. Збірний тип");
                Console.ResetColor();

                if (counter == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{((int)Basements.stovpch) + 1}. Стовпчастий тип");
                Console.ResetColor();

                if (counter == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{((int)Basements.suc) + 1}. Суцільний тип");
                Console.ResetColor();

                if (counter == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{((int)Basements.vareniy) + 1}. Варений тип");
                Console.ResetColor();

                ConsoleKeyInfo info = Console.ReadKey();
                ConsoleKey key = info.Key;
                if (key == ConsoleKey.DownArrow && counter <= 5)
                {
                    counter++;
                    counter = counter == 6 ? counter = 1 : counter;
                } else if (key == ConsoleKey.UpArrow && counter >= 1)
                {
                    counter--;
                    counter = counter == 0 ? counter = 5 : counter;
                } else if (key == ConsoleKey.Enter) 
                {
                    break;
                }
            }
            int typeBasement = counter-1;
            material = "";
            switch (typeBasement)
            {
                case 0: { material = "Стрічковий"; break; }
                case 1: { material = "Збірний"; break; }
                case 2:
                    { material = "Стовпчастий"; break; }
                case 3:
                    { material = "Суцільний"; break; }
                case 4:
                    { material = "Варений"; break; }
            }
            tm.typeBasement = typeBasement;
            }
            if (!house.isTrueDoor()) 
            {
            counter = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Виберіть тип дверей:");
                if (counter == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Doors.sklo + 1}. скляні двері");
                Console.ResetColor();
                if (counter == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Doors.metal + 1}. Металічні двері");
                Console.ResetColor();

                if (counter == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Doors.derevo + 1}. Дерев'яні двері");
                Console.ResetColor();

                if (counter == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{(int)Doors.profil + 1}. Профільні двері");
                Console.ResetColor();

                

                ConsoleKeyInfo info = Console.ReadKey();
                ConsoleKey key = info.Key;
                if (key == ConsoleKey.DownArrow && counter <= 4)
                {
                    counter++;
                    counter = counter == 5 ? counter = 1 : counter;
                }
                else if (key == ConsoleKey.UpArrow && counter >= 1)
                {
                    counter--;
                    counter = counter == 0 ? counter = 4 : counter;
                }
                else if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            int typeDoor = counter-1;
            material_ = "";
            switch (typeDoor)
            {
                case 0:{ material_ = "Скло"; break; }
                case 1: { material_ = "Метал"; break; }
                case 2: { material_ = "Дерево"; break; }
                case 3: { material_ = "Профіль"; break; }
            }
            tm.typeDoor = typeDoor;
            }
            ConsoleKeyInfo info_;
            ConsoleKey key_;
            if (!tm.IsBasement()) 
            {
            Console.WriteLine("Продовжити жміть Ентер\nв іншому випадку іншу кнопку");
             info_ = Console.ReadKey();
             key_ = info_.Key;
            if (key_ != ConsoleKey.Enter) 
            {
                return house;
            }

            Basement bs = new Basement(material);
            house.AddBasement(bs);
            tm.ReadyBasement();
            }

            if (!tm.IsWalls()) 
            {
            Console.WriteLine("Продовжити жміть Ентер\nв іншому випадку іншу кнопку");
            info_ = Console.ReadKey();
            key_ = info_.Key;
            if (key_ != ConsoleKey.Enter)
            {
                return house;
            }


            //Add Walls
            Wall w1 = new Wall();
            house.AddWall(w1);
            Wall w2 = new Wall();
            house.AddWall(w2); 
            Wall w3 = new Wall();
            house.AddWall(w3);
            Wall w4 = new Wall();
            house.AddWall(w4);
            tm.ReadyWalls();
            }

            if (!tm.IsDoor()) 
            {
            Console.WriteLine("Продовжити жміть Ентер\nв іншому випадку іншу кнопку");
             info_ = Console.ReadKey();
             key_ = info_.Key;
            if (key_ != ConsoleKey.Enter)
            {
                return house;
            }

            //Add Door
            Door door = new Door(material_);
            house.AddDoor(door);
            tm.ReadyDoor();
            }

            if (!tm.IsWindows()) 
            {
            Console.WriteLine("Продовжити жміть Ентер\nв іншому випадку іншу кнопку");
            info_ = Console.ReadKey();
            key_ = info_.Key;
            if (key_ != ConsoleKey.Enter)
            {
                return house;
            }

            //Add Window
            Window w1_ = new Window();
            house.AddWindow(w1_);
            Window w2_ = new Window();
            house.AddWindow(w2_);
            Window w3_ = new Window();
            house.AddWindow(w3_);
            Window w4_ = new Window();
            house.AddWindow(w4_);
            tm.ReadyWindow();
            }

            if (!tm.IsPart()) 
            {
            Console.WriteLine("Продовжити жміть Ентер\nв іншому випадку іншу кнопку");
            info_ = Console.ReadKey();
            key_ = info_.Key;
            if (key_ != ConsoleKey.Enter)
            {
                return house;
            }

            //Add Part
            Part part = new Part();
            house.AddPart(part);
            tm.ReadyPart();
            }

            

            return house;
        }
    }
}
