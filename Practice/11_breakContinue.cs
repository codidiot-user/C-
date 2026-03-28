using System;

class Second
{
    static void Main(string[] skjhe)
    {
        // for (int i = 0; i <= 20; i++)
        // {
        //     if (i % 4 == 0) continue;
        //     Console.Write(i + " ");
        // }
        int i = 0;
        while (i <= 20)
        {
            i++;
            if( i % 4 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}