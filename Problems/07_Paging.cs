using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Press -1 for quit:");
        while(true) {
        try
        {
            var path = @"D:\HCL\ProblemPractice\DataSet.csv";
            var location = GettingDetailsOfEmpolyee(path);
            if(!File.Exists(path)) throw new FileNotFoundException("The file not in this location");
            Console.Write("Enter Pages: ");
            // if(char.TryParse(Console.ReadLine(), out char ch))
                // if(ch == 'q') return;
            if(!int.TryParse(Console.ReadLine(), out int Pages)) 
                    throw new FormatException("Only Integer are allowed");
            if(Pages == -1) return;
            Console.Write("Enter references: ");
            if(!int.TryParse(Console.ReadLine(), out int references))
                throw new FormatException("Only Integers are allowed");
            if(Pages == 0 || references == 0) throw new ArgumentOutOfRangeException("The range should be 1 for both cases");
            var details = location.Skip((Pages - 1)* references).Take(references);
            foreach(var item in details)
            {
                Console.WriteLine($"Name: {item.EmpoName}, Mail-ID: {item.EmpoMailId}");
            }
        }
        catch(FileNotFoundException fn)
        {
            Console.WriteLine(fn.Message);
        }
        catch(FormatException f)
        {
            Console.WriteLine(f.Message);
        }
        catch(ArgumentOutOfRangeException a)
        {
            Console.WriteLine(a.Message);
        }
        }
    }
    public static List<DetailsOfEmpolyee> GettingDetailsOfEmpolyee(string path)
    {
        var Empolyees = new List<DetailsOfEmpolyee>();
        foreach(var obj in File.ReadAllLines(path).Skip(1))
        {
            var getting = obj.Split(',');
            Empolyees.Add(new DetailsOfEmpolyee
            {
                EmpoName = getting[0],
                EmpoMailId = getting[1],
                EmpoPnumber = int.Parse(getting[2]),
                EmpoID = int.Parse(getting[3])
            });
        }
        return Empolyees;
    }
}

class DetailsOfEmpolyee
{
    public string EmpoName {get;set;}
    public string EmpoMailId {get;set;}
    public int EmpoPnumber {get;set;}
    public int EmpoID {get;set;}
}