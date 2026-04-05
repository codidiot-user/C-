using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try{
        var ls = new List<int>(){1};
        // var ms = ls.SingleOrDefault(x=>x>1);
        var qs = (from i in ls select i).Select(i);
        Console.WriteLine(qs);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}