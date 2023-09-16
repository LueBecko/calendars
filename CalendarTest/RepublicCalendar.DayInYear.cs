using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarTest;

public partial class RepublicCalendar
{
    private interface DayInAYear
    {
        uint DayInYear { get; }
        uint Month { get; }
    }

    private static class DayInAYearFactory {
        public static DayInAYear Create(uint dayNumber) {

            uint dayIn24YearCycle = ((dayNumber - 1) % 8766) + 1;

            uint dayInYear = dayIn24YearCycle switch
            {
                > 8411 => dayIn24YearCycle - 8411,
                > 8056 => dayIn24YearCycle - 8056,
                > 7679 => dayIn24YearCycle - 7679,
                > 7324 => dayIn24YearCycle - 7324,
                > 6947 => dayIn24YearCycle - 6947,
                > 6592 => dayIn24YearCycle - 6592,
                > 6215 => dayIn24YearCycle - 6215,
                > 5860 => dayIn24YearCycle - 5860,
                > 5482 => dayIn24YearCycle - 5482,
                > 5127 => dayIn24YearCycle - 5127,
                > 4750 => dayIn24YearCycle - 4750,
                > 4395 => dayIn24YearCycle - 4395,
                > 4017 => dayIn24YearCycle - 4017,
                > 3662 => dayIn24YearCycle - 3662,
                > 3285 => dayIn24YearCycle - 3285,
                > 2930 => dayIn24YearCycle - 2930,
                > 2552 => dayIn24YearCycle - 2552,
                > 2197 => dayIn24YearCycle - 2197,
                > 1820 => dayIn24YearCycle - 1820,
                > 1465 => dayIn24YearCycle - 1465,
                > 1087 => dayIn24YearCycle - 1087,
                > 732 => dayIn24YearCycle - 732,
                > 355 => dayIn24YearCycle - 355,
                _ => dayIn24YearCycle
            };

            uint yearIn24YearCycle = dayIn24YearCycle switch
            {
                > 8411 => 24u,
                > 8056 => 23u,
                > 7679 => 22u,
                > 7324 => 21u,
                > 6947 => 20u,
                > 6592 => 19u,
                > 6215 => 18u,
                > 5860 => 17u,
                > 5482 => 16u,
                > 5127 => 15u,
                > 4750 => 14u,
                > 4395 => 13u,
                > 4017 => 12u,
                > 3662 => 11u,
                > 3285 => 10u,
                > 2930 => 9u,
                > 2552 => 8u,
                > 2197 => 7u,
                > 1820 => 6u,
                > 1465 => 5u,
                > 1087 => 4u,
                > 732 => 3u,
                > 355 => 2u,
                _ => 1u
            };

            return yearIn24YearCycle switch
            {
                2 => new DayInLeapYear(dayInYear),
                4 => new DayInLongLeapYear(dayInYear),
                6 => new DayInLeapYear(dayInYear),
                8 => new DayInLongLeapYear(dayInYear),
                10 => new DayInLeapYear(dayInYear),
                12 => new DayInLongLeapYear(dayInYear),
                14 => new DayInLeapYear(dayInYear),
                16 => new DayInLongLeapYear(dayInYear),
                18 => new DayInLeapYear(dayInYear),
                20 => new DayInLeapYear(dayInYear),
                22 => new DayInLeapYear(dayInYear),
                _ => new DayInNormalYear(dayInYear)
            };
        }
    }

    private record DayInNormalYear(uint DayInYear) : DayInAYear
    {
        public uint Month => DayInYear switch
        {
            > 327 => 12,
            > 298 => 11,
            > 269 => 10,
            > 240 => 9,
            > 209 => 8,
            > 180 => 7,
            > 151 => 6,
            > 120 => 5,
            > 91 => 4,
            > 60 => 3,
            > 31 => 2,
            _ => 1
        };
    }

    private record DayInLeapYear(uint DayInYear) : DayInAYear
    {
        public uint Month => DayInYear switch
        {
            > 350 => 13,
            > 327 => 12,
            > 298 => 11,
            > 269 => 10,
            > 240 => 9,
            > 209 => 8,
            > 180 => 7,
            > 151 => 6,
            > 120 => 5,
            > 91 => 4,
            > 60 => 3,
            > 31 => 2,
            _ => 1
        };
    }

    private record DayInLongLeapYear(uint DayInYear) : DayInAYear
    {
        public uint Month => DayInYear switch
        {
            > 350 => 13,
            > 327 => 12,
            > 298 => 11,
            > 269 => 10,
            > 240 => 9,
            > 209 => 8,
            > 180 => 7,
            > 151 => 6,
            > 120 => 5,
            > 91 => 4,
            > 60 => 3,
            > 31 => 2,
            _ => 1
        };
    }
}
