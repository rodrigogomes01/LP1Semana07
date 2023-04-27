using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color
    {
        // Constructor for each color
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        // Constructor that accepts each color and puts alpha at 255
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        // Getters and setters
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        // Method GetGrey that returns the average of the RGB values
        public byte GetGrey { get => (byte)((Red + Green + Blue) / 3); }

        // Method to get name of color
        public string GetName
        {
            get
            {
                if (Red == 255 && Green == 0 && Blue == 0)
                {
                    return "Red";
                }
                else if (Red == 0 && Green == 255 && Blue == 0)
                {
                    return "Green";
                }
                else if (Red == 0 && Green == 0 && Blue == 255)
                {
                    return "Blue";
                }
                else if (Red == 255 && Green == 255 && Blue == 255)
                {
                    return "White";
                }
                else if (Red == 0 && Green == 0 && Blue == 0)
                {
                    return "Black";
                }
                else if (Red == 255 && Green == 255 && Blue == 0)
                {
                    return "Yellow";
                }
                else if (Red == 0 && Green == 255 && Blue == 255)
                {
                    return "Cyan";
                }
                else if (Red == 255 && Green == 0 && Blue == 255)
                {
                    return "Magenta";
                }
                else
                {
                    return "Custom";
                }
            }
        }
    }
}