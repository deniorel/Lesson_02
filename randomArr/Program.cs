using System;

namespace randomArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr; // описание
            arr = new int[7];
            int i = 0; 
            Random rnd = new Random();
        // Заполнение массива случайными числами
            for (i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(201, 501);
                Console.WriteLine ("arr["+i+"] = "+arr[i]);  
            }
        }
    }
}
