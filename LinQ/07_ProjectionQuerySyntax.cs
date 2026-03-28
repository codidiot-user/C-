using System;
using System.Collections.Generic;
using System.Linq;

class Users
{
    public string? name {get; set;}
    public string? Pnumber {get; set;}
    public string? mailId {get; set;}
}

class Empo
{
    public string? names{get; set;}
    public int? id {get; set;}
}

class Program
{
    static void Main()
    {
        var ls = new List<Users>()
        {
            new Users() {name = "Logesh", Pnumber = "1234567890", mailId = "logesh@gmail.com"},
            new Users() {name = "Saran", Pnumber = "9876543210", mailId = "saran@gmail.com"},
            new Users() {name = "Praveen", Pnumber = "1597864230", mailId = "praveen@gmail.com"},
            new Users() {name = "Kumar", Pnumber = "9519517530", mailId = "kumar@gmail.com"},
        };
        
        var selectQuery = (from emp in ls
                          select new Users()
                          {
                              mailId = emp.mailId,
                              name = emp.name
                          }).ToList();
        foreach(var i in selectQuery)
        {
            Console.WriteLine($"Name = {i.name} and Mail-Id = {i.mailId}");
        }


        // var lls = new List<Empo>()
        // {
        //     new Empo{names = "ll", id = 1},
        //     new Empo{names = "nan", id = 2}
        // };
        // var QuerySync = (from obj in lls
        //                 select obj.id).ToList();
    }
}