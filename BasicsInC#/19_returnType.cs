using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] arr = new int [num];
        for (int i=0; i<num; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine(ValidTarget(arr, target));
    }
    static int ValidTarget(int[] arr, int tar)
    {
        if (arr.Length == 0) return -1;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i] == tar)
            {
                return i;
            }
        }
        return -1;
    }
}