using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class TimeCalculator
    {
        public DateTime FindTime(double zone) //AddHours, SubHours
        {
            DateTime value = new DateTime(2000, 1, 1, 0, 0, 0);
            return value.AddHours(zone);
        }
        public DateTime FindTimeDay(double zone) //AddDays, SubDays
        {
            DateTime value = new DateTime(2000, 1, 1, 0, 0, 0);
            return value.AddDays(zone);
        }
        public string FindMinutesFromInput(DateTime time) //Returns Minutes
        {
            return time.Minute.ToString();
        }
    }
}
