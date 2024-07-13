using System.Runtime.CompilerServices;

namespace Task4;

public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Date(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
        {
            throw new ArgumentOutOfRangeException(nameof(day),"Year, Month" +
                                                  " and Day parameters describe an " +
                                                  "un-representable DateTime. ");
        }

        Day = day;
        Month = month;
        Year = year;
    }

    private bool IsValidDate(int day, int month, int year)
    {
        return DateTime.TryParseExact($"{year}-{month}-{day}", "yyyy-M-d", null,
            System.Globalization.DateTimeStyles.None, out _);
    }

    // Перевантаження оператора - для обчислення різниці в днях між двома датами
    public static int operator -(Date d1, Date d2)
    {
        DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
        DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
        TimeSpan difference = date1 - date2;
        return (int)difference.TotalDays;
    }
    // Перевантаження оператора + для додавання певної кількості днів до дати
    public static Date operator +(Date date, int days)
    {
        DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
        dateTime = dateTime.AddDays(days);
        return new Date(dateTime.Day, dateTime.Month, dateTime.Year);
    }

    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}

