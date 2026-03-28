using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


class Program
{
    static void Main()
    {
        try{
        var path1 = @"D:\HCL\RealTimeProblems\fdia_smartgrid1.csv";
        if(!File.Exists(path1)) throw new FileNotFoundException("fdia_smartgrid1.csv file is not in correct location");
        var path2 = @"D:\HCL\RealTimeProblems\fdia_smartgrid2.csv";
        if(!File.Exists(path2)) throw new FileNotFoundException("fdia_smartgrid2.csv file is not in correct location");
        
        var csv1 = File.ReadAllLines(path1).Skip(1).Select(lines => lines.Split(',')).Select(data => new
                  {
                      FDIA1 = double.Parse(data[5]),
                      FDIA1Volt = double.Parse(data[1])

                  });
        var csv2 = File.ReadAllLines(path2).Skip(1).Select(lines=> lines.Split(',')).Select(data => new
        {
            FDIA2 = double.Parse(data[5]),
            FDIA2Volt = double.Parse(data[1])
        });

        var ms = csv1.Join(csv2, 
                        result1 => result1.FDIA1,
                        result2 => result2.FDIA2,
                        (result1, result2) => new
                        {
                           Voltage1 = result1.FDIA1Volt,
                           Voltage2 = result2.FDIA2Volt
                        });
            foreach(var obj in ms){
                Console.WriteLine($"Voltage 1=>{obj.Voltage1}\nVoltage 2=> {obj.Voltage2}");
                // throw new IndexOutOfRangeException("Index is out of range");
            }

        } 
        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch(IndexOutOfRangeException i)
        {
            Console.WriteLine(i.Message);
        }
       
        
    }
}