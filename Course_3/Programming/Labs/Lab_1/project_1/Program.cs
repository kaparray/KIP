using System;
using static System.Math;

namespace project_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.SetWindowSize(40, 70);  // Set console size in winows 
            Console.Title = "Project 1";    // Set title in console

            Console.BackgroundColor = ConsoleColor.Cyan;    // Set backgrount color
            Console.ForegroundColor = ConsoleColor.Black;   // Set text color

            // Console.SetCursorPosition(2,4); // Set cursor position in console
            // Console.LargestWindowWidth = 100; // Only in Windows



            Console.CursorLeft = 10;

            int a = 0;
			int b = 0;
            Double r = 0.705052;

            Console.WriteLine("Hello World!\n\n");
            Console.WriteLine("Enter the a number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b number: ");
			b = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number is " + (a+b));

            Console.WriteLine("\n\nYour number {0}", Math.Round(r,2));


            int[] array = new int[10]; // Create array in C# with 10 item

            for (int i = 0; i < 10; i++){

                array[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
