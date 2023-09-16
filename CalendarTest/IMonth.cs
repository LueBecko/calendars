namespace CalendarTest;

public interface IMonth {
    uint Month { get; }
    uint MonthLength { get; }
    uint FirstDayNumberOfMonth { get; }
    string MonthName { get; }
}