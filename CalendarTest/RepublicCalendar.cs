namespace CalendarTest;

public class RepublicCalendar : ICalendarDay
{
    public RepublicCalendar(uint dayNumber)
    {
        DayNumber = dayNumber;
    }

    public uint DayNumber { get; }

    private uint DayIn24YearCycle => ((DayNumber - 1) % 8766) + 1;

    private uint YearIn24YearCycle => DayIn24YearCycle switch
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

    private RepublicYearType YearType => YearIn24YearCycle switch
    {
        2 => RepublicYearType.LeapYear,
        4 => RepublicYearType.LongLeapYear,
        6 => RepublicYearType.LeapYear,
        8 => RepublicYearType.LongLeapYear,
        10 => RepublicYearType.LeapYear,
        12 => RepublicYearType.LongLeapYear,
        14 => RepublicYearType.LeapYear,
        16 => RepublicYearType.LongLeapYear,
        18 => RepublicYearType.LeapYear,
        20 => RepublicYearType.LeapYear,
        22 => RepublicYearType.LeapYear,
        _ => RepublicYearType.NormalYear
    };

    public uint Year => 24 * ((DayNumber - 1) / 8766) + YearIn24YearCycle;

    public uint DayInYear => DayIn24YearCycle switch
    {
        > 8411 => DayIn24YearCycle - 8411,
        > 8056 => DayIn24YearCycle - 8056,
        > 7679 => DayIn24YearCycle - 7679,
        > 7324 => DayIn24YearCycle - 7324,
        > 6947 => DayIn24YearCycle - 6947,
        > 6592 => DayIn24YearCycle - 6592,
        > 6215 => DayIn24YearCycle - 6215,
        > 5860 => DayIn24YearCycle - 5860,
        > 5482 => DayIn24YearCycle - 5482,
        > 5127 => DayIn24YearCycle - 5127,
        > 4750 => DayIn24YearCycle - 4750,
        > 4395 => DayIn24YearCycle - 4395,
        > 4017 => DayIn24YearCycle - 4017,
        > 3662 => DayIn24YearCycle - 3662,
        > 3285 => DayIn24YearCycle - 3285,
        > 2930 => DayIn24YearCycle - 2930,
        > 2552 => DayIn24YearCycle - 2552,
        > 2197 => DayIn24YearCycle - 2197,
        > 1820 => DayIn24YearCycle - 1820,
        > 1465 => DayIn24YearCycle - 1465,
        > 1087 => DayIn24YearCycle - 1087,
        > 732 => DayIn24YearCycle - 732,
        > 355 => DayIn24YearCycle - 355,
        _ => DayIn24YearCycle
    };

    public uint Month => YearType switch
    {
        RepublicYearType.NormalYear => DayInYear switch
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
            },
        _ => DayInYear switch
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
            }
    };

    public uint DayInMonth => throw new NotImplementedException();

    public uint WeekInYear => throw new NotImplementedException();

    public uint Weekday => throw new NotImplementedException();

    public string YearName => throw new NotImplementedException();

    public string MonthName => throw new NotImplementedException();

    public string WeekdayName => throw new NotImplementedException();

    public ICalendarDay AddDays(uint days)
    {
        throw new NotImplementedException();
    }

    public ICalendarDay SubtractDays(uint days)
    {
        throw new NotImplementedException();
    }

    private enum RepublicYearType
    {
        NormalYear,
        LeapYear,
        LongLeapYear
    }
}
