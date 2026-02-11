using System;
using Jayde_Storry_Jack_Martin_AssignmentTwo.Assignment2Tests;

namespace Jayde_Storry_Jack_Martin_Assignment2
{
       
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            Console.Write("Enter the length of the rectangle: ");
            int userLength = Convert.ToInt32(Console.ReadLine());
            rect.SetLength(userLength);

            Console.Write("Enter the width of the rectangle: ");
            int userWidth = Convert.ToInt32(Console.ReadLine());
            rect.SetWidth(userWidth);

            Console.WriteLine("Area: " + rect.GetArea());
            Console.WriteLine("Perimeter: " + rect.GetPerimeter());
        }
    }
}
