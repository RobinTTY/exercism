using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, element => element == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(element => element >= 5);
    }
}
