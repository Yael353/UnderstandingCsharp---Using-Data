namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = x;

            double myDouble = 5.5;
            int myInt = (int)myDouble; // int here forces the convert from double to int, called casting.

            Console.WriteLine(myDouble);
        }
    }
}