using System;
public class Month {
public enum MonthWise
{
    Jan, Feb, Mar, Apr, May = 5, June = 7
}
}

class Program
{
    static void Main (string[]aa)
    {
       Month.MonthWise m = Month.MonthWise.May;
       int m1 = (int) Month.MonthWise.June;
       int m2 = (int) Month.MonthWise.Apr;
       Month.MonthWise m3 = Month.MonthWise.June;
       Console.WriteLine(m1+" w"+m3);
       Console.WriteLine(m2);
    }
}