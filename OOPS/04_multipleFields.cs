using System;
class Program
{
    public string color;
    public int num;
    public Program(string color, int num)
    {
        this.color = color;
        this.num = num;
    }
    static void Main(string[]opisic)
    {
        Program p1 = new Program("Dark", 1962);
        Console.WriteLine(p1.color);
        Console.WriteLine(p1.num);
    }
}