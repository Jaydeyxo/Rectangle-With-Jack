using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jayde_Storry_Jack_Martin_AssignmentTwo.Assignment2Tests { 
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
}
