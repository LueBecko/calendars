namespace CalendarTest.RepublicCalendar;

public class RepublicYear : IYear
{
    private const int LengthOf24YearCycle = 8766;

    public RepublicYear(uint dayNumber)
    {
        Year = ComputeYear(dayNumber);
        (YearType, YearLength) = ComputeYearType(dayNumber);
    }

    private (string, uint) ComputeYearType(uint dayNumber) => YearIn24YearCycle(dayNumber) switch
    {
        2 or 6 or 10 or 14 or 18 or 20 or 22 => ("annus intercalarius", 377),
        4 or 8 or 12 or 16 => ("annus intercalarius longus", 378),
        _ => ("annus", 355)
    };

    private static uint ComputeYear(uint dayNumber) => 24 * CycleNumber(dayNumber) + YearIn24YearCycle(dayNumber);

    private static uint CycleNumber(uint dayNumber) => (dayNumber - 1) / LengthOf24YearCycle;

    private static uint YearIn24YearCycle(uint dayNumber) => (1 + ((dayNumber - 1) % LengthOf24YearCycle)) switch
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

    public uint Year { get; }
    public uint YearLength { get; }
    public string YearType { get; }
    public string YearName => throw new NotImplementedException();
}