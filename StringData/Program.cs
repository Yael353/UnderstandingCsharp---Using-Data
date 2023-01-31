namespace StringData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello world!";
            Console.WriteLine(myString);


            string name1 = "Boolian";
            string name2 = "Lian";
            
            int namesEqual = string.Compare(name1,name2);
            //int namesEqual = name1.CompareTo(name2); Does the same as above.

            Console.WriteLine("Names equal: {0}", namesEqual);
            Console.WriteLine("{0} has {1} characters and {2} has {3} charecters", name1, name1.Length, name2, name2.Length);

            string firstCharachterOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharachterOfName);

            string middleSectionOfName = name1.Substring(1, 6);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = name1.StartsWith("Bo");
            Console.WriteLine(startsWith);
        }
    }
}