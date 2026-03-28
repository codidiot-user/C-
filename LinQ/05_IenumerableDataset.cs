using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Users
{
    public string? Uname {get; set;}
    public int rollNo {get; set;}
}

class Program
{
    static void Main()
    {
        string path = @"D:\HCL\LinQ\dataset2.csv";

    /// ============= METHOD USING FOREACH ================
    

        // var ls = new List<Users>();
        // string[] lines = File.ReadAllLines(path);
        // foreach(var line in lines.Skip(1))
        // {
            
        //     string[] sc = line.Split(',');
        //     ls.Add(new Users()
        //     {
        //        Uname = sc[0],
        //        rollNo = int.Parse(sc[1]) 
        //     });
        // }


 //// ================== END OF METHOD 1 ===================
 

//// ================= USING ONLY LINQ QUERY METHOD =================
    
        List<Users> ls = File.ReadAllLines(path)
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .Select(sc => new Users()
                    {
                        Uname = sc[0],
                        rollNo = int.Parse(sc[1])
                    }).ToList();
        var user1 = ls.Where(obj => obj.rollNo == 3);
        foreach(var us in user1)
        {
            Console.WriteLine(us.rollNo+" "+us.Uname);
        }


    ///// ==================== END ===========================
    }
}