using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var ls = new List<string>()
        {
            "lol ", "nan ", "sas "
        };
        var u = ls.SelectMany(emp => emp).ToList(); 
        foreach(var i in u)
        {
            Console.Write(i);
        }
        Console.WriteLine();
        var u1 = (from i in ls
                from a in i
                select a).ToList();
        foreach(var i in u1)
        {
            Console.Write(i);
        }
    }
}