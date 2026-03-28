using System;
class Program
{
    static void Main (string[]dd)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        // int[] a = new int[num];
        // for(int i=0;i<num;i++)
        // {
        //     a[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Array.Sort(a);
        // foreach(int ind in a)
        // {
        //     Console.Write(ind+" ");
        // }
        string[] str = new string[num];
        for(int i=0;i<num;i++)
        {
           str[i] = Console.ReadLine(); 
        }
        Array.Sort(str);
        foreach(string ind in str)
        {
            Console.Write(ind+" ");
        }
    }
}