namespace CalendarTest;

public class TenMonthCalendarDayTest
{
    [Theory]
    [InlineData(0, "1 Martius 1 a.u.c., Week 1, A")]
    [InlineData(1, "2 Martius 1 a.u.c., Week 1, B")]
    [InlineData(2, "3 Martius 1 a.u.c., Week 1, C")]
    [InlineData(3, "4 Martius 1 a.u.c., Week 1, D")]
    [InlineData(4, "5 Martius 1 a.u.c., Week 1, E")]
    [InlineData(5, "6 Martius 1 a.u.c., Week 1, F")]
    [InlineData(6, "7 Martius 1 a.u.c., Week 1, G")]
    [InlineData(7, "8 Martius 1 a.u.c., Week 1, H")]
    [InlineData(8, "9 Martius 1 a.u.c., Week 2, A")]
    [InlineData(9, "10 Martius 1 a.u.c., Week 2, B")]
    [InlineData(10, "11 Martius 1 a.u.c., Week 2, C")]

    [InlineData(29, "30 Martius 1 a.u.c., Week 4, F")]
    [InlineData(30, "31 Martius 1 a.u.c., Week 4, G")]
    [InlineData(31, "1 Aprilis 1 a.u.c., Week 4, H")]
    [InlineData(32, "2 Aprilis 1 a.u.c., Week 5, A")]
    public void TenMonthCalendarDay(uint number, string expected)
    {
        ICalendarDay calendarDay = new TenMonthCalendarDay(number);
        Assert.Equal(expected, calendarDay.DayName);
    }

    [Theory]
    [InlineData(0, 1, "Martius")]
    [InlineData(1, 1, "Martius")]
    [InlineData(29, 1, "Martius")]
    [InlineData(30, 1, "Martius")]

    [InlineData(31, 2, "Aprilis")]
    [InlineData(32, 2, "Aprilis")]
    [InlineData(59, 2, "Aprilis")]
    [InlineData(60, 2, "Aprilis")]

    [InlineData(61, 3, "Maius")]
    [InlineData(62, 3, "Maius")]
    [InlineData(90, 3, "Maius")]
    [InlineData(91, 3, "Maius")]

    [InlineData(92, 4, "Iunius")]
    [InlineData(93, 4, "Iunius")]
    [InlineData(94, 4, "Iunius")]
    [InlineData(121, 4, "Iunius")]

    [InlineData(122, 5, "Quintilis")]
    [InlineData(123, 5, "Quintilis")]
    [InlineData(124, 5, "Quintilis")]
    [InlineData(152, 5, "Quintilis")]

    [InlineData(153, 6, "Sextilis")]
    [InlineData(154, 6, "Sextilis")]
    [InlineData(155, 6, "Sextilis")]
    [InlineData(182, 6, "Sextilis")]

    [InlineData(183, 7, "September")]
    [InlineData(184, 7, "September")]
    [InlineData(185, 7, "September")]
    [InlineData(212, 7, "September")]

    [InlineData(213, 8, "October")]
    [InlineData(214, 8, "October")]
    [InlineData(215, 8, "October")]
    [InlineData(243, 8, "October")]

    [InlineData(244, 9, "November")]
    [InlineData(245, 9, "November")]
    [InlineData(246, 9, "November")]
    [InlineData(273, 9, "November")]

    [InlineData(274, 10, "December")]
    [InlineData(275, 10, "December")]
    [InlineData(276, 10, "December")]
    [InlineData(303, 10, "December")]

    [InlineData(304, 11, "-")]
    [InlineData(305, 11, "-")]
    [InlineData(306, 11, "-")]
    [InlineData(352, 11, "-")]
    public void TenMonthCalendarDay_Month(uint number, uint expectedMonth, string expectedMonthName)
    {
        ICalendarDay calendarDay = new TenMonthCalendarDay(number);
        Assert.Equal(expectedMonth, calendarDay.Month);
        Assert.Equal(expectedMonthName, calendarDay.MonthName);
    }

    [Theory]
    [InlineData(0, 1, "1 a.u.c.")]
    [InlineData(1, 1, "1 a.u.c.")]
    [InlineData(2, 1, "1 a.u.c.")]
    [InlineData(353, 1, "1 a.u.c.")]
    [InlineData(354, 2, "2 a.u.c.")]
    [InlineData(355, 2, "2 a.u.c.")]
    [InlineData(707, 2, "2 a.u.c.")]
    [InlineData(708, 3, "3 a.u.c.")]
    [InlineData(709, 3, "3 a.u.c.")]
    [InlineData(3539, 10, "10 a.u.c.")]
    [InlineData(3540, 11, "11 a.u.c.")]
    [InlineData(3541, 11, "11 a.u.c.")]
    public void TenMonthCalendarDay_Year(uint number, uint expectedYear, string expectedYearName) {
        ICalendarDay calendarDay = new TenMonthCalendarDay(number);
        Assert.Equal(expectedYear, calendarDay.Year);
        Assert.Equal(expectedYearName, calendarDay.YearName);
    }
}
