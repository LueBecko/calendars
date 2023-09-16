using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarTest;

public partial class RepublicCalendar
{
    private static DayInA24YearCycleFactory {
        public DayInA24YearCycle Create(uint dayNumber) {
            return null;
        }
    }

    private record DayInA24YearCycle(uint DayNumberIn24YearCycle, uint YearIn24YearCycle)
    {
        public DayInAYear DayInYear => DayInAYeaFactory.Create(DayNumberIn24YearCycle);
    }
}
