// THIS METHOD OR OPERATOR WORKS EXACTLY LIKE WHILE CONDITION FOR CHECKING THE DS

using System;
using System.Collections.Generic;
using System.Linq;

class DataSources
{
    public string? DepartName {get;set;}
    public int? StudentsStrength {get;set;}
    public int? ClassRoomCount {get;set;}
}



class Program
{
    static void Main()
    {
        // var ds = new List<int>() {1,2,5,6,7,8,3,4};
        // var ms = ds.Where(x=>x < 6).ToList();
        // foreach(var obj in ms)
        // {
        //     Console.WriteLine(obj);
        // }
        var ds = new List<DataSources>()
        {
            new DataSources() {DepartName = "ECE", ClassRoomCount = 16, StudentsStrength = 500},
            new DataSources() {DepartName = "EEE", ClassRoomCount = 4, StudentsStrength = 200},
            new DataSources() {DepartName = "MECH", ClassRoomCount = 4, StudentsStrength = 245},
            new DataSources() {DepartName = "IT", ClassRoomCount = 15, StudentsStrength = 390}
        };
        var ms = ds.TakeWhile(x=> x.StudentsStrength > 300).ToList();
        foreach(var o in ms)
        {
            Console.WriteLine($"The DEPT Name: {o.DepartName} & Classrooms: {o.ClassRoomCount}");
        }
    }
}