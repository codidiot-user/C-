using System;
class Car
{
    private int _speed; 
    public int Speed
    {
        get 
        { 
            return _speed; 
        }
        set 
        {
            if( value < 0 )
            {
                _speed = 0;
                Console.WriteLine("Invalid Speed.");
            } else
            {
                _speed  = value;
            }
             
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        
        myCar.Speed = -50; 
        Console.WriteLine("Current Speed: " + myCar.Speed); 
        
        myCar.Speed = 100; 
        Console.WriteLine("Current Speed: " + myCar.Speed);
    }
}