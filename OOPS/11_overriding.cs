using System;
class Os
{
    public virtual void version()
    {
        Console.WriteLine("Windows 7");
    }
}
class Os1 : Os
{
    public override void version()
    {
        // base.version();
        Console.WriteLine("Windows 8");
    }
}

class Program
{
    static void Main (string[]sfsf)
    {
        Os o = new Os();
        Os1 o1 = new Os1();
        o1.version();
        o.version();
    }
}