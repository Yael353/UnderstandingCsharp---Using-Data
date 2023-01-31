namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name? ");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Hello there {name}");

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            number += 10;

            Console.WriteLine($"The new number is {number}");

        }
    }
}