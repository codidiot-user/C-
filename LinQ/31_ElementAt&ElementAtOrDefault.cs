using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        try {
        var ls = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        // var ms = ls.ElementAt(-10);
        // var ms = ls.Where(x => x > 6).ElementAt(5);
        var ms = (from i in ls
                  select i).ElementAtOrDefault(88);

        Console.Write(ms);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}