using System;

namespace MAX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max3(int a, int b, int c)
            {
                if ((a > b) && (a > c))
                    return a;
                else if ((b > a) && (b > c))
                    return b;
                else
                    return c;                 
            }
            int a = 213, b = 45, c = 46;
            Console.WriteLine (max3(a, b, c));
        }
    }
}
