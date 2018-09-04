using System;

namespace project_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;    // Set backgrount color
            Console.ForegroundColor = ConsoleColor.Black;   // Set text color


            Console.SetWindowSize(40, 70);  // Set console size in winows 
            Console.Title = "Project 1";    // Set title in console
           
            // Console.SetCursorPosition(2,4); // Set cursor position in console
            // Console.LargestWindowWidth = 100; // Only in Windows

            Console.CursorLeft = 10;

            int a = 0;
			int b = 0;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the a number: ");
            a = int.Parse(Console.ReadLine());
			Consile.WriteLine("Enter the b number: ");
			b = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is " + (a+b));


        }
    }
}
