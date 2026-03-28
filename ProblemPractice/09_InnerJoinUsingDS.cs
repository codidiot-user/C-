using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {
        try
        {
            var path1 = @"D:\HCL\ProblemPractice\DataSet1.csv";
            if(!File.Exists(path1)) throw new FileNotFoundException("File1 is not in this location");
            var path2 = @"D:\HCL\ProblemPractice\DataSet2.csv";
            if(!File.Exists(path2)) throw new FileNotFoundException("File2 is not in this location");
            var csv1 = File.ReadAllLines(path1).Skip(1).Select(lines=> lines.Split(',')).Select(fields => new
            {
                Names = fields[0],
                PhoneNum = int.Parse(fields[2])
            });
            var csv2 = File.ReadAllLines(path2).Skip(1).Select(lines => lines.Split(',')).Select(fields => new
            {
                Names = fields[0],
                PhoneNum2 = int.Parse(fields[2])
            });
            var ms = csv1.Join(csv2,
                               NamesOfStuInD1 => NamesOfStuInD1.Names,
                               NamesOfStuInD2 => NamesOfStuInD2.Names,
                               (NamesOfStuInD1, NamesOfStuInD2) => new
                               {
                                   StudentName = NamesOfStuInD1.PhoneNum,
                                   Stu = NamesOfStuInD1.Names,
                                   PhnNumber = NamesOfStuInD2.PhoneNum2
                               });
            foreach(var obj in ms)
            {
                Console.WriteLine($"Name: {obj.Stu}, Phone Number: {obj.PhnNumber}");
            }
        }
        catch (FileNotFoundException f)
        {
            Console.WriteLine(f.Message);
        }
    }
}