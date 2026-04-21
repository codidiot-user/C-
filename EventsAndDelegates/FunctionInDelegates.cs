using System;
using System.Security.Cryptography;

class Program
{
    
    static void Main()
    {
        Func<int, int, int, int>  op = (x, y, z) => x+y+z;
        Console.WriteLine(op(1,2,99));
    }
}