namespace CalendarTest.RepublicCalendar;

public class RepublicYear : IYear
{
    private const int LengthOf24YearCycle = 8766;

    public RepublicYear(uint dayNumber)
    {
        var year = YearIn24YearCycle(dayNumber);
        uint cycleNumber = CycleNumber(dayNumber);

        Year = 24 * cycleNumber + year.Year;
        FirstDayNumberOfYear = LengthOf24YearCycle * cycleNumber + year.FirstDayInYear;
        (YearType, YearLength) = ComputeYearType(year.Year);
    }

    private (string, uint) ComputeYearType(uint year) => year switch
    {
        2 or 6 or 10 or 14 or 18 or 20 or 22 => ("annus intercalarius", 377),
        4 or 8 or 12 or 16 => ("annus intercalarius longus", 378),
        _ => ("annus", 355)
    };

    private static uint CycleNumber(uint dayNumber) => (dayNumber - 1) / LengthOf24YearCycle;

    private static (uint Year, uint FirstDayInYear) YearIn24YearCycle(uint dayNumber) => (1 + ((dayNumber - 1) % LengthOf24YearCycle)) switch
    {
        <= 355  => ( 1, 1),
        <= 732  => ( 2, 356),
        <= 1087 => ( 3, 733),
        <= 1465 => ( 4, 1088),
        <= 1820 => ( 5, 1466),
        <= 2197 => ( 6, 1821),
        <= 2552 => ( 7, 2198),
        <= 2930 => ( 8, 2553),
        <= 3285 => ( 9, 2931),
        <= 3662 => (10, 3286),
        <= 4017 => (11, 3663),
        <= 4395 => (12, 4018),
        <= 4750 => (13, 4396),
        <= 5127 => (14, 4751),
        <= 5482 => (15, 5128),
        <= 5860 => (16, 5483),
        <= 6215 => (17, 5861),
        <= 6592 => (18, 6216),
        <= 6947 => (19, 6593),
        <= 7324 => (20, 6948),
        <= 7679 => (21, 7325),
        <= 8056 => (22, 7680),
        <= 8411 => (23, 8057),
        <= 8766 => (24, 8412),
        _ => (0, 0)
    };

    public uint Year { get; }
    public uint YearLength { get; }
    public string YearType { get; }
    public string YearName => throw new NotImplementedException();
    public uint FirstDayNumberOfYear { get; }
}