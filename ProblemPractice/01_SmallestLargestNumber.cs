using System;

class Program
{
    static void Main (string[]ooo)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        int min = -1000001;
        for(int i=0;i<num;i++)
        {
           arr[i] = Convert.ToInt32(Console.ReadLine()); 
        }
        for(int i=0;i<num;i++)
        {
            if(min < arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine(min);
    }
}