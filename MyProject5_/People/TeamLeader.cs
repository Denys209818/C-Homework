using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.People
{
    class TeamLeader : IWorker
    {
        public int typeDoor;

        public int typeBasement;

        private bool isBasement = false;
        private bool isWalls = false;
        private bool isWindow = false;
        private bool isDoor = false;
        private bool isPart = false;
        public string Name { get; set; }
        public int Age { get; set; }

        public string Position { get; set; }

        public TeamLeader(string name, int age)
        {
            Name = name;
            Age = age;
            Position = "Team Leader";
        }
        public void ShowData()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosition: {Position}");
        }

        public void ReadyBasement() 
        {
            this.isBasement = true;
        }

        public void ReadyWalls()
        {
            this.isWalls = true;
        }

        public void ReadyWindow()
        {
            this.isWindow = true;
        }

        public void ReadyDoor()
        {
            this.isDoor = true;
        }

        public void ReadyPart()
        {
            this.isPart = true;
        }

        

      
        public bool  IsBasement()
        {
            return this.isBasement;
        }

        public bool IsWalls() 
        {
            return this.isWalls;
        }

        public bool IsWindows() 
        {
            return this.isWindow;
        }

        public bool IsDoor()
        {
            return this.isDoor;
        }

        public bool IsPart()
        {
           return this.isPart;
        }

        public bool IsHouse()
        {
            if (this.isBasement && this.isDoor && this.isPart && this.isWalls && this.isWindow) 
            {
                return true;
            }
            return false;
        }

        public void ShowZvit() 
        {
            int counter = 0;
            string material = "";
            string material_ = "";
            if (isBasement) 
            {
                switch (typeBasement) 
                {
                    case 0: { material = "Стрічковий"; break; }
                    case 1: { material = "Збірний"; break; }
                    case 2: { material = "Стовпчаковий"; break; }
                    case 3: { material = "Суцільний"; break; }
                    case 4: { material = "Варений"; break; }

                }
                Console.WriteLine($"Фундамент: {material} тип");
                counter++;
            }

            if (isWalls) 
            {
                Console.WriteLine("Стіни збудовано!");
                counter++;
            }

            if (isDoor) 
            {
                switch (typeBasement)
                {
                    case 0: { material_ = "Скло"; break; }
                    case 1: { material_ = "Метал"; break; }
                    case 2: { material_ = "Дерево"; break; }
                    case 3: { material_ = "Профіль"; break; }

                }

                Console.WriteLine($"Двері: метаріал - {material_}") ;
                counter++;
            }

            if (isWindow) 
            {
                Console.WriteLine("Вікна вставлені!");
                counter++;
            }

            if (isPart)
            {
                Console.WriteLine("Дах збудований!");
                counter++;
            }

            Console.WriteLine($"Збудовано: {counter*20}%");
        }
    }
}
