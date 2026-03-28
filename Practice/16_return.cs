using System;
using System.Net.Http.Headers;
class mano
{
    static void Main(string[]p)
    {
        Console.WriteLine(MyMethod(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
    }
    static int MyMethod(int x, int y)
    {
        return x+y;
    }
}