using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var DS = new List<int>() {2, 1,3,5,6, 3};
        var ms = DS.SkipWhile(num=> num <= 4);
        foreach(var obj in ms)
        {
            Console.WriteLine(obj);
        }
    }
}