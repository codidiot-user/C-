using System;
interface Animals
{
    public void CommonAnimal();
}
class Dog :  Animals
{
    public void CommonAnimal()
    {
        Console.WriteLine("Dog, barks!!!");
    }
}

class Program
{
    static void Main(string[]asa)
    {
        Dog d1 = new Dog();
        d1.CommonAnimal();
    }
}