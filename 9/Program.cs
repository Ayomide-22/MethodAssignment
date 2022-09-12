using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length=int.Parse(Console.ReadLine());
            int[] arr= new int[length];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter number");
                arr[i]=int.Parse(Console.ReadLine());
            }
            FindBiggest(arr);
        }

        static void FindBiggest(int[] arr)
        {
            int biggest1=arr[0];
            int swap=0;
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]>biggest1)
                {
                    biggest1=arr[i];
                }
            }
            Console.WriteLine("The biggest number in the array is "+biggest1);

            for(int i=0;i<arr.Length;i++)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    if(arr[i]<arr[j])
                    {
                        swap=arr[j];
                        arr[j]=arr[i];
                        arr[i]=swap;
                    }
                }
            Console.WriteLine("The array in descending order is");
            foreach (var item in arr)
           {
            Console.WriteLine(item);
           }
        }
    }
}
