namespace CalendarTest.RepublicCalendar;

public class RepublicDate : IDate
{
    private readonly RepublicYear year;
    private readonly RepublicMonth month;

    public RepublicDate(uint dayNumber)
    {
        DayNumber = dayNumber;
        year = new RepublicYear(dayNumber);
        month = year.GetMonth(DayInYear);
    }

    public uint DayNumber { get; }
    public uint DayInYear => DayNumber - FirstDayNumberOfYear + 1;
    public uint DayInMonth => DayInYear - FirstDayNumberOfMonth + 1;

    // delegate to year
    public uint Year => year.Year;
    public string YearType => year.YearType;
    public uint YearLength => year.YearLength;
    public string YearName => year.YearName;
    public uint FirstDayNumberOfYear => year.FirstDayNumberOfYear;

    // delegate to month
    public uint Month => month.Month;
    public uint MonthLength => month.MonthLength;
    public uint FirstDayNumberOfMonth => month.FirstDayNumberOfMonth;
    public string MonthName => month.MonthName;


    public uint WeekInYear => throw new NotImplementedException();

    public uint Weekday => throw new NotImplementedException();


    public string DayName => throw new NotImplementedException();

    public string WeekdayName => throw new NotImplementedException();

}
