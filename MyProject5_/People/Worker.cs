using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject5_.People
{
    class Worker : IWorker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Position { get; set; }

        public Worker(string name, int age)
        {
            Name = name;
            Age = age;
            Position = "Worker";
        }
        public void ShowData() 
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nPosition: {Position}");
        }


    }
}
