namespace CalendarTest.RepublicCalendar;

public class RepublicDate : IDate
{
    private readonly RepublicYear year;
    public RepublicDate(uint dayNumber)
    {
        DayNumber = dayNumber;
        year = new RepublicYear(dayNumber);
    }

    public uint DayNumber { get; }

    // delegate to year
    public uint Year => year.Year;
    public string YearType => year.YearType;
    public uint YearLength => year.YearLength;
    public string YearName => year.YearName;
    public uint FirstDayNumberOfYear => year.FirstDayNumberOfYear;

    public uint DayInYear => throw new NotImplementedException();

    public uint Month => throw new NotImplementedException();

    public uint DayInMonth => throw new NotImplementedException();

    public uint WeekInYear => throw new NotImplementedException();

    public uint Weekday => throw new NotImplementedException();

    public string MonthName => throw new NotImplementedException();

    public string DayName => throw new NotImplementedException();

    public string WeekdayName => throw new NotImplementedException();

}
