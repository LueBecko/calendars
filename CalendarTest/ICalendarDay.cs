namespace CalendarTest;

public interface ICalendarDay
{
    uint DayNumber { get; }
    uint Year { get; }
    uint DayInYear { get; }
    uint Month { get; }
    uint DayInMonth { get; }
    uint WeekInYear { get; }
    uint Weekday { get; }
    string YearName { get; }
    string MonthName { get; }
    string WeekdayName { get; }

    string DayName => $"{DayInMonth} {MonthName} {YearName}, Week {WeekInYear}, {WeekdayName}";

    bool Equals(object? obj) => obj is ICalendarDay dies && DayNumber == dies.DayNumber;
    int GetHashCode() => HashCode.Combine(DayNumber);

    ICalendarDay AddDays(uint days);
    ICalendarDay SubtractDays(uint days);
    ICalendarDay Previous() => SubtractDays(1);
    ICalendarDay Next() => AddDays(1);

    static bool operator <(ICalendarDay left, ICalendarDay right) => left.DayNumber < right.DayNumber;
    static bool operator >(ICalendarDay left, ICalendarDay right) => left.DayNumber > right.DayNumber;
}
