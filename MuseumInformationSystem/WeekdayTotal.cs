using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumInformationSystem
{
    class WeekdayTotal
    {
        public String Weekday { get; set; }
        public int TotalVisitors { get; set; }

        public WeekdayTotal() { }

        public WeekdayTotal(String weekday, int totalVisitors)
        {
            Weekday = weekday;
            TotalVisitors = totalVisitors;
        }
    }
}
