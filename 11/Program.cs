using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to Reverse order of a number, 2 to find average of numbers, and 3 to solve ax+b=0");
            int option=int.Parse(Console.ReadLine());
            if(option==1)
            {
                Console.WriteLine("Enter number");
                string num=Console.ReadLine();
                Reverse(num);
            }
            else if(option==2)
            {
                Console.WriteLine("How many numbers do you want to enter");
                int n=int.Parse(Console.ReadLine());
                int ave=Average(n)/n;
                Console.WriteLine("The average is "+ave);
            }
            else if(option==3)
            {
                Console.WriteLine("Enter coefficient of x");
                int a=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value of constant b");
                int b=int.Parse(Console.ReadLine());    
                int x=Linear(a,b);
                Console.WriteLine("For "+a+"x+"+b+"=0");
                Console.WriteLine("x="+x);
            }
            else{Console.WriteLine("Invalid input");};


        }  

        static void Reverse(string a)
        {
            int b=a.Length-1;
            for(int j=b;j>=0;j--)
            {
                Console.Write(a[j]);
            }
        }

        static int Average(int a)
        {
            Console.WriteLine("Enter number");
            int num=int.Parse(Console.ReadLine());            
            if(a==1)
            {
                return num;
            }
            return num+Average(a-1);
        }

        static int Linear(int a,int b)
        {
            int x=(-b)/a;
            return  x;
        }
    }
}
