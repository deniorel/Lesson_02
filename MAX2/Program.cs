using System;

namespace MAX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max (int a, int b)
            {
                if (a >= b)
                    return a;
                else
                    return b;
            }
            Console.WriteLine(max (56, 415));
        }
    }
}
