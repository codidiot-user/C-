using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

class Program
{
    static void Main()
    {
        try{
        var ls = new List<int>(){1,2,3,4,5,6,7};
        var ms = ls.LastOrDefault(x => x > 7);
        Console.WriteLine(ms);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}