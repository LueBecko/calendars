namespace CalendarTest;

public class CalendarDayComparer : IComparer<IDate>
{
    public int Compare(IDate? x, IDate? y)
    {
        if (x == null || y == null) throw new NullReferenceException();
        return x.DayNumber.CompareTo(y.DayNumber);
    }
}