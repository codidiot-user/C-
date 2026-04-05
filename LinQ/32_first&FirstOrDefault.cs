using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Data
{
    public string name {get;set;}
    public string pass {get;set;}
    public int id {get;set;}
}

class Program
{
    static void Main()
    {
        // try{
        // var ls = new List<int>() {1,2,3,4,5,6,7,8,9};
        // var ms = ls.FirstOrDefault(x => x > 9);
        // Console.WriteLine(ms);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        var ls = new List<Data>()
        {
            new Data() {name = "User1", pass = "User1", id = 5213},
            new Data() {name = "User2", pass = "User2", id = 2},
            new Data() {name = "User3", pass = "User3", id = 3}
        };
        var ms = ls.FirstOrDefault(x => x.name == "User1" && x.pass == "Usr1");
        Console.WriteLine(ms);

    }
}