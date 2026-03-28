using System;

class Person
{
    private int _age;
    public int Age
    {
        get {return _age;}
        set {
            if(value >= 0 && value <=120 )
            {
                _age =  value;
            }
            else
            {
                Console.WriteLine("Invalid Age, so age set to 0");
                _age = 0;
            }
        }
    }
}
class Program
{
    static void Main (string[] skns) {
    Person p = new Person();
    p.Age = -150;
    Console.WriteLine("Age: " + p.Age);

    p.Age = 25; 
    Console.WriteLine("Age: " + p.Age);
    }

}