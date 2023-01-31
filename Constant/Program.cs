namespace Constant
{
    internal class Program
    {
        //Enum group of constants
        enum DaysOfWeek 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            sunday,
        }

        static void Main(string[] args)
        {
            const int myConstInt = 5;

            DayOfWeek today = DayOfWeek.Monday;
            Console.WriteLine(today);

            int numOfToday = (int)today;
            Console.WriteLine(numOfToday);
        }
    }

}