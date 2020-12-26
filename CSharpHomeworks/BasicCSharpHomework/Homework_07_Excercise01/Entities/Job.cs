using System;
using System.Collections.Generic;
using System.Text;
using Homework_07_Excercise01.Enums;

namespace Homework_07_Excercise01.Entities
{
    public class Job
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }
}
