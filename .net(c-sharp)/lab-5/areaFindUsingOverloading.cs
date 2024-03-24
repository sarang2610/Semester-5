using System;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area s = new Area();
            Console.WriteLine("enter length of squre");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter length of rectangle");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth of rectangle");
            double c =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("area of squre is"+(s.sum(a)));
            Console.WriteLine("area of rectangle is" + (s.sum(b,c)));




        }

    }
    class Area
    {
        public double sum(double x) {
            return x * x;
        }

        public double sum(double x, double y)
        {
            return x * y;
        }
    }
}