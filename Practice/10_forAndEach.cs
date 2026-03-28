using System;
using System.ComponentModel.DataAnnotations;

class main
{
    static void Main (string[]pp)
    {
        for(int i=0;i<5;i++)
        {
            Console.WriteLine(i);
        }
        string[] myArr =  {"BMW", "Hero", "Ather", "Audi"};
        foreach (string ind in myArr)
        {
            Console.Write(ind+" ");
        }
    }
}