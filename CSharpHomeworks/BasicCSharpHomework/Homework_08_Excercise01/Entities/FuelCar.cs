using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08_Excercise01.Entities
{
    public class FuelCar : Car
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public void Drive(int distance)
        {
            double fuelUsed = (distance * (double)Consumption) / 10;
            if (fuelUsed > CurrentFuel)
            {
                Console.WriteLine($"You can't drive the car for {distance}km. With it's full tank capacity, You can drive it  for maximum of {(CurrentFuel * 10)/ (double)Consumption}km with full tank");
                
            }
            else
            {
                CurrentFuel -= fuelUsed;
                Console.WriteLine($"You drove your car for {distance}km. It has {CurrentFuel} liters left.");

            }
        }

        public void Refuel(double fuel)
        {
            if (FuelCapacity == CurrentFuel)
            {
                Console.WriteLine("Your car tank is full.");
            }
            else if (fuel + CurrentFuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity - CurrentFuel} litres.");
            }
            else
            {
                Console.WriteLine($"You refueld {fuel} liters.");
                FuelCapacity = fuel + CurrentFuel;
                Console.WriteLine($"Your car tank capacity is {FuelCapacity} liters");
            }

        }
    }
}
