using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var dataSource = new List<int>()
        {
            1,4,6,3,6,8,4,5, 9, 10
        };
        var methodSyn = dataSource.Where(o => o > 6).OrderByDescending(num => num);
        foreach(var obj in methodSyn)
        {
            // Console.Write(obj +" ");
        }
        
        var querySyn = from i in dataSource
        where i > 6 && i < 10
                       orderby i descending
                       select i;
        foreach(var o in querySyn)
        {
            Console.Write(o+" ");
        }
    }
}