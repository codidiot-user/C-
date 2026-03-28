using System.IO;
using System;
class Program
{
    static void Main()
    {
        string path = @"D:\HCL\LinQ\dataset.csv";
        string[] str = File.ReadAllLines(path);
        foreach (string st in str)
        {
            
           Console.WriteLine(st); 
        }

    }
}