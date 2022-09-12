using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 and 100");
            double x=double.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }

        static double Factorial(double a)
        {
            if(a==0)
            {
                return 1;
            }
            return a*=Factorial(a-1);
        }
    }
}
