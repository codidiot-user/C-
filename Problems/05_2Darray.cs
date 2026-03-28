using System;
class Prohram
{
    static void Main (string[]eoijc)
    {
        int row = Convert.ToInt32(Console.ReadLine());
        int col = Convert.ToInt32(Console.ReadLine());
        int [,] arr = new int[row, col];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}