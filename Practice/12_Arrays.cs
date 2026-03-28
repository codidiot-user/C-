using System;

class Solution
{
    static void Main (string[]vkivj)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        string str = Console.ReadLine();
        string[] res = str.Split(" ");
        for(int i=0;i<res.Length; i++)
        {
            arr[i] = Convert.ToInt32(res[i]);
        }
        
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
    }
}