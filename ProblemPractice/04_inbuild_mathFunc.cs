using System.Linq;
class Programm
{
    static void Main (string[]dsd)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] array = new int [num];
        for(int i=0;i<num;i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Max value is: "+array.Max());
        Console.WriteLine("Min value is: "+array.Min());
        Console.WriteLine("Sum value is: "+array.Sum());
        Console.WriteLine("Clamp: "+Math.Clamp(10, 1,2));
    }
}