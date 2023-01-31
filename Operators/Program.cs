namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +, -, *, /, %

            int myInt = 5 + 5;
            int myInt2 = 5 - 5;
            int myInt3 = 5 * 5;

            double myDouble = 45.0 / 2;
            Console.WriteLine(myDouble);

            double remain = 5 % 4;
            Console.WriteLine(remain);


            int result = 2 + 3 * 4;
            Console.WriteLine($"The result is {result}");

            // Adding numbers to it self 
            int x = 5;
            x = x + 1;
            x += 1; // same as above

            int y = 5;
            y++;
            ++y;

            int b = 4;
            int c = b++; //++ after b gives the first b a new value. ++ before adds 1 to the first b.

            Console.WriteLine("The value of b is {0} and the value of c is {1}", b, c);
        }
    }
}