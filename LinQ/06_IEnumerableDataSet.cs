using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

class Unit
{
    public int number {get; set;}
    public string name {get; set;}
}

class Program
{
    static void Main()
    {
        string path = @"D:\HCL\LinQ\dataset.csv";
        List<Unit> ls = File.ReadAllLines(path)
            .Skip(1)
            .Select(sel => sel.Split(','))
            .Select(sc => new Unit()
            {
                number = int.Parse(sc[1]),
                name = sc[0]
            }).ToList();
            var u1 = ls.Where(obj => obj.number == 3);
            foreach(var i in u1)
        {
            Console.WriteLine(i.name);
        }
    }
}