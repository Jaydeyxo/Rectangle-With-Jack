using System;

namespace Jayde_Storry_Jack_Martin_Assignment2
{
        public class Rectangle
        {
           private int length = 1;
           private int width = 1;


            public Rectangle()
            {
            
            }


           public int GetLength()
        {
            return length;
        }

        public int SetLength(int newLength)
        {
            length = newLength;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int newWidth)
        {
            width = newWidth;
            return width;
        }


        public int GetArea()
        {
            return length * width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
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
