namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            ex2();
            ex3();
        }



        private static void Exercise1()
        {
            // Build a simple calculator. Read in two integers from the user and add them togheter.
            // print the results in a nice output statement.

            Console.WriteLine("Add a whole number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add another whole number");
            int num2 = int.Parse(Console.ReadLine());

            int totNum = num1 + num2;
            Console.WriteLine($" {num1} + {num2} = {totNum}");
        }
        private static void ex2()
        {
            //Write a program that asks the user for the lenght and width of their room.Define a constant
            //that represents the price of ccarperting per square foot.compute and display the cost of carpenting the room.


            Console.WriteLine("In meters, how long is your bedroom?");
            int roomLenght = int.Parse(Console.ReadLine());
            Console.WriteLine("In meters, how whide is your room?");
            int roomWidth = int.Parse(Console.ReadLine());

            int sqrFeet = roomLenght * roomWidth;
            const double pricePerSqr = 5;
            double cost = sqrFeet * pricePerSqr;


            Console.WriteLine($"You have {sqrFeet} square feet. The price per squarefeet is {pricePerSqr}, total cost will therefore be {cost}");
        }
        private static void ex3()
        {
            // write a program that asks the user to enter a total amount of time in minutes only.
            // Print to the console the same amount of time in hours and minutes.

            Console.WriteLine("Write time spended on your studies in minutes.");
            int timeSpended = int.Parse(Console.ReadLine());

            double hours = timeSpended / 60;
            double remainingMinutes = timeSpended % 60;

            Console.WriteLine($"time spended was {hours} hour and {remainingMinutes} minutes.");
        }
    }
}