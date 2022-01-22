using System;

namespace Demo_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // "var" is a keyword, it is used to declare an implicit type variable,
            // that specifies the type of a variable based on initial value.

            var firstName = "Javad";           //Implicitly typed
            string lastName = "Azizbayli";     //Explicitly typed 

            //string concatenation 
            var fullName = firstName + " " + lastName;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(fullName);
            Console.ResetColor();

            //string format
            var myFullName = string.Format("My naem is {0} {1}", firstName, lastName);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(myFullName);
            Console.ResetColor();

            //string format
            string[] names = new string[3] { "Ali", "Arzu", "Nazim" };
            var formattedNames = string.Join(",", names);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(formattedNames);
            Console.ResetColor();

            var text = "Hey, check this paths: \nC:\\folder1\\folder2\nC:\\folder3\\folder4";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();

            //verbatim string
            var text1 = @"Hey, check these:
C:\folder1\folder2
C:\folder3\folder4";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(text1);
            Console.ResetColor();
        }
    }
}
