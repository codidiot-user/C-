using System;
interface Windows7
{
    public void version1();
}
interface Windows8
{
    public void version2();
}

class Microsoft : Windows7, Windows8
{
    public void version1()
    {
        Console.WriteLine("First OS");
    }
    public void version2()
    {
        Console.WriteLine("version 2 is priniting");
    }
}

class Program
{
    static void Main (string[]asa)
    {
        Microsoft m = new Microsoft();
        m.version1();
        m.version2();
    }
}