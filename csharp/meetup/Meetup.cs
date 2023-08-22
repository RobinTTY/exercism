using System;

public enum Schedule
{
    First,
    Second,
    Third,
    Fourth,
    Last,
    Teenth
}

public class Meetup
{
    private readonly int _month;
    private readonly int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime date;
        switch (schedule)
        {
            case Schedule.First:
            case Schedule.Second:
            case Schedule.Third:
            case Schedule.Fourth:
                date = new DateTime(_year, _month, 1 + (int)schedule * 7);
                break;

            // begin with the 13th
            case Schedule.Teenth:
                date = new DateTime(_year, _month, 13);
                break;

            // check last week of month
            case Schedule.Last:
                date = new DateTime(_year, _month, DateTime.DaysInMonth(_year, _month) - 6);
                break;

            default:
                throw new ArgumentException();
        }

        while (date.DayOfWeek != dayOfWeek)
            date = date.AddDays(1);

        return date;
    }
}