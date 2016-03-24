using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        TimeSpan dif = secondDate - firstDate;//Class wich represents a time interval.
        int days = dif.Days;//.Days is a property of the class TimeSpan which shows the days

        Console.WriteLine("{0}", days);
    }
}