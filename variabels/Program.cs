namespace variabels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello";
            bool myBool = true;
            char myChar = 'A';


            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myString);
            //Console.WriteLine(myBool);
            //Console.WriteLine(myChar);

            Console.WriteLine("The value of myInt is {0,-5} and the value of myDouble is {1,5}", myInt, myDouble);
            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble);
            Console.WriteLine("The boolian value is set too " + myBool);
        }
    }
}