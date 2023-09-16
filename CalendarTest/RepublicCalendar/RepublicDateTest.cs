namespace CalendarTest.RepublicCalendar;

public class RepublicDateTest
{
    private const int LengthOf24YearCycle = 8766;

    [Theory]
    [InlineData(1, 1)]
    [InlineData(8412, 24)]
    [InlineData(LengthOf24YearCycle + 1, 24 + 1)]
    [InlineData(LengthOf24YearCycle + 355 + 1, 24 + 2)]
    [InlineData(LengthOf24YearCycle * 2, 48)]
    [InlineData(LengthOf24YearCycle * 2 + 1, 48 + 1)]

    public void Year(uint dayNumber, uint expectedYear)
    {
        new RepublicDate(dayNumber).Year.Should().Be(expectedYear);
    }

    [Theory]
    [InlineData(1,1)]
    [InlineData(1466,5)]
    [InlineData(LengthOf24YearCycle + 1, 24 + 1)]
    [InlineData(LengthOf24YearCycle * 3 + 1466, 24 * 3 + 5)]
    public void YearType_CommonYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearType.Should()
            .Be("annus", $"because year {yearNumber} is a common year");
    }

    [Theory]
    [InlineData(356,2)]
    [InlineData(3286,10)]
    [InlineData(LengthOf24YearCycle + 356, 24 + 2)]
    [InlineData(LengthOf24YearCycle * 3 + 3286, 24 * 3 + 10)]
    public void YearType_LeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearType.Should()
            .Be("annus intercalarius", $"because year {yearNumber} is a leap year");
    }

    [Theory]
    [InlineData(1088,4)]
    [InlineData(4018,12)]
    [InlineData(LengthOf24YearCycle + 1088, 24 + 4)]
    [InlineData(LengthOf24YearCycle * 3 + 4018, 24 * 3 + 12)]
    public void YearType_LongLeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearType.Should()
            .Be("annus intercalarius longus", $"because year {yearNumber} is a long leap year");
    }

    [Theory]
    [InlineData(1,1)]
    [InlineData(1466,5)]
    [InlineData(LengthOf24YearCycle + 1, 24 + 1)]
    [InlineData(LengthOf24YearCycle * 3 + 1466, 24 * 3 + 5)]
    public void YearLength_CommonYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearLength.Should()
            .Be(355, $"because year {yearNumber} is a common year");
    }

    [Theory]
    [InlineData(356,2)]
    [InlineData(3286,10)]
    [InlineData(LengthOf24YearCycle + 356, 24 + 2)]
    [InlineData(LengthOf24YearCycle * 3 + 3286, 24 * 3 + 10)]
    public void YearLength_LeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearLength.Should()
            .Be(377, $"because year {yearNumber} is a leap year");
    }

    [Theory]
    [InlineData(1088,4)]
    [InlineData(4018,12)]
    [InlineData(LengthOf24YearCycle + 1088, 24 + 4)]
    [InlineData(LengthOf24YearCycle * 3 + 4018, 24 * 3 + 12)]
    public void YearLength_LongLeapYears(uint firstDayNumber, uint yearNumber)
    {
        new RepublicDate(firstDayNumber).YearLength.Should()
            .Be(378, $"because year {yearNumber} is a long leap year");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(356)]
    [InlineData(LengthOf24YearCycle + 733)]
    [InlineData(LengthOf24YearCycle * 2 + 1088)]
    [InlineData(LengthOf24YearCycle * 16 + 1466)]
    public void DayInYear_FirstDayOfYear(uint dayNumber) {
        new RepublicDate(dayNumber).DayInYear.Should().Be(1);
    }

    [Theory]
    [InlineData(355)]
    [InlineData(732)]
    [InlineData(LengthOf24YearCycle + 1087)]
    [InlineData(LengthOf24YearCycle * 2 + 1465)]
    [InlineData(LengthOf24YearCycle * 16 + 1820)]
    public void DayInYear_LastDayOfYear(uint dayNumber) {
        new RepublicDate(dayNumber).DayInYear.Should()
            .Be(new RepublicYear(dayNumber).YearLength);
    }
}
