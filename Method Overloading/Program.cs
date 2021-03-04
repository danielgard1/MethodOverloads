using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(Add(2, 3, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(10, 6, true));
        }
        static public int Add(int x, int y)
        {
            return x + y;
        }

        static public double Add(double x, double y)
        {
            return x + y;
        }

        static public string Add(int x, int y, bool z)
        {
            if (z == true && x + y != 1)
            {
                return $"{x + y} dollars";
            }
            else {
                return $"{x + y} dollar";
            }
        }
    }
}
