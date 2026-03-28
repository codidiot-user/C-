using System;
class Program
{
    static void Main (string[]dijjs)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[num];
        for(int i=0;i<num;i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        int key = Convert.ToInt32(Console.ReadLine());
        bool f = false;
        foreach(int ind in array)
        {
            if(key == ind)
            {
                f = true;
            }
        }
        Console.WriteLine(f ? "Yes Key is avail" : "No, key is not avail");
    }
}