using System;

class Program
{
    static bool POLINDROM(int n)
    {
        double a, b, k;
        a = n;
        b = 0;
        while(n!=0){
            k=n%10;
            n=n/10;
            b=b*10+k;
        }

        return (a == b);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Input number a : ");
            int a = int.Parse(Console.ReadLine());
            if (a < 9999)
     
                for (int i = 0; i < a; i++)
                {
                    if( POLINDROM(i*i))
                        Console.WriteLine(i + " | " +(i*i));
                }
                   
        }
    }

}