namespace CalendarTest.RepublicCalendar;

public class RepublicCalendarTest
{
    [Theory]
    [InlineData(1,1)]
    [InlineData(356,2)]
    [InlineData(733,3)]
    [InlineData(1088,4)]
    [InlineData(1466,5)]
    [InlineData(1821,6)]
    [InlineData(2198,7)]
    [InlineData(2553,8)]
    [InlineData(2931,9)]
    [InlineData(3286,10)]
    [InlineData(3663,11)]
    [InlineData(4018,12)]
    [InlineData(4396,13)]
    [InlineData(4751,14)]
    [InlineData(5128,15)]
    [InlineData(5483,16)]
    [InlineData(5861,17)]
    [InlineData(6216,18)]
    [InlineData(6593,19)]
    [InlineData(6948,20)]
    [InlineData(7325,21)]
    [InlineData(7680,22)]
    [InlineData(8057,23)]
    [InlineData(8412,24)]

    public void Year_24YearCycle_FirstDayOfYear(uint dayNumber, uint expectedYear)
    {
        new RepublicDate(dayNumber).Year.Should().Be(expectedYear);
    }

    [Theory]
    [InlineData(355,1)]
    [InlineData(732,2)]
    [InlineData(1087,3)]
    [InlineData(1465,4)]
    [InlineData(1820,5)]
    [InlineData(2197,6)]
    [InlineData(2552,7)]
    [InlineData(2930,8)]
    [InlineData(3285,9)]
    [InlineData(3662,10)]
    [InlineData(4017,11)]
    [InlineData(4395,12)]
    [InlineData(4750,13)]
    [InlineData(5127,14)]
    [InlineData(5482,15)]
    [InlineData(5860,16)]
    [InlineData(6215,17)]
    [InlineData(6592,18)]
    [InlineData(6947,19)]
    [InlineData(7324,20)]
    [InlineData(7679,21)]
    [InlineData(8056,22)]
    [InlineData(8411,23)]
    [InlineData(8766,24)]
    public void Year_24YearCycle_LastDayOfYear(uint dayNumber, uint expectedYear)
    {
        new RepublicDate(dayNumber).Year.Should().Be(expectedYear);
    }

}
