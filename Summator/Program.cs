namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is: " + Summator.Sum(new double[] { 2, 5 }));
            Console.WriteLine("The sum is: " + Summator.Average(new double[] { 2, 4 }));
            Console.WriteLine("The sum is: " + Summator.Multiply(new double[] { 5, 0 }));
        }

    }
}