using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var Fpath = @"d:\HCL\LinQ\DataSet3.csv";
        var location = GetEmpolyee(Fpath);
        Console.WriteLine(File.Exists(Fpath)?"File exists" : "Not  fount");
        int pages = 2, get = 2;
        var ms = location.Skip((get - 1)*pages).Take(pages);
        foreach(var o in ms)
        {
            Console.WriteLine($"Name: {o.Name} & Mail-Id: {o.MailId}");
        }
    }
    public static List<Empolyess> GetEmpolyee(string path)
    {
        var empo = new List<Empolyess>();
        
        foreach(var obj in File.ReadAllLines(path).Skip(1))
        {
            string[] spl = obj.Split(',');
            empo.Add(new Empolyess
            {
                Name = spl[0],
                MailId = spl[1],
                PNumber = spl[2],
                ID = int.Parse(spl[3])
            });
        }
        return empo;
    }
}


class Empolyess
{
    public string Name {get;set;}
    public string MailId {get;set;}
    public string PNumber {get;set;}
    public int ID {get;set;}
}