using System;

namespace ZeroArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr; // описание
            int i = 0; 
            string s;
            arr = new int[10]; // создание массива
            for (i = 0; i < arr.Length; ++i)
            {
                arr[i] = 0;
                Console.WriteLine ("arr["+i+"] = "+arr[i]);
            }
        //Ввод массива с клавиатуры
            for (i = 0; i < arr.Length; ++i)
            {
                Console.Write("arr["+i+"] = ");
                s = Console.ReadLine();
                arr[i] = Convert.ToInt32(s);
            }
            for (i = 0; i < arr.Length; ++i)
                Console.WriteLine ("arr["+i+"] = "+arr[i]);  
        }
    }
}
