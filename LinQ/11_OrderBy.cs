using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Users
{
    public string UserName {get; set;}
    public int UserId {get; set;}
    public string UserMail {get; set;}
}
class Program
{
    static void Main()
    {
        // var ls  = new List<int>() { 1,3,2,7,3,8,5};
        // var QuerySync = from num in ls 
        //                 where num > 5 
        //                 orderby num
        //                 select num;
        
        // Console.WriteLine("Order By using Query: ");

        // foreach(var obj in QuerySync)
        // {
        //     Console.Write(obj+" ");
        // }
        // Console.WriteLine();
        // Console.WriteLine("====================");
        // Console.WriteLine("Order By using Method: ");
        // var methodList  = new List<int>() { 1,3,2,7,3,8,5,9,10};
        // var MethodSync = methodList.Where(obj => obj > 5 && obj < 9).OrderBy(obj => obj);
        // foreach(var o in MethodSync)
        // {
        //     Console.Write(o+" ");
        // }
        // Console.WriteLine();
        // Console.WriteLine("====================");
        // var chList = new List<char>(){'b', 'c','a','e','d','p','g'};
        // var met = chList.OrderBy(obj =>obj);
        // foreach(var c in met)
        // {
        //     Console.Write(c+" ");
        // }
    
        // var strList = new List<string>() {"tim","tom", "jack","sparrow","jerry","tiger","maniya"};
        // var q = from i in strList
        //         where i.Length > 4
        //         orderby i 
        //         select i;
        // foreach(var o in q)
        // {
        //     Console.WriteLine(o);
        // }

        string path = @"D:\HCL\LinQ\DataSet3.csv";
        string files = @"D:\HCL\LinQ\DataStoring.txt";
        string[] lines = File.ReadAllLines(path);

        var NameAndMailId = lines.Skip(1)
                          .Select(line =>
                          {
                              var part = line.Split(',');
                              return new {Name = part[0], Mail = part[1]};
                          });

        var names = NameAndMailId.OrderBy(x => x.Name).Select(x => x.Name);
        var mails = NameAndMailId.OrderBy(x => x.Mail).Select(x => x.Mail);

        // var ids = NameAndMailId.Select(x=>x.Id);
        // foreach(var obj in ids)
        // {
            // string id = 
        // }
        // Console.WriteLine();
        // Console.WriteLine("=================");

        // int ind = 1;
        // foreach(var namesindata in mails)
        // {
        //    string namedata = $"{ind} => Name: {namesindata}";
        //    File.AppendAllLines(files, new[] {namedata});
        //    ind++;
        // }

        // // Console.WriteLine();
        // // Console.WriteLine("==================");

        // int i = 1;
        // foreach(var mailindata in names)
        // {
        //     string maildata = $"{i} => Mail: {mailindata}";
        //     File.AppendAllLines(files, new[] {maildata});
        //     i++;
        // }

        List<Users> dataSource = new List<Users>()
        {
            new Users()
            {
                UserName = "Tiger",
                UserId = 1,
                UserMail = "tiger@gmail.com"
            },
            new Users()
            {
                UserName = "Maniya",
                UserId = 3,
                UserMail = "maniya@gmail.com"
            },
            new Users()
            {
                UserName = "Martin",
                UserId = 2,
                UserMail = "martin@gmail.com"
            }
        };

        // var emp = from i in dataSource
        //           orderby i.UserId
        //           select i;
        
        // foreach(var e in emp)
        // {
        //     Console.WriteLine(e.UserId+" " + e.UserName);
        // }

        var emp = dataSource.OrderBy(e=>e.UserName);
        foreach(var i in emp)
        {
            Console.WriteLine(i.UserId+" " + i.UserMail);
            string res = $"userMail {i.UserMail}";
            File.AppendAllText(files, res);
        }

    }
}
