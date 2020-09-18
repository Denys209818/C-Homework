using MyProject5_.Parts;
using MyProject5_.People;
using System;
using System.Text;

namespace MyProject5_
{
    class Program
    {
        static void Main()
        {
            int id = 1;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            TeamLeader teamLeader = new TeamLeader("Team Leader", 20);

            Worker w1 = new Worker("Worker1", 20);
            Worker w2 = new Worker("Worker2", 21);
            Worker w3 = new Worker("Worker3", 22);
            Worker w4 = new Worker("Worker4", 23);

            Team team = new Team(teamLeader);

            team.AddWorker(w1);
            team.AddWorker(w2);
            team.AddWorker(w3);
            team.AddWorker(w4);

            House house = null;
            int counter = 1;
            while (!teamLeader.IsHouse()) 
            {
                ConsoleKey ch = ConsoleKey.Escape;
                do
                {
                    Console.Clear();
                    if (counter == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("1. Будувати будинок");
                    Console.ResetColor();
                    if (counter == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("2. Сформувати звіт");
                    Console.ResetColor();

                    if (counter == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("3. Вийти");
                    Console.ResetColor();

                    ConsoleKeyInfo info = Console.ReadKey();
                    ch = info.Key;

                    if (ch == ConsoleKey.UpArrow)
                    {
                        counter--;
                        if (counter == 0)
                        {
                            counter = 3;
                        }
                    } else if (ch == ConsoleKey.DownArrow) 
                    {
                        counter++;
                        if (counter == 4)
                        {
                            counter = 1;
                        }
                    }

                } while (ch != ConsoleKey.Enter);
                Console.Clear();
                switch (counter) 
                {
                    case 1: 
                        {
                            if (id == 1)
                            {
                                house = team.BuildHouse();
                            }
                            else 
                            {
                                house = team.BuildHouse(house);
                            }
                                id++;
                            break; 
                        }
                    case 2: 
                        {
                            teamLeader.ShowZvit();
                            Console.ReadKey();
                            break; 
                        }
                    case 3: 
                        {

                            if (teamLeader.IsHouse())
                            {
                                house.ShowHouse();
                            }
                            return; 
                        }

                }

                
            }


            if (teamLeader.IsHouse())
            {
                Console.Clear();
                house.ShowHouse();
            }

        }
    }
}
