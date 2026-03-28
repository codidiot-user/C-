using System;
class Program
{
    static void Main()
    {
        List<int> ls= new List<int>();
        ls.Add(1); ls.Add(2); ls.Add(3);
        foreach(int obj in ls)
        {
            Console.Write(obj + " ");
        }
    }
} 