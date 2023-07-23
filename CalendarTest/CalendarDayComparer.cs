namespace CalendarTest;

public class CalendarDayComparer : IComparer<ICalendarDay>
{
    public int Compare(ICalendarDay? x, ICalendarDay? y)
    {
        if (x == null || y == null) throw new NullReferenceException();
        return x.DayNumber.CompareTo(y.DayNumber);
    }
}