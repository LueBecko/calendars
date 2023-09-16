namespace CalendarTest;

public interface IMonth {
    uint Month { get; }
    uint MonthLength { get; }
    uint FirstDayOfMonth { get; }
    string MonthName { get; }
}