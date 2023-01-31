namespace UnderstandingC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            int myNum1;
            myNum1= 5;

            int myint = 5, myInt2 = 6, myTot = myint + myInt2;
            myint = 6;

            if (myTot == 11)
                Console.WriteLine("We got 11!");
            else if(myTot > 11)
                Console.WriteLine("We have more than 11!");            
            else
                Console.WriteLine("We have less than 11!");
            
        }
    }
}