namespace CalendarTest.RepublicCalendar;

public class RepublicMonth : IMonth
{
    public static RepublicMonth Martius = new(1, 31, 1, "Martius");
    public static RepublicMonth Aprilis = new(2, 29, 32, "Aprilis");
    public static RepublicMonth Maius = new(3, 31, 61, "Maius");
    public static RepublicMonth Iunius = new(4, 29, 92, "Iunius");
    public static RepublicMonth Quintilis = new(5, 31, 121, "Quintilis");
    public static RepublicMonth Sextilis = new(6, 29, 152, "Sextilis");
    public static RepublicMonth September = new(7, 29, 181, "September");
    public static RepublicMonth October = new(8, 31, 210, "October");
    public static RepublicMonth November = new(9, 29, 239, "November");
    public static RepublicMonth December = new(10, 29, 268, "December");
    public static RepublicMonth Ianuarius = new(11, 29, 297, "Ianuarius");
    public static RepublicMonth Februarius = new(12, 28, 326, "Februarius");
    public static RepublicMonth FebruariusIntercalaris = new(12, 23, 326, "Februarius");
    public static RepublicMonth IntercalarisMensis = new(13, 27, 359, "Intercalaris mensis");
    public static RepublicMonth IntercalarisMensisLong = new(13, 28, 359, "Intercalaris mensis");

    public RepublicMonth(uint month, uint monthLength, uint firstDayNumberOfMonth, string monthName) 
    {
        Month = month;
        MonthLength = monthLength;
        FirstDayNumberOfMonth = firstDayNumberOfMonth;
        MonthName = monthName;
    }

    public uint Month { get; }
    public uint MonthLength { get; }
    public uint FirstDayNumberOfMonth { get; }
    public string MonthName { get; }
}