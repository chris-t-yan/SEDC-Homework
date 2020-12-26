using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_07_Excercise01.Helpers
{
    class SSNGenerator
    {
        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
