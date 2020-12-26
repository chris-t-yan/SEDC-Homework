using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08_Excercise01.Helpers
{
    public class BatteryUsage
    {
        public static string GetBatteryUsagePercentage(double batteryUsage)
        {
            string percentBatteryUsage = string.Format($"{batteryUsage / 100:P}");
            return percentBatteryUsage;
        }
    }
}
