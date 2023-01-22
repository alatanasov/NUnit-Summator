namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is " + Summator.Sum(new int[] { 1, 2, 3 }));
            Console.WriteLine("the average is " + Summator.Average(new int[] { 4, 5, 7 }));
        }
    }
}