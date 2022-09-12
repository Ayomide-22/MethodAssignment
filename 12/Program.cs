using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter degree of first polynomial");
            int first=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter degree of second polynomial");
            int second=int.Parse(Console.ReadLine());   
            int[] pol1=new int[first];
            int[] pol2=new int[second];   
            Console.WriteLine("Enter coefficients in first polynomial");
            for(int j=0;j<first;j++)
            {
                Console.WriteLine($"Enter coefficient of x^{j}");
                pol1[j]=int.Parse(Console.ReadLine());
            }  
            Console.WriteLine();
            Console.WriteLine("Enter coefficients in second polynomial");
            for(int j=0;j<second;j++)
            {
                Console.WriteLine($"Enter coefficient of x^{j}");
                pol2[j]=int.Parse(Console.ReadLine());
            }            
            PrintPoly(pol1,first);
            Console.WriteLine();
            PrintPoly(pol2,second);
            Console.WriteLine();
            if(first>=second)
            {
                int[] sum=new int[first];
                sum=SumPoly(pol1,pol2,first,second);
                Console.WriteLine("Their sum is");
                PrintPoly(sum,first);
            }   
            else
            {
                int[] sum=new int[second];
                sum=SumPoly(pol1,pol2,first,second);
                Console.WriteLine("Their sum is");
                PrintPoly(sum,second);
            }
        }

        static int[] SumPoly(int[] pol1,int[] pol2,int first,int second)
        {
            if(first>=second)
            {
                for(int j=0;j<second;j++)
                {
                    pol1[j]=pol1[j]+pol2[j];
                }
                return pol1;
            }
            else
            {
                for(int j=0;j<first;j++)
                {
                    pol2[j]=pol1[j]+pol2[j];
                }
                return pol2;
            }            

        }

        static void PrintPoly(int[] pol, int num)
        { 
            for(int j=0;j<num;j++)
            {
                if(j==num-1)
                {
                    Console.Write($"{pol[j]}x^{j}");
                }
                else 
                {
                    Console.Write($"{pol[j]}x^{j} + ");
                }
            }     
        }

    }
}
