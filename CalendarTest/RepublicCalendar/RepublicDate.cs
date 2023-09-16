namespace CalendarTest.RepublicCalendar;

public class RepublicDate : IDate
{
    public RepublicDate(uint dayNumber)
    {
        DayNumber = dayNumber;
    }

    public uint DayNumber { get; }

    public uint Year => (24 * ((DayNumber - 1) / 8766)) + YearIn24YearCycle;

    private uint YearIn24YearCycle => (1 + ((DayNumber - 1)) % 8766) switch
    {
        <= 355 => 1,
        <= 732 => 2,
        <= 1087 => 3,
        <= 1465 => 4,
        <= 1820 => 5,
        <= 2197 => 6,
        <= 2552 => 7,
        <= 2930 => 8,
        <= 3285 => 9,
        <= 3662 => 10,
        <= 4017 => 11,
        <= 4395 => 12,
        <= 4750 => 13,
        <= 5127 => 14,
        <= 5482 => 15,
        <= 5860 => 16,
        <= 6215 => 17,
        <= 6592 => 18,
        <= 6947 => 19,
        <= 7324 => 20,
        <= 7679 => 21,
        <= 8056 => 22,
        <= 8411 => 23,
        <= 8766 => 24,
        _ => 0
    };

    public string YearType => YearIn24YearCycle switch
    {
        2 or 6 or 10 or 14 or 18 or 20 or 22 => "annus intercalarius",
        4 or 8 or 12 or 16 => "annus intercalarius longus",
        _ => "annus"
    };

    public uint DayInYear => throw new NotImplementedException();

    public uint Month => throw new NotImplementedException();

    public uint DayInMonth => throw new NotImplementedException();

    public uint WeekInYear => throw new NotImplementedException();

    public uint Weekday => throw new NotImplementedException();

    public string YearName => throw new NotImplementedException();

    public string MonthName => throw new NotImplementedException();

    public string DayName => throw new NotImplementedException();

    public string WeekdayName => throw new NotImplementedException();
}
