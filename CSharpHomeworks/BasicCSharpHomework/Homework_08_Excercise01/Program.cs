using System;
using Homework_08_Excercise01.Entities;
using Homework_08_Excercise01.Enums;


namespace Homework_08_Excercise01
    
{
    class Program
    {
        static void Main(string[] args)

        {
            var electricCar = new ElectricCar()
            {
                EngineType = EngineType.Electric,
                BatteryCapacity = 100,
                Consumption = Consumption.Economic,
                BatteryLeft = 100,
                Brand = "Tesla",
                Model = "Model 3",
                Doors = 5,
                TopSpeed = 210
            };
            Console.WriteLine("Electric Car");

            electricCar.PrintInfo();
            electricCar.Drive(617);
            electricCar.Drive(1050);//test for incorrect values
            Console.WriteLine("");
            electricCar.Recharge(337);
            electricCar.Recharge(913); //test for incorrect values

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            var fuelCar = new FuelCar()
            {
                EngineType = EngineType.Diesel,
                FuelCapacity = 60,
                Consumption = Consumption.Medium,
                CurrentFuel = 50,
                Brand = "Volkswagen",
                Model = "Golf VII",
                Doors = 5,
                TopSpeed = 250,
            };
            Console.WriteLine("Fuel Car");

            fuelCar.PrintInfo();
            fuelCar.Drive(117);
            fuelCar.Drive(365);//test for incorrect values
            Console.WriteLine("");
            fuelCar.Refuel(12);
            fuelCar.Refuel(48);//test for incorrect values

            Console.ReadLine();
        }
    }
}
