using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Input number x : ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Input number y : ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Input number z : ");
        double z = Convert.ToDouble(Console.ReadLine());
        if (x == 0 || y == 0 || z == 0)
        {
            Console.WriteLine(" Error invalid number "); 
            return;
        }
        double a = Math.Cos(x + (x * y / z));
        Console.WriteLine("a = " +a);
        double b = (Math.Pow(x, 3))/ Math.Cos(a);
        Console.WriteLine("b = " +b);
    }
}