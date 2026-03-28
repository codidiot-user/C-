// THIS METHOD USED TO TAKE VALUES FROM DS BY PASSING A RANGE
using System;
using System.Linq;
using System.Collections.Generic;

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
        // var DataSource = new List<int>() {1,3,5,6,7,3,2,3,5,7,9,10};
        // var ms = DataSource.Where(x => x > 3 && x < 6).Take(5).ToList();
        // foreach(var obj in ms)
        // {
        //     // Console.WriteLine(obj);
        // }
        // var mixed = (from i in DataSource
        // where i > 4
        //             select i).Take(3);
        // foreach(var o in mixed)
        // {
        //     Console.WriteLine(o);
        // }
        var ds = new List<DataSources>()
        {
            new DataSources() {DepartName = "EEE", ClassRoomCount = 4, StudentsStrength = 200},
            new DataSources() {DepartName = "MECH", ClassRoomCount = 4, StudentsStrength = 245},
            new DataSources() {DepartName = "ECE", ClassRoomCount = 16, StudentsStrength = 500},
            new DataSources() {DepartName = "IT", ClassRoomCount = 15, StudentsStrength = 390}
        };
        var ms = ds.Where(x=> x.StudentsStrength > 300).Take(2).ToList();
        foreach(var obj in ms)
        {
            Console.WriteLine($"Department name: {obj.DepartName} and the strength: {obj.StudentsStrength}");
        }
    }
}