using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectResolvidoUdemy.Entities
{
    class HourContract
    {

        public DateTime DateContract { get; set; }
        public double ValueHour { get; set; }
        public int Hour { get; set; }

        public HourContract(DateTime dateContract, double valueHour, int hour)
        {
            DateContract = dateContract;
            ValueHour = valueHour;
            Hour = hour;
        }

        public HourContract()
        {
        }

        public double totalValue()
        {
            return ValueHour * Hour;

        }
    }
}
