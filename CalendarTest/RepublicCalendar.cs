namespace CalendarTest;

public class RepublicCalendar : ICalendarDay
{
    public RepublicCalendar(uint dayNumber)
    {
        DayNumber = dayNumber;
    }

    public uint DayNumber { get; }

    public uint Year => DayNumber switch
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

    public uint Month => throw new NotImplementedException();

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
}
