using System;

namespace EGE01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CreateArray(int n)
            {
                int [] arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; ++i)
                    arr[i] = rnd.Next(0, 101);
                return arr;
            }
            void PrintArr (int[] arr)
            {
                for (int i = 0; i < arr.Length; ++i)
                    Console.WriteLine("Arr["+i+"] ="+arr[i]);    
            }
            int[] arr = new int[30];
            arr = CreateArray(30);
            PrintArr (arr);
            long p = 1;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (((arr[i] % 2) == 0) && ((arr[i] % 10) != 0) && (arr[i] != 0))
                  p = p * arr[i];
            }
            if (p == 1)
                p = 0;
            Console.WriteLine("Произведение = "+p);
        }
    }
}
