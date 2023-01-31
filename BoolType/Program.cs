namespace BoolType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bools is important, almost everything is basically true or false.
            bool myBool = true;

            // >, <, >=, <=, ==, !=

            //returns false because 5 is not more than 6.
            bool myBool2 = 5 > 6;

            //My bool2 is a variable and can be changed like any other variable that is not a constant.
            myBool2 = 6 != 6;
            Console.WriteLine(myBool2);

            // if hours worked are 25 then the person has not been working overtime as it requires more than 40, therefore it will return false.
            int hoursWorked = 25;
            bool doesEmployeeGetOerTime = hoursWorked > 40;
            Console.WriteLine("Does employee get overtime? {0} ", doesEmployeeGetOerTime);
        }
    }
}