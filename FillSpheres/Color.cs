using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte Alpha;

        // Constructor for each color
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        // Constructor that accepts each color and puts alpha at 255
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        // Getters and setters for each color
        public byte GetRed()
        {
            return Red;
        }

        public void SetRed(byte red)
        {
            Red = red;
        }

        public byte GetGreen()
        {
            return Green;
        }

        public void SetGreen(byte green)
        {
            Green = green;
        }

        public byte GetBlue()
        {
            return Blue;
        }

        public void SetBlue(byte blue)
        {
            Blue = blue;
        }

        public byte GetAlpha()
        {
            return Alpha;
        }

        public void SetAlpha(byte alpha)
        {
            Alpha = alpha;
        }

        // Method GetGrey that returns the average of the RGB values
        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }
    }
}