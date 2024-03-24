namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.WriteLine("enter int value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter int value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter double value of c");
            double c =Convert.ToDouble(Console.ReadLine());

            int intsum = s.sum(a, b);
            double doublesum = s.sum(a, c);

            Console.WriteLine("ans is int sum "+intsum +"  and double sum"+doublesum);
        }

    }
    class Sum
    {
        public int sum(int x,int y) {
            return x + y;
        }

        public double sum(double x, double y)
        {
            return x + y;
        }
    }
}