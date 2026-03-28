using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        var dataSource1 = new List<int>(){1,2,3,4,5,6};
        var dataSource2 = new List<int>()
        {
            1,2,3,4,5
        };
        var result = dataSource1.Union(dataSource2);
        foreach(var obj in result)
        { 
            Console.WriteLine(obj);
        }
     

    }
}