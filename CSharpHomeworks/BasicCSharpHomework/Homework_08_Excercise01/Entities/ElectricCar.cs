using System;
using System.Collections.Generic;
using System.Text;
using Homework_08_Excercise01.Enums;
using Homework_08_Excercise01.Helpers;

namespace Homework_08_Excercise01.Entities
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; } // %
        public double BatteryLeft { get; set; } //%


        public void Drive(double distance)
        {
            double batteryUsed = distance * (int)Consumption / 10;

            if (batteryUsed > BatteryLeft)
            {
                Console.WriteLine($"You can't drive the car for {distance}km. You can drive it  for {(BatteryLeft * 10) / (int)Consumption}km on full capacity");
            }
            else
            {
                BatteryLeft -= batteryUsed;
                Console.WriteLine($"You drove {distance}km. You have {BatteryUsage.GetBatteryUsagePercentage(BatteryLeft)} battery left");
            }
        }

        public void Recharge(int minutes)
        {
            double batteryCharge = minutes / 10 * BatteryCapacity / 100;
            if (BatteryLeft == BatteryCapacity)
            {
                Console.WriteLine("The battery is full");
            }
            else if (batteryCharge + BatteryLeft > BatteryCapacity)
            {
                Console.WriteLine($"You can't charge longer than {(BatteryCapacity - BatteryLeft) * 10} minutes. Your have {BatteryUsage.GetBatteryUsagePercentage(BatteryLeft)}battery left");
            }
            else
            {
                Console.WriteLine($"You recharged your battery for {BatteryUsage.GetBatteryUsagePercentage(batteryCharge)}");
                BatteryCapacity = batteryCharge + BatteryLeft;
                Console.WriteLine($"Your battery capacity is {BatteryUsage.GetBatteryUsagePercentage(BatteryCapacity)}");
            }


        }
    }
}
