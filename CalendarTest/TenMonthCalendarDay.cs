namespace CalendarTest;

public record TenMonthCalendarDay(uint DayNumber) : ICalendarDay
{
    private static readonly string[] monthNames = { "Martius", "Aprilis", "Maius", "Iunius", "Quintilis", "Sextilis", "September", "October", "November", "December", "-" };
    private static readonly uint[] monthLength = { 31, 30, 31, 30, 31, 30, 30, 31, 30, 30, 50 };
    private static readonly uint[] accumulatedMonthLengths = { 0, 31, 61, 92, 122, 153, 183, 213, 244, 274, 304, 354 };
    private static readonly string[] weekdayNames = { "A", "B", "C", "D", "E", "F", "G", "H" };

    public uint Year => 1 + DayNumber / accumulatedMonthLengths[11];
    public uint Month => (uint)accumulatedMonthLengths.Count(daysTillMonth => daysTillMonth <= DayNumber);

    public uint DayInMonth => 1 + DayNumber - accumulatedMonthLengths[Month - 1];

    public uint WeekInYear => 1 + DayNumber / 8;
    public uint Weekday => DayNumber % 8;

    public string YearName => $"{Year} a.u.c.";
    public string MonthName => monthNames[Month - 1];
    public string WeekdayName => weekdayNames[Weekday];

    public ICalendarDay AddDays(uint days) => new TenMonthCalendarDay(DayNumber + days);
    public ICalendarDay SubtractDays(uint days) => new TenMonthCalendarDay(DayNumber - days);
}