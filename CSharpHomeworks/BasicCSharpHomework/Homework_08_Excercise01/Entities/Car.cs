using System;
using System.Collections.Generic;
using System.Text;
using Homework_08_Excercise01.Enums;

namespace Homework_08_Excercise01.Entities
{
    public class Car
    {
        public int ID = new Random().Next(1, 99);
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption;
        public EngineType EngineType;

        public void PrintInfo ()
        {
            Console.WriteLine($"The car from the brand {Brand}, model {Model} with ID {ID}, has {Doors} doors, {EngineType} engine with consumption of {Consumption} and the top speed is {TopSpeed} km/h");
        }
    }
}
