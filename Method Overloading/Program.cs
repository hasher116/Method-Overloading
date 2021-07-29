using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Calc clc = new Calc();
            Console.WriteLine(clc.sum(6.4f, 4));
            clc.incr(x);
            clc.incr(x);
            clc.incr(ref x);
            clc.incr(ref x);
        }
    }

    class Calc
    {
        public int sum (int x, int y)
        {
            return x + y;
        }
        public float sum(float x, int y)
        {
            return x + y;
        }
        public int sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public void incr (int f)
        {
            f++;
            Console.WriteLine(f);
        }
        public void incr (ref int f)
        {
            f++;
            Console.WriteLine(f);
        }
    }
}
