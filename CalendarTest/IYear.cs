namespace CalendarTest;

public interface IYear {
    uint Year { get; }
    uint YearLength { get; }
    uint FirstDayNumberOfYear { get; }
    string YearType { get; }
    string YearName { get; }
}