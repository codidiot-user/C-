using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List<string> ls = new List<string>()
        // {
        //    "LoL", "NaN", "GoG", "SaS", "PaP" 
        // };
        // var QuerySyn = (from i in ls
        // where i.Equals("saP")
        // select i).FirstOrDefault();
        // Console.WriteLine(QuerySyn);
        // // foreach(var o in QuerySyn)
        // // Console.WriteLine(o);
        var ls = new List<int>()
        {
            1,2,3,3,2,1,
        };
        var QuerySyn = (from asa in ls where asa > 3 select asa).FirstOrDefault();
        Console.WriteLine(QuerySyn);
    }
}