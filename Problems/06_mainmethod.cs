using System;
using System.Collections.Generic;
using System.Linq;

class Users
{
    public string uName {get; set;}
    public string MailId {get; set;}
    public long pNumber {get; set;}
}

class Students
{
    public string sName {get; set;}
    public string sMail {get; set;}
}

class Program
{
    static void Main()
    {
         string transFile = @"D:\HCL\ProblemPractice\DataStoringFile.txt";
         string path = @"D:\HCL\ProblemPractice\DataSet.csv";
        
        // var ls = new List<Users>()
        // {

        //     new Users() {uName = "Logesh", MailId = "logesh@gmail.com", pNumber = 123456},
        //     new Users() {uName = "Saran", MailId = "saran@gmail.com", pNumber = 012345},
        //     new Users() {uName = "Praveen", MailId = "praveen@gmail.com", pNumber = 987654},
        //     new Users() {uName = "Mano", MailId = "mano@gmail.com", pNumber = 147852}
        // };

        // var u1 = (from obj in ls                //// PRINTIG NECESSARY DETAILS WITHOUT 'WHERE' USING QUERY SYNTAX
        //         select obj).ToList();
        var lines = File.ReadAllLines(path)
        .Skip(1)
        .Select(lines=> lines.Split(','))
        .Select(re => new Users()
        {
            uName = re[0],
            MailId = re[1],
            pNumber = int.Parse(re[2])
        });
        
        foreach (var u in lines)
        {
            string result = ($"User's Name = {u.uName}, User's Mail-Id = {u.MailId}\n");
            File.AppendAllText(transFile, result);
        }

        // var u = (from i in ls                 //// TAKING ONLY ESSENTIAL THINGS FROM DATA USING QUERY SYNTAX 
        //         select i.pNumber).ToList();
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i);
        // }
 
        // var s1 = (from i in ls                  //// COPYING ALL DETAILS INTO NEW CLASS IN QUERY SYNTAX
        //         select new Students()
        //         {
        //             sName = i.uName,
        //             sMail = i.MailId
        //         }).ToList();

        // foreach(var i in s1)
        // {
        //     Console.WriteLine(i.sName +" "+i.sMail);
        // }

        // var u = (from i in ls                //// EDITING EXISITING CLASS
        //         select new Users()
        //         {
        //             uName = i.uName,
        //             MailId = i.MailId
        //         }).ToList();
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i.MailId);
        // }

        // var u = ls.ToList();                    //// TAKING NECESSARY VALUES USING METHOD SYNTAX
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i.MailId+" "+ i.pNumber);
        // }

        // var u = ls.Select(obj => obj.uName);   //// TAKING PARTICULAR VALUE USING METHOD SYNTAX
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i);
        // }

        // var u = ls.Select(obj => new Students()
        // {
        //     sName = obj.uName
        // }).ToList();
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i.sName);
        // }

        // var u = (from i in ls                 //// ANONYMOUS TYPE USING QUERY SYNTAX
        // select new
        // {
        //     Name = i.uName,
        //     Mail = i.MailId
        // }).ToList();
        // foreach(var i in u)
        // {
        //     Console.WriteLine(i.Name+"-->"+i.Mail);
        // }

        // var u = ls.Select(obj  => new
        // {
        //     CustomName = obj.uName,
        //     CustomId = obj.pNumber
        // }).ToList();

        // foreach(var i in u)
        // {
        //     Console.WriteLine(i.CustomName+" "+i.CustomId);
        // }

        // var u = ls.Select((emp, Index) => new {Index = Index, FName = emp.uName});
        // foreach(var i in u)
        // {
        //     string result = $"The index position {i.Index} and the user name {i.FName}\n";
        //     File.AppendAllText(transFile, result);
        // }

    }
}