using System;

namespace perimetr
{
    class Program
    {
        static void Main(string[] args)
        {
            int Perimetr (int x, int y)
            {
                return 2*(x + y);
            }
            int a = 10, b = 15;
            Console.WriteLine(Perimetr(a, b));
        }
    }
}
