namespace CalendarTest.RepublicCalendar;

public class RepublicYearTest
{
    private const int LengthOf24YearCycle = 8766;

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
        new RepublicYear(dayNumber).Year.Should().Be(expectedYear);
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
        new RepublicYear(dayNumber).Year.Should().Be(expectedYear);
    }

    [Theory]
    [InlineData(LengthOf24YearCycle + 1,25)]
    [InlineData(LengthOf24YearCycle + 355 + 1,26)]
    [InlineData(LengthOf24YearCycle + 723,26)]
    [InlineData(LengthOf24YearCycle + 733,27)]
    [InlineData(LengthOf24YearCycle * 2,48)]
    [InlineData(LengthOf24YearCycle * 2 + 1,49)]
    [InlineData(LengthOf24YearCycle * 3,72)]
    [InlineData(LengthOf24YearCycle * 3 + 1,73)]
    public void Year_Across24YearCycles(uint dayNumber, uint expectedYear)
    {
        new RepublicYear(dayNumber).Year.Should().Be(expectedYear);
    }

    [Theory]
    [InlineData(1,1)]
    [InlineData(733,3)]
    [InlineData(1466,5)]
    [InlineData(2198,7)]
    [InlineData(2931,9)]
    [InlineData(3663,11)]
    [InlineData(4396,13)]
    [InlineData(5128,15)]
    [InlineData(5861,17)]
    [InlineData(6593,19)]
    [InlineData(7325,21)]
    [InlineData(8057,23)]
    [InlineData(8412,24)]
    [InlineData(LengthOf24YearCycle + 1,25)]
    [InlineData(LengthOf24YearCycle + 733,27)]
    [InlineData(LengthOf24YearCycle + 1466,29)]
    [InlineData(LengthOf24YearCycle * 2 + 1, 24 * 2 + 1)]
    [InlineData(LengthOf24YearCycle * 2 + 733, 24 * 2 + 3)]
    [InlineData(LengthOf24YearCycle * 3 + 1466, 24 * 3 + 5)]
    public void YearType_CommonYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearType.Should()
            .Be("annus", $"because year {yearNumber} is a common year");
    }

    [Theory]
    [InlineData(356,2)]
    [InlineData(1821,6)]
    [InlineData(3286,10)]
    [InlineData(4751,14)]
    [InlineData(6216,18)]
    [InlineData(6948,20)]
    [InlineData(7680,22)]
    [InlineData(LengthOf24YearCycle + 356, 24 + 2)]
    [InlineData(LengthOf24YearCycle + 1821, 24 + 6)]
    [InlineData(LengthOf24YearCycle + 3286, 24 + 10)]
    [InlineData(LengthOf24YearCycle * 2 + 356, 24 * 2 + 2)]
    [InlineData(LengthOf24YearCycle * 2 + 1821, 24 * 2 + 6)]
    [InlineData(LengthOf24YearCycle * 3 + 3286, 24 * 3 + 10)]
    public void YearType_LeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearType.Should()
            .Be("annus intercalarius", $"because year {yearNumber} is a leap year");
    }

    [Theory]
    [InlineData(1088,4)]
    [InlineData(2553,8)]
    [InlineData(4018,12)]
    [InlineData(5483,16)]
    [InlineData(LengthOf24YearCycle + 1088, 24 + 4)]
    [InlineData(LengthOf24YearCycle + 2553, 24 + 8)]
    [InlineData(LengthOf24YearCycle + 4018, 24 + 12)]
    [InlineData(LengthOf24YearCycle * 2 + 1088, 24 * 2 + 4)]
    [InlineData(LengthOf24YearCycle * 2 + 2553, 24 * 2 + 8)]
    [InlineData(LengthOf24YearCycle * 3 + 4018, 24 * 3 + 12)]
    public void YearType_LongLeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearType.Should()
            .Be("annus intercalarius longus", $"because year {yearNumber} is a long leap year");
    }

    [Theory]
    [InlineData(1,1)]
    [InlineData(733,3)]
    [InlineData(1466,5)]
    [InlineData(2198,7)]
    [InlineData(2931,9)]
    [InlineData(3663,11)]
    [InlineData(4396,13)]
    [InlineData(5128,15)]
    [InlineData(5861,17)]
    [InlineData(6593,19)]
    [InlineData(7325,21)]
    [InlineData(8057,23)]
    [InlineData(8412,24)]
    [InlineData(LengthOf24YearCycle + 1, 24 + 1)]
    [InlineData(LengthOf24YearCycle + 733, 24 + 3)]
    [InlineData(LengthOf24YearCycle + 1466, 24 + 5)]
    [InlineData(LengthOf24YearCycle * 2 + 1, 24 * 2 + 1)]
    [InlineData(LengthOf24YearCycle * 2 + 733, 24 * 2 + 3)]
    [InlineData(LengthOf24YearCycle * 3 + 1466, 24 * 3 + 5)]
    public void YearLength_CommonYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearLength.Should()
            .Be(355, $"because year {yearNumber} is a common year");
    }

    [Theory]
    [InlineData(356,2)]
    [InlineData(1821,6)]
    [InlineData(3286,10)]
    [InlineData(4751,14)]
    [InlineData(6216,18)]
    [InlineData(6948,20)]
    [InlineData(7680,22)]
    [InlineData(LengthOf24YearCycle + 356, 24 + 2)]
    [InlineData(LengthOf24YearCycle + 1821, 24 + 6)]
    [InlineData(LengthOf24YearCycle + 3286, 24 + 10)]
    [InlineData(LengthOf24YearCycle * 2 + 356, 24 * 2 + 2)]
    [InlineData(LengthOf24YearCycle * 2 + 1821, 24 * 2 + 6)]
    [InlineData(LengthOf24YearCycle * 3 + 3286, 24 * 3 + 10)]
    public void YearLength_LeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearLength.Should()
            .Be(377, $"because year {yearNumber} is a leap year");
    }

    [Theory]
    [InlineData(1088,4)]
    [InlineData(2553,8)]
    [InlineData(4018,12)]
    [InlineData(5483,16)]
    [InlineData(LengthOf24YearCycle + 1088, 24 + 4)]
    [InlineData(LengthOf24YearCycle + 2553, 24 + 8)]
    [InlineData(LengthOf24YearCycle + 4018, 24 + 12)]
    [InlineData(LengthOf24YearCycle * 2 + 1088, 24 * 2 + 4)]
    [InlineData(LengthOf24YearCycle * 2 + 2553, 24 * 2 + 8)]
    [InlineData(LengthOf24YearCycle * 3 + 4018, 24 * 3 + 12)]
    public void YearLength_LongLeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicYear(firstDayNumber).YearLength.Should()
            .Be(378, $"because year {yearNumber} is a long leap year");
    }

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
    [InlineData(LengthOf24YearCycle + 1, 24 + 1)]
    [InlineData(LengthOf24YearCycle + 356, 24 + 2)]
    [InlineData(LengthOf24YearCycle + 733, 24 + 3)]
    [InlineData(LengthOf24YearCycle + 1088, 24 + 4)]
    [InlineData(LengthOf24YearCycle + 1466, 24 + 5)]
    [InlineData(LengthOf24YearCycle + 1821, 24 + 6)]
    [InlineData(LengthOf24YearCycle + 2553, 24 + 8)]
    [InlineData(LengthOf24YearCycle + 3286, 24 + 10)]
    [InlineData(LengthOf24YearCycle + 4018, 24 + 12)]
    [InlineData(LengthOf24YearCycle * 2 + 1, 24 * 2 + 1)]
    [InlineData(LengthOf24YearCycle * 2 + 356, 24 * 2 + 2)]
    [InlineData(LengthOf24YearCycle * 2 + 733, 24 * 2 + 3)]
    [InlineData(LengthOf24YearCycle * 2 + 1088, 24 * 2 + 4)]
    [InlineData(LengthOf24YearCycle * 2 + 1821, 24 * 2 + 6)]
    [InlineData(LengthOf24YearCycle * 2 + 2553, 24 * 2 + 8)]
    [InlineData(LengthOf24YearCycle * 3 + 1466, 24 * 3 + 5)]
    [InlineData(LengthOf24YearCycle * 3 + 3286, 24 * 3 + 10)]
    [InlineData(LengthOf24YearCycle * 3 + 4018, 24 * 3 + 12)]
    public void YearLength_Matches(uint firstDayNumber, uint yearNumber)
    {
        RepublicYear year = new(firstDayNumber);
        year.Year.Should().Be(yearNumber);

        new RepublicYear(firstDayNumber - 1).Year.Should().NotBe(yearNumber);
        new RepublicYear(firstDayNumber + year.YearLength - 1).Year.Should().Be(yearNumber);
        new RepublicYear(firstDayNumber + year.YearLength).Year.Should().NotBe(yearNumber);
     }
}
