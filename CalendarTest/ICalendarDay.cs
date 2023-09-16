namespace CalendarTest;

public interface IDate
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
    string DayName { get; }
    string WeekdayName { get; }

    string DateName => $"{DayName} {MonthName} {YearName}, Week {WeekInYear}, {WeekdayName}";

    bool Equals(object? obj) => obj is IDate dies && DayNumber == dies.DayNumber;
    int GetHashCode() => HashCode.Combine(DayNumber);

    static bool operator <(IDate left, IDate right) => left.DayNumber < right.DayNumber;
    static bool operator >(IDate left, IDate right) => left.DayNumber > right.DayNumber;
}
